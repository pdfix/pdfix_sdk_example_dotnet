////////////////////////////////////////////////////////////////////////////////////////////////////
// ConvertToHtml.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

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

            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            var html_conv = doc.CreateHtmlConversion();
            if (html_conv == null)
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
            //htmlParams.flags |= Pdfix.kHtmlExportJavaScripts;
            //htmlParams.flags |= Pdfix.kHtmlExportFonts;
            //htmlParams.flags |= Pdfix.kHtmlRetainFontSize;
            //htmlParams.flags |= Pdfix.kHtmlRetainTextColor;
            htmlParams.flags |= Pdfix.kHtmlNoExternalCSS | Pdfix.kHtmlNoExternalJS |
                Pdfix.kHtmlNoExternalIMG | Pdfix.kHtmlNoExternalFONT;
            htmlParams.image_params.format = PdfImageFormat.kImageFormatJpg;

            if (!html_conv.SetParams(htmlParams))
                throw new Exception(pdfix.GetError());

            if (!html_conv.Save(savePath, null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            html_conv.Destroy();
            doc.Close(); 
        }
    }
}