////////////////////////////////////////////////////////////////////////////////////////////////////
// MakeAccessible.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*! 
\page CS_Samples C# Samples
- \subpage MakeAccessible_cs
*/
/*! 
\page MakeAccessible_cs Make PDF Accessible Sample
// Example how to make PDF Accessible.
\snippet /MakeAccessible.cs MakeAccessible_cs
*/

//\cond INTERNAL
//! [MakeAccessible_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class MakeAccessible
    {
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String language,                            // document reading language
            String title,                               // document title
            String configPath                           // configuration file
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

            // convert to PDF/UA
            PdfAccessibleParams accParams = new PdfAccessibleParams();
            if (!doc.MakeAccessible(accParams, null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, PdfSaveFlags.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [MakeAccessible_cs]
//\endcond
