using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class ExportImages
    {
        private static int _imageIndex = 0;

        private static void ProcessPageObject(PdfPage page, PdsPageObject obj, string savePath)
        {
            if (obj == null)
                PdfixEngine.ThrowException();

            switch (obj.GetObjectType())
            {
                case PdfPageObjectType.kPdsPageImage:
                    ExtractImage(page, (PdsImage)obj, savePath);
                    break;
                case PdfPageObjectType.kPdsPageForm:
                    {
                        var form = (PdsForm)obj;
                        var content = form.GetContent();
                        for (int i = 0; i < content.GetNumObjects(); i++)
                            ProcessPageObject(page, content.GetObject(i), savePath);
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

            string imgPath = savePath + "/image_" + (++_imageIndex).ToString() + ".jpg";
            Console.WriteLine("Image Found: " + imgPath);

            var img = PdfixEngine.Instance.CreateImage(rect.right - rect.left, rect.bottom - rect.top, PsImageDIBFormat.kImageDIBFormatArgb);

            PdfPageRenderParams renderParams = new PdfPageRenderParams
            {
                clip_box = bbox,
                matrix = matrix,
                image = img
            };

            if (!page.DrawContent(renderParams))
                PdfixEngine.ThrowException();

            PdfImageParams imgParams = new PdfImageParams
            {
                format = PdfImageFormat.kImageFormatJpg,
                quality = 80
            };
            if (!img.Save(imgPath, imgParams))
                PdfixEngine.ThrowException();

            img.Destroy();
        }

        public static void Run(
            String openPath,                    // source PDF document
            String savePath
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            for (int i = 0;  i < doc.GetNumPages(); i++)
            {
                var page = doc.AcquirePage(i);
                if (page == null)
                    throw new Exception(pdfix.GetError());
                var content = page.GetContent();
                for (int j = 0; j < content.GetNumObjects(); j++)
                    ProcessPageObject(page, content.GetObject(j), savePath);
                page.Release();
            }

            doc.Close();
        }
    }
}