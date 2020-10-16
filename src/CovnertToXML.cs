////////////////////////////////////////////////////////////////////////////////////////////////////
// ConvertToXML.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;
using System.IO;

namespace PDFix.App.Module
{
    class ConvertToXML
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // ParseText
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private static void ParseText(PdeText text, StreamWriter file)
        {
            string text_buffer = text.GetText();
            file.WriteLine(text_buffer);
        }
        ///////////////////////////////////////////////////////////////////////
        // ParseElement
        ///////////////////////////////////////////////////////////////////////
        private static void ParseElement(PdeElement element, StreamWriter file)
        {
            // parse element based on type;
            PdfElementType elemType = element.GetType_();
            switch (elemType)
            {
                case PdfElementType.kPdeText:
                    ParseText((PdeText)element, file);
                    return;                    
            }

            int numChilds = element.GetNumChildren();
            for (int i = 0; i < numChilds; i++)
            {
                ParseElement(element.GetChild(i), file);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // ParsePage
        ///////////////////////////////////////////////////////////////////////
        private static void ParsePage(Pdfix pdfix, PdfPage page, StreamWriter file)
        {
            // get pageMap for the current page
            PdePageMap pageMap = page.AcquirePageMap(null, IntPtr.Zero);
            if (pageMap == null)
                throw new Exception(pdfix.GetError());

            // get page container
            PdeElement container = pageMap.GetElement();
            if (container == null)
                throw new Exception(pdfix.GetError());

            // parse children recursivelly
            ParseElement(container, file);

            pageMap.Release();
        }

        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output XML document
            String configPath                           // configuration file
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            StreamWriter file = new System.IO.StreamWriter(savePath);

            //pdfix.CreateCustomStream()

            // XML headers
            file.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n");
            file.Write("<!--Created from PDF via PDFix-->\n");
            file.Write("<Document>\n");

            PsMetadata metadata = doc.GetMetadata();


            // iterate through pages and parse each page individually
            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                PdfPage page = doc.AcquirePage(i);
                if (page == null)
                    throw new Exception(pdfix.GetError());
                ParsePage(pdfix, page, file);
                page.Release();
            }

            file.Close();

            doc.Close();
            pdfix.Destroy();
        }
    }
}