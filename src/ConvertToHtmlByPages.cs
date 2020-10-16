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

            htmlParams.flags |= PdfToHtml.kHtmlNoExternalCSS | PdfToHtml.kHtmlNoExternalJS |
                PdfToHtml.kHtmlNoExternalIMG | PdfToHtml.kHtmlNoExternalFONT;

            PdfHtmlDoc htmlDoc = pdfToHtml.OpenHtmlDoc(doc);
            if (htmlDoc == null)
                throw new Exception(pdfix.GetError());

            // save common js and css for all pages
            PsStream docCss = pdfix.CreateMemStream();
            if (!pdfToHtml.SaveCSS(docCss))
                throw new Exception(pdfix.GetError());
            docCss.Destroy();

            PsStream docJs = pdfix.CreateMemStream();
            if (!pdfToHtml.SaveJavaScript(docJs))
                throw new Exception(pdfix.GetError());
            docJs.Destroy();

            PsStream docStm = pdfix.CreateMemStream();
            if (!htmlDoc.SaveDocHtml(docStm, htmlParams, null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());
            docStm.Destroy();

            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                PsStream pageStm = pdfix.CreateMemStream();
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