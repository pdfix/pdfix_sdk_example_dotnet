////////////////////////////////////////////////////////////////////////////////////////////////////
// ExtractTables.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;
using System.IO;

namespace PDFix.App.Module
{
    class ExtractTables
    {
        private static int tableIndex = 0;
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // ParseText
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private static void ParseText(PdeText text, StreamWriter file, bool eof)
        {
            string text_buffer = text.GetText();
            file.Write(text_buffer);
            if (eof)
                file.Write("\n");
        }

        ///////////////////////////////////////////////////////////////////////
        // ParseTable
        ///////////////////////////////////////////////////////////////////////
        private static void ParseTable(PdeTable table, String outDir)
        {
            StreamWriter file = new System.IO.StreamWriter(outDir + "\\ExtractTables" + tableIndex++ + ".csv");

            int rowCount = table.GetNumRows();
            int colCount = table.GetNumCols();

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    PdeCell cell = (PdeCell)table.GetCell(row, col);
                    if (cell == null)
                        continue;

                    int rowSpan = cell.GetRowSpan();
                    int colSpan = cell.GetColSpan();

                    int count = cell.GetNumChildren();
                    if ((rowSpan != 0) && (colSpan != 0) && (count > 0))
                    {
                        file.Write("\"");
                        for (int i = 0; i < count; i++)
                        {
                            PdeElement child = cell.GetChild(i);
                            if (child != null && (child.GetType_() == PdfElementType.kPdeText))
                            {
                                ParseText((PdeText)child, file, false);
                            }
                            if (i < count - 1)
                            {
                                file.Write(" ");
                            }
                        }
                        file.Write("\"");
                    }

                    if (col < colCount)
                        file.Write(",");
                }
                if (row < rowCount)
                    file.Write("\n");
            }

            file.Close();
        }

        ///////////////////////////////////////////////////////////////////////
        // ParseElement
        ///////////////////////////////////////////////////////////////////////
        private static void ParseElement(PdeElement element, String outDir)
        {
            // parse element based on type;
            PdfElementType elemType = element.GetType_();
            switch (elemType)
            {
                case PdfElementType.kPdeTable:
                    ParseTable((PdeTable)element, outDir);
                    return;                    
            }

            int numChilds = element.GetNumChildren();
            for (int i = 0; i < numChilds; i++)
            {
                ParseElement(element.GetChild(i), outDir);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // ParsePage
        ///////////////////////////////////////////////////////////////////////
        private static void ParsePage(Pdfix pdfix, PdfPage page, String outDir)
        {
            // get pageMap for the current page
            PdePageMap pageMap = page.AcquirePageMap();
            if (pageMap == null)
                throw new Exception(pdfix.GetError());
            if (!pageMap.CreateElements(null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            // get page container
            PdeElement container = pageMap.GetElement();
            if (container == null)
                throw new Exception(pdfix.GetError());

            // parse children recursivelly
            ParseElement(container, outDir);

            pageMap.Release();
        }

        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output TXT document
            String configPath                          // configuration file
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
                ParsePage(pdfix, page, savePath);

                page.Release();
            }

            Console.WriteLine(tableIndex + " tables detected");

            doc.Close();
            pdfix.Destroy();
        }
    }
}