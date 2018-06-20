////////////////////////////////////////////////////////////////////////////////////////////////////
// ConvertToHtml.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////
/*!
\page CS_Samples C# Samples
- \subpage ConvertToHtml_cs
*/
/*!
\page ConvertToHtml_cs Pdf To Html Sample
Example how to convert whole PDF document to HTML.
\snippet /ConvertToHtml.cs ConvertToHtml_cs
*/

//\cond INTERNAL
//! [ConvertToHtml_cs]
using System;
using PDFixSDK.Pdfix;
using PDFixSDK.PdfToHtml;

namespace PDFix.App.Module
{
    class ConvertToHtml
    {
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
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

            /* set html_param
            htmlParams.type = kPdfHtmlResponsive;
            htmlParams.width = 1200;    
            htmlParams.flags |= kHtmlExportJavaScripts;
            htmlParams.flags |= kHtmlExportFonts;
            htmlParams.flags |= kHtmlRetainFontSize;
            htmlParams.flags |= kHtmlRetainTextColor;
            htmlParams.flags |= kHtmlNoExternalCSS | kHtmlNoExternalJS | kHtmlNoExternalIMG | kHtmlNoExternalFONT;
            */

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
//! [ConvertToHtml_cs]
//\endcond
