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
                  new PdfHtmlParams()
                  {
                      type = PdfHtmlType.kPdfHtmlResponsive
                  });

                Console.WriteLine("ExtractText Sample");
                ExtractText.Run(email, licenseKey, openPath,
                  outputDir + "ExtractText.txt",
                  configPath);

                Console.WriteLine("OcrWithTesseract Sample");
                OcrWithTesseract.Run(email, licenseKey, openPath,
                    outputDir + "OcrWithTesseract.pdf",
                    resourcesDir,
                    "eng",
                    new OcrTesseractParams()
                    {
                        rotate = 0,
                        zoom = 2,
                        page_seg = OcrTesseractPageSegType.kOcrSegAutoOSD,
                        engine = OcrTesseractEngineType.kOcrTesseractDefault
                    });

                Console.WriteLine("SUCCESS");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
