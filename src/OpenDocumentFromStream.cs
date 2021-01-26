using PDFixSDK.Pdfix;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace PDFix.App.Module.Public
{
    class OpenFileFromStream
    {
        public static void Run(String open_file)
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            // open doc using file stream
            var fileStm = pdfix.CreateFileStream(open_file, PsFileMode.kPsReadOnly);
            PdfDoc doc0 = pdfix.OpenDocFromStream(fileStm, "");
            if (doc0 == null)
                throw new Exception(pdfix.GetError());
            Console.WriteLine(@"Document open from file stream: {0} pages", doc0.GetNumPages());
            doc0.Close();

            // open doc using memory stream
            byte[] fileData = new byte[fileStm.GetSize()];
            fileStm.Read(0, fileData);

            var memStm = pdfix.CreateMemStream();
            memStm.Write(0, fileData);

            PdfDoc doc1 = pdfix.OpenDocFromStream(memStm, "");
            if (doc1 == null)
                throw new Exception(pdfix.GetError());
            Console.WriteLine(@"Document open from memory stream: {0} pages", doc1.GetNumPages());
            doc1.Close();
            memStm.Destroy();

            // open doc using custom stream
            PsStreamReadProc read_proc = (offset, buffer, size, client_data) =>
            {
                // read byte[] data from the source and copy to buffer 
                var stm = (((GCHandle)client_data).Target as PsStream);
                byte[] buf = new byte[size];
                var ret = stm.Read(offset, buf);
                if (!ret) return -1;
                Marshal.Copy(buf, 0, buffer, size);
                return size;
            };
            PsStreamGetSizeProc get_size_proc = (client_data) =>
            {
                // return the size of stream
                var stm = (((GCHandle)client_data).Target as PsStream);
                return stm.GetSize();
            };

            var client_data_handle = GCHandle.Alloc(fileStm);
            var customStm = pdfix.CreateCustomStream(read_proc, (IntPtr)client_data_handle);
            customStm.SetGetSizeProc(get_size_proc);

            PdfDoc doc2 = pdfix.OpenDocFromStream(customStm, "");
            if (doc2 == null)
                throw new Exception(pdfix.GetError());
            Console.WriteLine(@"Document open from custom stream: {0} pages", doc2.GetNumPages());
            doc2.Close();
            customStm.Destroy();
            client_data_handle.Free();

            fileStm.Destroy();

        }
    }
}
