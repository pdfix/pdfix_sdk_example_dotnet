////////////////////////////////////////////////////////////////////////////////////////////////////
// TagEditImageAltText.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagEditImageAltText
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetFirstFigure
        // get reference to the first figure on the page
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static PdsStructElement GetFirstFigure(PdsStructElement struct_elem)
        {
            // search kid struct elements
            for (int i = 0; i < struct_elem.GetNumChildren(); i++)
            {
                if (struct_elem.GetChildType(i) == PdfStructElementType.kPdsStructChildElement)
                {
                    PdsObject kid_obj = struct_elem.GetChildObject(i);
                    PdsStructElement kid_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                    if (kid_elem == null)
                        PdfixEngine.ThrowException();

                    string type = kid_elem.GetType_(true);
                    if (type == "Figure")
                        return kid_elem;

                    var table = GetFirstFigure(kid_elem);
                    if (table != null)
                    {
                        return table;
                    }

                }
            }
            return null;
        }

        private static PdsStructElement GetFirstFigure(PdsStructTree struct_tree)
        {
            for (int i = 0; i < struct_tree.GetNumChildren(); i++)
            {
                PdsObject kid_obj = struct_tree.GetChildObject(i);
                PdsStructElement kid_elem = struct_tree.GetStructElementFromObject(kid_obj);
                var paragraph = GetFirstFigure(kid_elem);
                if (paragraph != null)
                {
                    return paragraph;
                }
            }
            return null;
        }

        public static void Run(
            String openPath,                            // source PDF document
            String savePath                             // dest PDF document
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());


            // get the struct tree
            PdsStructTree struct_tree = doc.GetStructTree();
            if (struct_tree == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            PdsStructElement figure = GetFirstFigure(struct_tree);
            if (figure == null)
                throw new Exception("No figure found.");

            if (!figure.SetAlt("This is a new alternate text"))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}