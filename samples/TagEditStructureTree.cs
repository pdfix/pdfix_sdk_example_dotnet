////////////////////////////////////////////////////////////////////////////////////////////////////
// TagEditStructureTree.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*! 
\page CS_Samples C# Samples
- \subpage TagEditStructureTree_cs
*/
/*! 
\page TagEditStructureTree_cs Editing structure tree
Example how to tag the document and edit tag structure.
\snippet /TagEditStructureTree.cs TagEditStructureTree_cs
*/

//\cond INTERNAL
//! [TagEditStructureTree_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagEditStructureTree
    {
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath                             // output PDF document
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

            if (!doc.RemoveTags(null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.AddTags(null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, PdfSaveFlags.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [TagEditStructureTree_cs]
//\endcond
