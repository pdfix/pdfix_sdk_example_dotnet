////////////////////////////////////////////////////////////////////////////////////////////////////
// ConvertToHtmlByPages.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

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

            //htmlParams.type = PdfHtmlType.kPdfHtmlResponsive;
            htmlParams.flags |= Pdfix.kHtmlNoExternalCSS | Pdfix.kHtmlNoExternalJS |
                Pdfix.kHtmlNoExternalIMG | Pdfix.kHtmlNoExternalFONT;
            //htmlParams.image_params.format = PdfImageFormat.kImageFormatJpg;
            //htmlParams.image_params.quality = 80;

            if (!html_conv.SetParams(htmlParams))
                throw new Exception(pdfix.GetError());

            var docStm = pdfix.CreateFileStream(Utils.GetAbsolutePath("output") + "/pages.html", PsFileMode.kPsTruncate);
            
            // prepare head
            docStm.Write(0, System.Text.Encoding.Default.GetBytes("<html>\n<head>\n<title>PDFix sample</title>\n</head>\n<body>\n"));
            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("<script>\n"));
            html_conv.SaveJavaScript(docStm);
            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("\n</script>\n<style>\n"));
            html_conv.SaveCSS(docStm);
            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("\n</style>\n"));

            // convert pages
            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                if (!html_conv.AddPage(i, null, IntPtr.Zero))
                    throw new Exception(pdfix.GetError());
            }

            if (!html_conv.SaveToStream(docStm, null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            docStm.Write(docStm.GetSize(), System.Text.Encoding.Default.GetBytes("</body>\n</html>"));

            html_conv.Destroy();
            docStm.Destroy();
            doc.Close();
        }
    }
}