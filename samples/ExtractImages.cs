////////////////////////////////////////////////////////////////////////////////////////////////////
// ExtractImages.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////
/*!
\page CS_Samples C# Samples
- \subpage ExtractImages_cs
*/
/*!
\page ExtractImages_cs Export Images from PDF
Example how to extract all images from PDF
\snippet /ExtractImages.cs ExtractImages_cs
*/

//\cond INTERNAL
//! [ExtractImages_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class ExtractImages
    {
        private static int _imageIndex = 0;
        private static Pdfix _pdfix;

        private static void ProcessPageObject(PdfPage page, PdsPageObject obj, string savePath)
        {
            if (obj == null)
                throw new Exception(_pdfix.GetError());

            switch (obj.GetObjectType())
            {
                case PdfPageObjectType.kPdsPageImage:
                    ExtractImage(page, (PdsImage)obj, savePath);
                    break;
                case PdfPageObjectType.kPdsPageForm:
                    {
                        var form = (PdsForm)obj;
                        for (int i = 0; i < form.GetNumPageObjects(); i++)
                            ProcessPageObject(page, form.GetPageObject(i), savePath);
                    }
                    break;
            }
        }

        private static void ExtractImage(PdfPage page, PdsImage image, string savePath)
        {
            // widget specific properties
            var bbox = image.GetBBox();
            var page_view = page.AcquirePageView(1, PdfRotate.kRotate0);
            var rect = page_view.RectToDevice(bbox);
            PdfMatrix matrix = page_view.GetDeviceMatrix();
            page_view.Release();

            string imgPath = savePath + "image_" + (++_imageIndex).ToString() + ".jpg";
            Console.WriteLine("Image Found: " + imgPath);

            var img = _pdfix.CreateImage(rect.right - rect.left, rect.bottom - rect.top, PsImageDIBFormat.kImageDIBFormatArgb);

            PdfPageRenderParams renderParams = new PdfPageRenderParams
            {
                clip_box = bbox,
                matrix = matrix,
                image = img
            };

            if (!page.DrawContent(renderParams, null, IntPtr.Zero))
                throw new Exception(_pdfix.GetError());

            PdfImageParams imgParams = new PdfImageParams
            {
                format = PdfImageFormat.kImageFormatJpg,
                quality = 80
            };
            if (!img.Save(imgPath, imgParams))
                throw new Exception(_pdfix.GetError());

            img.Destroy();
        }

        public static void Run(
            String email,                       // authorization email   
            String licenseKey,                  // authorization license key
            String openPath,                    // source PDF document
            String savePath
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");
            _pdfix = pdfix;

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception("Authorization fail. " + pdfix.GetError());

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            for (int i = 0;  i < doc.GetNumPages(); i++)
            {
                var page = doc.AcquirePage(i);
                if (page == null)
                    throw new Exception(pdfix.GetError());
                for (int j = 0; j < page.GetNumPageObjects(); j++)
                    ProcessPageObject(page, page.GetPageObject(i), savePath);
                page.Release();
            }

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [ExtractImages_cs]
//\endcond