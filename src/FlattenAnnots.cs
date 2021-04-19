////////////////////////////////////////////////////////////////////////////////////////////////////
// FlattenAnnots.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class FlattenAnnots
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath                             // output PDF document
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                var page = doc.AcquirePage(i);
                for (int j = page.GetNumAnnots() - 1; j >= 0; j++)
                {
                    var annot = page.GetAnnot(j);
                    if (annot == null || annot.GetSubtype() == PdfAnnotSubtype.kAnnotLink)
                        continue;
                    if (!page.FlattenAnnot(annot))
                        throw new Exception(pdfix.GetError());
                }
                page.Release();
            }

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}