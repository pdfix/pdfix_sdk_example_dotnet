////////////////////////////////////////////////////////////////////////////////////////////////////
// AddTags.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class AddTags
    {
        public static void Run(
            String openPath,                    // source PDF document
            String savePath,                    // output PDF document
            String configPath                   // configuration file
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            // open the document
            var doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            using (var stm = pdfix.CreateFileStream(configPath, PsFileMode.kPsReadOnly))
            {
                var doc_prelight = doc.GetTemplate();
                if (doc_prelight == null)
                    throw new Exception(pdfix.GetError());
                doc_prelight.LoadFromStream(stm, PsDataFormat.kDataFormatJson);
            }

            // define a cancel progress callback
            PdfCancelProc cancel_callback = (data) =>
            {
                    // to cancel the process return 1
                Console.WriteLine("PdfCancelProc callback was called");
                return 0;
            };

            if (!doc.RemoveTags(cancel_callback, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.AddTags(cancel_callback, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}