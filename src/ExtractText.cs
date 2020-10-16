////////////////////////////////////////////////////////////////////////////////////////////////////
// ExtractText.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;
using System.IO;

namespace PDFix.App.Module
{
    class ExtractText
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // ParseText
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private static void ParseText(PdeText text)
        {
            string text_buffer = text.GetText();
            Console.WriteLine(text_buffer);
        }
        ///////////////////////////////////////////////////////////////////////
        // ParseElement
        ///////////////////////////////////////////////////////////////////////
        private static void ParseElement(PdeElement element)
        {
            // parse element based on type;
            PdfElementType elemType = element.GetType_();
            switch (elemType)
            {
                case PdfElementType.kPdeText:
                    ParseText((PdeText)element);
                    return;                    
            }

            int numChilds = element.GetNumChildren();
            for (int i = 0; i < numChilds; i++)
            {
                ParseElement(element.GetChild(i));
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // ParsePage
        ///////////////////////////////////////////////////////////////////////
        private static void ParsePage(Pdfix pdfix, PdfPage page)
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
            ParseElement(container);

            pageMap.Release();
        }

        public static void Run(
            String openPath                             // source PDF document
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // iterate through pages and parse each page individually
            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                PdfPage page = doc.AcquirePage(i);
                if (page == null)
                    throw new Exception(pdfix.GetError());
                ParsePage(pdfix, page);
                page.Release();
            }

            doc.Close();
            pdfix.Destroy();
        }
    }
}