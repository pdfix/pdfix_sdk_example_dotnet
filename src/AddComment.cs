////////////////////////////////////////////////////////////////////////////////////////////////////
// AddComment.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class AddComment
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath                             // output PDF document
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

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

            PdfTextAnnot annot = page.AddNewTextAnnot(-1, annotRect);
            if (annot == null)
                throw new Exception(pdfix.GetError());
            annot.SetAuthor(@"Peter Brown");
            annot.SetContents(@"This is my comment.");
            annot.AddReply(@"Mark Fish", @"This is some reply.");

            page.Release();

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}