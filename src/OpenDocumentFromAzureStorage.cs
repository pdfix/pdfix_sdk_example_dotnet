using PDFixSDK.Pdfix;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Azure.Storage.Blobs;
using System.Threading.Tasks;

namespace PDFix.App.Module
{
    class OpenFileFromAzureStorage
    {
        public static async Task RunAsync(string open_file)
        {
            Pdfix pdfix = PdfixEngine.Instance;

            //For testing purposes, Azurite needs to be installed and configured to run this sample
            //https://docs.microsoft.com/en-us/azure/storage/common/storage-use-azurite?tabs=visual-studio
            //To manage blobs use https://azure.microsoft.com/en-us/features/storage-explorer/ 
            var testClient = new BlobContainerClient(
                "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;",
                "sample" //blob container named "sample"
                );

            var stream = await testClient.GetBlobClient(open_file).OpenReadAsync();

            // open doc using custom stream
            PsStreamReadProc read_proc = (offset, buffer, size, client_data) =>
            {
                // read byte[] data from the Stream by chunks and copy to buffer 
                var stm = (((GCHandle)client_data).Target as Stream);
                if (!stm.CanSeek) return -1;
                stm.Position = offset;
                byte[] buf = new byte[size];
                var ret = stm.Read(buf, 0, size);
                if (ret <= 0) return -1;
                Marshal.Copy(buf, 0, buffer, size);
                return size;
            };
            PsStreamGetSizeProc get_size_proc = (client_data) =>
            {
                // return the size of stream
                var stm = (((GCHandle)client_data).Target as Stream);
                return (int)stm.Length;
            };

            var client_data_handle = GCHandle.Alloc(stream);
            var customStm = pdfix.CreateCustomStream(read_proc, (IntPtr)client_data_handle);
            customStm.SetGetSizeProc(get_size_proc);

            PdfDoc doc = pdfix.OpenDocFromStream(customStm, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());
            Console.WriteLine(@"Document open from Azure storage: {0} pages", doc.GetNumPages());
            doc.Close();
            customStm.Destroy();
            client_data_handle.Free();

        }
    }
}