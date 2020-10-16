////////////////////////////////////////////////////////////////////////////////////////////////////
// MakeAccessible.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class MakeAccessible
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            bool preflight,                             // preflight page before tagging
            String language,                            // document reading language
            String title,                               // document title
            String configPath                           // configuration file
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            var doc_template = doc.GetTemplate();

            // convert to PDF/UA
            PdfAccessibleParams accParams = new PdfAccessibleParams();
            if (!doc.MakeAccessible(accParams, null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}