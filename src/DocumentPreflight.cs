////////////////////////////////////////////////////////////////////////////////////////////////////
// DocumentPreflight.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class DocumentPreflight
    {
        public static void Run(
            String openPath,                    // source PDF document
            String configPath
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            var doc_preflight = doc.GetTemplate();
            if (doc_preflight == null)
                throw new Exception(pdfix.GetError());

            // load user-defined confguration
            PsFileStream stm = pdfix.CreateFileStream(configPath, PsFileMode.kPsReadOnly);
            if (stm != null)
            {
                var doc_prelight = doc.GetTemplate();
                if (doc_prelight == null)
                    throw new Exception(pdfix.GetError());
                doc_prelight.LoadFromStream(stm, PsDataFormat.kDataFormatJson);
                stm.Destroy();
            }

            // add reference pages to preflight
            for (var i = 0; i < doc.GetNumPages(); i++)
            {
                if (!doc_preflight.AddPage(i, null, IntPtr.Zero))
                    throw new Exception(pdfix.GetError());
            }

            // run document preflight
            if (!doc_preflight.Update(null, IntPtr.Zero))
                throw new Exception(pdfix.GetError());

            // save preflight to stream if needed
            var preflight_stm = pdfix.CreateMemStream();
            doc_preflight.SaveToStream(preflight_stm, PsDataFormat.kDataFormatJson);
            byte[] bytes = new byte[preflight_stm.GetSize()];
            preflight_stm.Read(0, bytes);
            System.Console.Write(System.Text.Encoding.UTF8.GetString(bytes));

            // output some document preflight values from the config
            for (var i = 0; i < doc.GetNumPages(); i++)
            {
                Console.WriteLine("Preflight results for page " + i.ToString());
                var page_preflight = doc_preflight.GetPageTemplate(i);
                if (page_preflight == null)
                    throw new Exception(pdfix.GetError());

                Console.WriteLine("logical rotate: " + page_preflight.GetLogicalRotate());
                Console.WriteLine("columns: " + page_preflight.GetNumColumns());
                var header_box = page_preflight.GetHeaderBBox();
                Console.WriteLine("header bbox: " + header_box.left + ", " + header_box.bottom +
                             ", " + header_box.right + ", " + header_box.top);
                var footer_box = page_preflight.GetFooterBBox();
                Console.WriteLine("footer bbox: " + footer_box.left + ", " + footer_box.bottom +
                             ", " + footer_box.right + ", " + footer_box.top);
                Console.WriteLine("");
            }

            doc.Close();
            pdfix.Destroy();
        }
    }
}