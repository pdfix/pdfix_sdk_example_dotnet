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

                // Initialize PDFix SDK
                Console.WriteLine("Initialization Sample");
                Initialization.Run(email, licenseKey);

                // Add Comments to the PDF
                Console.WriteLine("Add Comment Sample");
                AddComment.Run(email, licenseKey, openPath, outputDir + "AddComment.pdf");

                // Apply Stamp or Watermark PDF
                Console.WriteLine("Add Watermark Sample");
                AddWatermark.Run(email, licenseKey, openPath, outputDir + "AddWatermark.pdf", 
                    resourcesDir + "watermark.png", new PdfWatermarkParams());

                // Flatten Annotations
                Console.WriteLine("Flatten Annots Sample");
                FlattenAnnots.Run(email, licenseKey, openPath, outputDir + "FlattenAnnots.pdf",
                  new PdfFlattenAnnotsParams());

                // Export Form Fields from the PDF
                Console.WriteLine("Export Form Fields Sample");
                ExportFormFields.Run(email, licenseKey, openPath);

                // Sign PDF with the Digital Signature
                Console.WriteLine("DigitalSignature Sample");
                DigitalSignature.Run(email, licenseKey, openPath, outputDir + "DigitalSignature.pdf",
                  resourcesDir + "test.pfx", "TEST_PASSWORD");

                // Covnert PDF to HTML
                Console.WriteLine("Convert To Html Sample");
                ConvertToHtml.Run(email, licenseKey, openPath, outputDir + "index.html",
                  configPath, new PdfHtmlParams());

                // Convert PDF Page to HTML
                Console.WriteLine("Convert To Html by Pages Sample");
                ConvertToHtmlByPages.Run(email, licenseKey, openPath, outputDir + "",
                  configPath, new PdfHtmlParams());

                // Extract images from the PDF
                Console.WriteLine("Extract Images Sample");
                ExtractImages.Run(email, licenseKey, openPath, outputDir);

                // Extract tables from the PDF
                Console.WriteLine("ExtractTables Sample");
                ExtractTables.Run(email, licenseKey, openPath, outputDir, configPath);

                // Extract OCG Layers from PDF
                Console.WriteLine("Extract OCG Layers from PDF Sample");
                ReadOCGLayers.Run(email, licenseKey, openPath);

                // Extract Text from OCG Layer
                Console.WriteLine("Extract Text From OCG Layer Sample");
                ExtractTextFromOCGLayer.Run(email, licenseKey, openPath);

                // Autotag PDF
                Console.WriteLine("AddTags Sample");
                AddTags.Run(email, licenseKey, openPath, outputDir + "AddTags.pdf", configPath);

                // Convert PDF to PDF/UA
                Console.WriteLine("MakeAccessible Sample");
                MakeAccessible.Run(email, licenseKey, openPath, outputDir + "MakeAccessible.pdf",
                  "en-us", "", configPath);

                // Edit Struct Tree in the PDF
                Console.WriteLine("TagEditStructureTree Sample");
                TagEditStructureTree.Run(email, licenseKey, openPath, 
                    outputDir + "TagEditStructureTree.pdf");

                // Read Struct Tree
                Console.WriteLine("TagsReadStructTree sample");
                TagsReadStructTree.Run(email, licenseKey, openPath, outputDir + "TagsReadStructTree.pdf");

                // Modify Reading Order in the Struct Tree
                Console.WriteLine("TagsReadingOrder sample");
                TagsReadingOrder.Run(email, licenseKey, openPath, outputDir + "TagsReadingOrder.pdf");

                // Change Tags in the Struct Tree - Convert <Table> to <Figure>
                Console.WriteLine("TagTableAsFigure sample");
                TagTableAsFigure.Run(email, licenseKey, openPath, outputDir + "TagTableAsFigure.pdf");

                // Change Tags in the Struct Tree - Convert <P> to <H1>
                Console.WriteLine("TagHeadings Sample");
                TagHeadings.Run(email, licenseKey, openPath, outputDir + "TagHeadings.pdf");

                // Change Tagged Content to Artifact
                Console.WriteLine("TagAsArtifact Sample");
                TagAsArtifact.Run(email, licenseKey, openPath, outputDir + "TagAsArtifact.pdf");

                // Tag Annotation
                Console.WriteLine("Tag Annotation Sample");
                TagAnnotation.Run(email, licenseKey, openPath, outputDir + "TagAnnotation.pdf");

                // Edit Figure Alt Text
                Console.WriteLine("Edit Figure Alt Text Sample");
                TagEditImageAltText.Run(email, licenseKey, openPath, outputDir + "TagEditImageAltText.pdf");

                // Recognize Text in PDF using OCR Tesseract
                Console.WriteLine("OcrWithTesseract Sample");
                OcrWithTesseract.Run(email, licenseKey, openPath, outputDir + "OcrWithTesseract.pdf",
                  resourcesDir + "tessdata\\", "eng");

                // Parse PDF objects (low lever document access)
                Console.WriteLine("ParsePdsObjects Sample");
                ParsePdsObjects.Run(email, licenseKey, openPath);

                // Using PDFix in multithreaded environment
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
