////////////////////////////////////////////////////////////////////////////////////////////////////
// AddTags.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*!
\page CS_Samples C# Samples
- \subpage AddTags_cs
*/
/*!
\page AddTags_cs Add Tags C# Sample
Example how to automatically add tags into the document.
\snippet /AddTags.cs AddTags_cs
*/

//\cond INTERNAL
//! [AddTags_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class AddTags
    {
        public static void Run(
            String email,                       // authorization email   
            String licenseKey,                  // authorization license key
            String openPath,                    // source PDF document
            String savePath,                    // output PDF document
            String configPath                   // configuration file
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetError());

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            PsFileStream stm = pdfix.CreateFileStream(configPath, PsFileMode.kPsReadOnly);
            if (stm != null)
            {
                PdfDocTemplate docTmpl = doc.GetDocTemplate();
                if (docTmpl == null)
                    throw new Exception(pdfix.GetError());
                docTmpl.LoadFromStream(stm, PsDataFormat.kDataFormatJson);
                stm.Destroy();
            }

            if (!doc.AddTags(null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, PdfSaveFlags.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [AddTags_cs]
//\endcond
