using PDFixSDK.Pdfix;
using PDFixSDK.PdfToHtml;
using System;

namespace PDFix.App.Module
{
    class PdfixSamples
    {
        public static void Run(String rootPath)
        {
            String inputPath = Utils.GetAbsolutePath(rootPath + "res/");
            String outputPath = Utils.GetAbsolutePath("output");
            String configPath = "";

            String email = PdfixAppConfig.email;
            String licenseKey = PdfixAppConfig.key;

            System.IO.Directory.CreateDirectory(outputPath);

            //////////////////////////////////////////////////////////////////////
            // Samples Free version - no authorization
            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("Initialization Sample");
            Initialization.Run(email, licenseKey);

            Console.WriteLine("ParsePdsObjects Sample");
            ParsePdsObjects.Run(inputPath + "test.pdf");

            Console.WriteLine("Read OCG Sample");
            ReadOCGLayers.Run(inputPath + "test.pdf");

            Console.WriteLine("Extract Text From OCG Layer Sample");
            ExtractTextFromOCGLayer.Run(inputPath + "test.pdf");

            Console.WriteLine("GetFormFieldValueEx Sample");
            GetFormFieldValueEx.Run(inputPath + "test.pdf");

            Console.WriteLine("Render Page sample");
            RenderPage.Run(inputPath + "test.pdf", outputPath + "/RenderPage.jpg");

            ////////////////////////////////////////////////////////////////////////
            //// Samples Basic version
            ////////////////////////////////////////////////////////////////////////

            Console.WriteLine("AddComment Sample");
            AddComment.Run(email, licenseKey, inputPath + "test.pdf", outputPath + "/AddComment.pdf");

            Console.WriteLine("Set Annot Appearance Sample");
            SetAnnotAppearance.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/SetAnnotAppearance.pdf",
              inputPath + "/watermark.png");

            Console.WriteLine("AddTags Sample");
            AddTags.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/AddTags.pdf", configPath);

            //Console.WriteLine("Document Preflight Sample");
            //DocumentPreflight.Run(email, licenseKey, inputPath + "test.pdf");

            Console.WriteLine("AddWatermark Sample");
            AddWatermark.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/AddWatermark.pdf",
              inputPath + "/watermark.png",
              new PdfWatermarkParams());

            Console.WriteLine("ConvertToHtml Sample");
            ConvertToHtml.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/index.html",
              configPath,
              new PdfHtmlParams()
              {
                flags = PdfToHtml.kHtmlNoExternalCSS | PdfToHtml.kHtmlNoExternalJS | PdfToHtml.kHtmlNoExternalIMG | PdfToHtml.kHtmlNoExternalFONT
              });

            ConvertToHtmlByPages.Run(email, licenseKey, inputPath + "test.pdf",
              configPath,
              new PdfHtmlParams()
              {
                flags = PdfToHtml.kHtmlNoExternalCSS | PdfToHtml.kHtmlNoExternalJS | PdfToHtml.kHtmlNoExternalIMG | PdfToHtml.kHtmlNoExternalFONT
              });

            Console.WriteLine("DigitalSignature Sample");
            DigitalSignature.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/DigitalSignature.pdf",
              inputPath + "/test.pfx", "TEST_PASSWORD");

            Console.WriteLine("ExtractTables Sample");
            ExtractTables.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath,
              configPath);

            Console.WriteLine("ExtractText Sample");
            ExtractText.Run(email, licenseKey, inputPath + "test.pdf");

            Console.WriteLine("ExportImages Sample");
            ExportImages.Run(email, licenseKey, inputPath + "test.pdf", 
              outputPath);

            Console.WriteLine("FlattenAnnots Sample");
            FlattenAnnots.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/FlattenAnnots.pdf",
              new PdfFlattenAnnotsParams());

            Console.WriteLine("MakeAccessible Sample");
            MakeAccessible.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/MakeAccessible.pdf",
              true,
              "en-us",
              "",
              configPath);

            Console.WriteLine("TagsReadStructTree sample");
            TagsReadStructTree.Run(email, licenseKey, inputPath + "test.pdf");

            Console.WriteLine("TagEditImageAltText");
            TagEditImageAltText.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/TagEditImageAltText.pdf");

            Console.WriteLine("TagEditStructureTree Sample");
            TagEditStructureTree.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/TagEditStructureTree.pdf");

            Console.WriteLine("TagsReadingOrder sample");
            TagsReadingOrder.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/TagsReadingOrder.pdf");

            Console.WriteLine("TagTableAsFigure sample");
            TagTableAsFigure.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/TagTableAsFigure.pdf");

            Console.WriteLine("TagHeadings Sample");
            TagHeadings.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/TagHeadings.pdf");

            Console.WriteLine("TagAsArtifact Sample");
            TagAsArtifact.Run(email, licenseKey, inputPath + "test.pdf",
              outputPath + "/TagAsArtifact.pdf");

            //Console.WriteLine("OcrWithTesseract Sample");
            //OcrWithTesseract.Run(email, licenseKey, inputPath + "test.pdf",
            //  outputPath + "OcrWithTesseract.pdf",
            //  inputPath + "/tesseract/tessdata",
            //  "eng");

            Console.WriteLine("ThreadSafePdfix Sample");
            ThreadSafePdfix.Run(email, licenseKey, inputPath + "test.pdf");
        }
    }
}
