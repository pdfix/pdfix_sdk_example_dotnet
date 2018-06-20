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

                Initialization.Run(email, licenseKey);

                AddTags.Run(email, licenseKey, openPath,
                  outputDir + "AddTags.pdf",
                  configPath);

                AddWatermark.Run(email, licenseKey, openPath,
                  outputDir + "AddWatermark.pdf",
                  resourcesDir + "watermark.png",
                  new PdfWatermarkParams());

                ConvertToHtml.Run(email, licenseKey, openPath,
                  outputDir + "index.html",
                  configPath,
                  new PdfHtmlParams());

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
