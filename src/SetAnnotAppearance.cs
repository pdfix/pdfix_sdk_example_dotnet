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
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

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

                PdfDevRect dev_rect = new PdfDevRect()
                {
                    left = page_view.GetDeviceWidth() / 3,
                    right = page_view.GetDeviceWidth() / 2,
                    bottom = page_view.GetDeviceHeight() / 3,
                    top = page_view.GetDeviceHeight() / 2
                };
                PdfRect annot_rect = page_view.RectToPage(dev_rect);
                annot = page.AddNewAnnot(0, annot_rect, PdfAnnotSubtype.kAnnotStamp);
            }

            // set annotation appearance
            if (!annot.SetAppearanceFromXObject(image_obj, PdfAnnotAppearanceMode.kAppearanceNormal))
                throw new Exception(pdfix.GetError());

            page.Release();

            // save document
            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}