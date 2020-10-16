////////////////////////////////////////////////////////////////////////////////////////////////////
// ConvertToHtml.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;
using PDFixSDK.PdfToHtml;

namespace PDFix.App.Module
{
    class ConvertToHtml
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String configPath,                          // configuration file
            PdfHtmlParams htmlParams                    // html conversion params
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

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

            // set html conversion params
            //htmlParams.type = PdfHtmlType.kPdfHtmlResponsive;
            //htmlParams.width = 1200;    
            //htmlParams.flags |= PdfToHtml.kHtmlExportJavaScripts;
            //htmlParams.flags |= PdfToHtml.kHtmlExportFonts;
            //htmlParams.flags |= PdfToHtml.kHtmlRetainFontSize;
            //htmlParams.flags |= PdfToHtml.kHtmlRetainTextColor;
            htmlParams.flags |= PdfToHtml.kHtmlNoExternalCSS | PdfToHtml.kHtmlNoExternalJS |
                PdfToHtml.kHtmlNoExternalIMG | PdfToHtml.kHtmlNoExternalFONT;

            PdfHtmlDoc htmlDoc = pdfToHtml.OpenHtmlDoc(doc);
            if (htmlDoc == null)
                throw new Exception(pdfix.GetError());

            if (!htmlDoc.Save(savePath, htmlParams, null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            htmlDoc.Close();
            doc.Close();
            pdfToHtml.Destroy();
            pdfix.Destroy();
        }
    }
}