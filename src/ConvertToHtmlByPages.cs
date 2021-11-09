////////////////////////////////////////////////////////////////////////////////////////////////////
// ConvertToHtmlByPages.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;
using PDFixSDK.PdfToHtml;

namespace PDFix.App.Module
{
    class ConvertToHtmlByPages
    {
        public static void Run(
            String openPath,                            // source PDF document
            String configPath,                          // configuration file
            PdfHtmlParams htmlParams                    // html conversion params
            )
        {

            Pdfix pdfix = PdfixEngine.Instance;

            PdfToHtml pdfToHtml = new PdfToHtml();
            if (pdfToHtml == null)
                throw new Exception("PdfToHtml initialization fail");

            if (!pdfToHtml.Initialize(pdfix))
                throw new Exception(pdfix.GetError());

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // customize conversion 
            PsFileStream stm = pdfix.CreateFileStream(configPath, PsFileMode.kPsReadOnly);
            if (stm != null)
            {
                var doc_prelight = doc.GetTemplate();
                if (doc_prelight == null)
                    throw new Exception(pdfix.GetError());
                if (!doc_prelight.LoadFromStream(stm, PsDataFormat.kDataFormatJson))
                    throw new Exception(pdfix.GetError());
                stm.Destroy();
            }

            //htmlParams.type = PdfHtmlType.kPdfHtmlResponsive;
            htmlParams.flags |= PdfToHtml.kHtmlNoExternalCSS | PdfToHtml.kHtmlNoExternalJS |
                PdfToHtml.kHtmlNoExternalIMG | PdfToHtml.kHtmlNoExternalFONT;
            //htmlParams.image_params.format = PdfImageFormat.kImageFormatJpg;
            //htmlParams.image_params.quality = 80;

            PdfHtmlDoc htmlDoc = pdfToHtml.OpenHtmlDoc(doc);
            if (htmlDoc == null)
                throw new Exception(pdfix.GetError());

            var docStm = pdfix.CreateFileStream(Utils.GetAbsolutePath("output") + "/pages.html", PsFileMode.kPsTruncate);
            
            // prepare head
            docStm.Write(0, System.Text.Encoding.Default.GetBytes("<html>\n<head>\n<title>PDFix sample</title>\n</head>\n<body>\n"));
            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("<script>\n"));
            pdfToHtml.SaveJavaScript(docStm);
            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("\n</script>\n<style>\n"));
            pdfToHtml.SaveCSS(docStm);
            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("\n</style>\n"));

            // convert pages
            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                if (!htmlDoc.SavePageHtml(docStm, htmlParams, i, null, IntPtr.Zero))
                    throw new Exception(pdfix.GetError());
            }

            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("</body>\n</html>"));
          
            docStm.Destroy();
            htmlDoc.Close();
            doc.Close();
            pdfToHtml.Destroy();
        }
    }
}