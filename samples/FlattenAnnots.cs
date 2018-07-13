////////////////////////////////////////////////////////////////////////////////////////////////////
// FlattenAnnots.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*! 
\page CS_Samples C# Samples
- \subpage FlattenAnnots_cs
*/
/*! 
\page FlattenAnnots_cs Flatten Annots Sample
// Example how to flatten annots into the page content.
\snippet /FlattenAnnots.cs FlattenAnnots_cs
*/

//\cond INTERNAL
//! [FlattenAnnots_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class FlattenAnnots
    {
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            PdfFlattenAnnotsParams flattenAnnotsParams  // flatten annots params
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

            if (!doc.FlattenAnnots(flattenAnnotsParams))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, PdfSaveFlags.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [FlattenAnnots_cs]
//\endcond
