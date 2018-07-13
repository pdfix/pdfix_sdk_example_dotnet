////////////////////////////////////////////////////////////////////////////////////////////////////
// AddComment.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*! 
\page CS_Samples C# Samples
- \subpage AddComment_cs
*/
/*! 
\page AddComment_cs Add Comment Sample
// Example how to add a comment with reply into PDF.
\snippet /AddComment.cs AddComment_cs
*/

//\cond INTERNAL
//! [AddComment_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class AddComment
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

            PdfPage page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());

            PdfRect cropBox = page.GetCropBox();

            // place annotation to the middle of the page
            PdfRect annotRect = new PdfRect();
            annotRect.left = (cropBox.right + cropBox.left) / 2.0 - 10;
            annotRect.bottom = (cropBox.top + cropBox.bottom) / 2.0 - 10;
            annotRect.right = (cropBox.right + cropBox.left) / 2.0 + 10;
            annotRect.top = (cropBox.top + cropBox.bottom) / 2.0 + 10;

            PdfTextAnnot annot = page.AddTextAnnot(-1, annotRect);
            if (annot == null)
                throw new Exception(pdfix.GetError());
            annot.SetAuthor(@"Peter Brown");
            annot.SetContents(@"This is my comment.");
            annot.AddReply(@"Mark Fish", @"This is some reply.");

            doc.ReleasePage(page);

            if (!doc.Save(savePath, PdfSaveFlags.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [AddComment_cs]
//\endcond
