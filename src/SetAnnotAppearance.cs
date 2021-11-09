////////////////////////////////////////////////////////////////////////////////////////////////////
// SetAnnotAppearance.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class SetAnnotAppearance
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String imgPath                              // watermark to apply
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // identify image format from file path
            PdfImageFormat format = PdfImageFormat.kImageFormatJpg;
            if (Path.GetExtension(imgPath).ToLower() == ".png")
                format = PdfImageFormat.kImageFormatPng;

            // load image file data into memory stream
            byte[] bytes = File.ReadAllBytes(imgPath);
            var memStm = pdfix.CreateMemStream();
            if (memStm == null)
                throw new Exception(pdfix.GetError());
            memStm.Write(0, bytes);

            // create XObject from the image
            var image_obj = doc.CreateXObjectFromImage(memStm, format);
            if (image_obj == null)
                throw new Exception(pdfix.GetError());

            // find or add annotation on the first page
            var page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());

            PdfAnnot annot = null;// page.GetAnnot(0);
            if (annot == null)
            {
                // create new annotation
                var page_view = page.AcquirePageView(1, PdfRotate.kRotate0);
                if (page_view == null)
                    throw new Exception(pdfix.GetError());

                // rect for the new annotation
                PdfRect annot_rect = new PdfRect()
                {
                    left = 100,
                    right = 300,
                    bottom = 100,
                    top = 200
                };
                annot = page.CreateAnnot(PdfAnnotSubtype.kAnnotStamp, annot_rect);
                page.AddAnnot(0, annot);
            }

            // set annotation appearance
            if (!annot.SetAppearanceFromXObject(image_obj, PdfAnnotAppearanceMode.kAppearanceNormal))
                throw new Exception(pdfix.GetError());

            page.Release();

            // save document
            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}