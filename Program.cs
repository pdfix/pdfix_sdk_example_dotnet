using PDFix.App.Module;
using PDFixSDK.OcrTesseract;
using PDFixSDK.Pdfix;
using PDFixSDK.PdfToHtml;
using System;

namespace PdfixSDKSample
{
    class Program
    {
        static void Main(string[] args)
        {
            String email = "YOUR_EMAIL";                                        // authorization email
            String licenseKey = "LICENSE_KEY";                                  // license key

            String resourcesDir = Utils.GetAbsolutePath("..\\..\\resources\\"); // resources folder path
            String outputDir = Utils.GetAbsolutePath("..\\..\\output\\");       // output folder path

            String openPath = resourcesDir + "test.pdf";                      // source PDF document
            String configPath = resourcesDir + "config.json";                 // configuration file

            try
            {
                System.IO.Directory.CreateDirectory(outputDir);

                Console.WriteLine("Initialization Sample");
                Initialization.Run(email, licenseKey);

                Console.WriteLine("AddComment Sample");
                AddComment.Run(email, licenseKey, openPath,
                  outputDir + "AddComment.pdf");

                Console.WriteLine("AddTags Sample");
                AddTags.Run(email, licenseKey, openPath,
                  outputDir + "AddTags.pdf",
                  configPath);

                Console.WriteLine("AddWatermark Sample");
                AddWatermark.Run(email, licenseKey, openPath,
                  outputDir + "AddWatermark.pdf",
                  resourcesDir + "watermark.png",
                  new PdfWatermarkParams());

                Console.WriteLine("ConvertToHtml Sample");
                ConvertToHtml.Run(email, licenseKey, openPath,
                  outputDir + "index.html",
                  configPath,
                  new PdfHtmlParams());

                ConvertToHtmlByPages.Run(email, licenseKey, openPath,
                  outputDir + "",
                  configPath,
                  new PdfHtmlParams());

                Console.WriteLine("DigitalSignature Sample");
                DigitalSignature.Run(email, licenseKey, openPath,
                  outputDir + "DigitalSignature.pdf",
                  resourcesDir + "test.pfx",
                  "TEST_PASSWORD");


                Console.WriteLine("ExtractTables Sample");
                ExtractTables.Run(email, licenseKey, openPath,
                  outputDir,
                  configPath);

                Console.WriteLine("ExtractText Sample");
                ExtractText.Run(email, licenseKey, openPath,
                  outputDir + "ExtractText.txt",
                  configPath);

                Console.WriteLine("FlattenAnnots Sample");
                FlattenAnnots.Run(email, licenseKey, openPath,
                  outputDir + "FlattenAnnots.pdf",
                  new PdfFlattenAnnotsParams());

                Console.WriteLine("MakeAccessible Sample");
                MakeAccessible.Run(email, licenseKey, openPath,
                  outputDir + "MakeAccessible.pdf",
                  "en-us",
                  "",
                  configPath);

                Console.WriteLine("TagEditStructureTree Sample");
                TagEditStructureTree.Run(email, licenseKey, openPath,
                  outputDir + "TagEditStructureTree.pdf");

                Console.WriteLine("TagsReadStructTree sample");
                TagsReadStructTree.Run(email, licenseKey, openPath, outputDir + "TagsReadStructTree.pdf");

                Console.WriteLine("TagsReadingOrder sample");
                TagsReadingOrder.Run(email, licenseKey, openPath, outputDir + "TagsReadingOrder.pdf");

                Console.WriteLine("TagTableAsFigure sample");
                TagTableAsFigure.Run(email, licenseKey, openPath, outputDir + "TagTableAsFigure.pdf");

                Console.WriteLine("TagHeadings Sample");
                TagHeadings.Run(email, licenseKey, openPath, outputDir + "TagHeadings.pdf");

                Console.WriteLine("TagAsArtifact Sample");
                TagAsArtifact.Run(email, licenseKey, openPath, outputDir + "TagAsArtifact.pdf");

                Console.WriteLine("OcrWithTesseract Sample");
                OcrWithTesseract.Run(email, licenseKey, openPath,
                  outputDir + "OcrWithTesseract.pdf",
                  resourcesDir + "tessdata\\",
                  "eng");

                Console.WriteLine("ParsePdsObjects Sample");
                ParsePdsObjects.Run(email, licenseKey, openPath);

                Console.WriteLine("ThreadSafePdfix Sample");
                ThreadSafePdfix.Run(email, licenseKey, openPath);

                Console.WriteLine("SUCCESS");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
