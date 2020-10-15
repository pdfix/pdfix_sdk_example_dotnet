////////////////////////////////////////////////////////////////////////////////////////////////////
// RenderPage.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class RenderPage
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath                             // output image document
            )
        {             
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // choose page to render
            var page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());

            // prepare page view with zoom and rotation
            var pageView = page.AcquirePageView(1.0, PdfRotate.kRotate0);
            if (pageView == null)
                throw new Exception(pdfix.GetError());

            // prepare an image to write data into
            var image = pdfix.CreateImage(pageView.GetDeviceWidth(), pageView.GetDeviceHeight(),
                PsImageDIBFormat.kImageDIBFormatArgb);
            if (image == null)
                throw new Exception(pdfix.GetError());

            // draw content into the image
            if (!page.DrawContent(new PdfPageRenderParams()
                {
                    clip_box = page.GetCropBox(),
                    matrix = pageView.GetDeviceMatrix(),
                    image = image
                }, 
                null, IntPtr.Zero))
                    throw new Exception(pdfix.GetError());

            // prepare file stream to write into
            var stm = pdfix.CreateFileStream(savePath, PsFileMode.kPsTruncate);
            if (stm == null)
                throw new Exception(pdfix.GetError());

            // save image to file
            if (!image.SaveToStream(stm, new PdfImageParams() { 
                format = PdfImageFormat.kImageFormatJpg,
                quality = 80
            }))
                throw new Exception(pdfix.GetError());

            // cleanup
            stm.Destroy();
            page.Release();
            doc.Close();
            pdfix.Destroy();
        }
    }
}