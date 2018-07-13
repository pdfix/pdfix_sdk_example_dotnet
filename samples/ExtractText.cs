////////////////////////////////////////////////////////////////////////////////////////////////////
// ExtractText.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////
/*!
\page CS_Samples C# Samples
- \subpage ExtractText_cs
*/
/*!
\page ExtractText_cs Extract Text Sample
Example how to extract text from PDF into a text file.
\snippet /ExtractText.cs ExtractText_cs
*/

//\cond INTERNAL
//! [ExtractText_cs]
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

            page.ReleasePageMap();
            pageMap = null;
        }

        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath,                            // output TXT document
            String configPath                          // configuration file
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetError());

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            StreamWriter file = new System.IO.StreamWriter(savePath);

            // iterate through pages and parse each page individually
            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                PdfPage page = doc.AcquirePage(i);
                if (page == null)
                    throw new Exception(pdfix.GetError());
                ParsePage(pdfix, page, file);
                doc.ReleasePage(page);
            }

            file.Close();

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [ExtractText_cs]
//\endcond
