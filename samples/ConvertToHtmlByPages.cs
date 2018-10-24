////////////////////////////////////////////////////////////////////////////////////////////////////
// ConvertToHtmlByPages.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////
/*!
\page CS_Samples C# Samples
- \subpage ConvertToHtmlByPages_cs
*/
/*!
\page ConvertToHtmlByPages_cs Pdf To Html Sample
Example how to convert PDF document to HTML page by page.
\snippet /ConvertToHtmlByPages.cs ConvertToHtmlByPages_cs
*/

//\cond INTERNAL
//! [ConvertToHtmlByPages_cs]
using System;
using PDFixSDK.Pdfix;
using PDFixSDK.PdfToHtml;

namespace PDFix.App.Module
{
    class ConvertToHtmlByPages
    {
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath,                            // output folder for HTML content
            String configPath,                          // configuration file
            PdfHtmlParams htmlParams                    // html conversion params
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetError());

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
                PdfDocTemplate docTmpl = doc.GetDocTemplate();
                if (docTmpl == null)
                    throw new Exception(pdfix.GetError());
                if (!docTmpl.LoadFromStream(stm, PsDataFormat.kDataFormatJson))
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

            // save common js and css for all pages
            PsStream docCss = pdfix.CreateFileStream(savePath + "/document.css",
                PsFileMode.kPsTruncate);
            if (!pdfToHtml.SaveCSS(docCss))
                throw new Exception(pdfix.GetError());
            docCss.Destroy();

            PsStream docJs = pdfix.CreateFileStream(savePath + "/document.js",
                PsFileMode.kPsTruncate);
            if (!pdfToHtml.SaveJavaScript(docJs))
                throw new Exception(pdfix.GetError());
            docJs.Destroy();

            PsStream docStm = pdfix.CreateFileStream(savePath + "/document.html",
                PsFileMode.kPsTruncate);
            if (!htmlDoc.SaveDocHtml(docStm, htmlParams, null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());
            docStm.Destroy();

            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                string pageFile = savePath + "/document_page" + i + ".html";
                PsStream pageStm = pdfix.CreateFileStream(pageFile, PsFileMode.kPsTruncate);
                if (!htmlDoc.SavePageHtml(pageStm, htmlParams, i, null, IntPtr.Zero))
                    throw new Exception(pdfix.GetError());
                pageStm.Destroy();
            }

            htmlDoc.Close();
            doc.Close();
            pdfToHtml.Destroy();
            pdfix.Destroy();
        }
    }
}
//! [ConvertToHtmlByPages_cs]
//\endcond
