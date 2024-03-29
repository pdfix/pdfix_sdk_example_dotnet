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
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            PdfPage page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());

            PdfRect cropBox = page.GetCropBox();

            // place annotation to the middle of the page
            PdfRect annotRect = new PdfRect();
            annotRect.left = (float)((cropBox.right + cropBox.left) / 2.0) - 10;
            annotRect.bottom = (float)((cropBox.top + cropBox.bottom) / 2.0) - 10;
            annotRect.right = (float)((cropBox.right + cropBox.left) / 2.0) + 10;
            annotRect.top = (float)((cropBox.top + cropBox.bottom) / 2.0) + 10;

            PdfTextAnnot annot = (PdfTextAnnot)page.CreateAnnot(PdfAnnotSubtype.kAnnotText, annotRect);
            page.AddAnnot(-1, annot);
            if (annot == null)
                throw new Exception(pdfix.GetError());
            annot.SetAuthor(@"Peter Brown");
            annot.SetContents(@"This is my comment.");
            annot.AddReply(@"Mark Fish", @"This is some reply.");

            page.Release();

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}