////////////////////////////////////////////////////////////////////////////////////////////////////
// TagEditStructureTree.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagEditStructureTree
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath                             // output PDF document
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            if (!doc.RemoveTags(null, null))
                throw new Exception(pdfix.GetError());

            if (!doc.AddTags(new PdfTagsParams(), null, null))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}