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
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            PsFileStream stm = pdfix.CreateFileStream(configPath, PsFileMode.kPsReadOnly);
            if (stm != null)
            {
                var doc_prelight = doc.GetTemplate();
                if (doc_prelight == null)
                    throw new Exception(pdfix.GetError());
                doc_prelight.LoadFromStream(stm, PsDataFormat.kDataFormatJson);
                stm.Destroy();
            }

            // define a cancel progress callback
            PdfCancelProc cancel_callback = (data) =>
            {
                // to cancel the process return 1
                Console.WriteLine("PdfCancelProc callback was called");
                return 0;
            };

            PdfPage page = doc.AcquirePage(0);
            PdePageMap pageMap = page.AcquirePageMap(null, IntPtr.Zero);

            // define an event callback
            PdfEventProc event_callback = (data) =>
            {
                Console.WriteLine("Page contents did change. Releasing pageMap...");
                if (pageMap != null)
                {
                    pageMap.Release();
                    pageMap = null;
                }
            };
            if (!pdfix.RegisterEvent(PdfEventType.kEventPageContentsDidChange, event_callback, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.RemoveTags(cancel_callback, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.AddTags(cancel_callback, IntPtr.Zero)) 
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            if (!pdfix.UnregisterEvent(PdfEventType.kEventPageContentsDidChange, event_callback, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}