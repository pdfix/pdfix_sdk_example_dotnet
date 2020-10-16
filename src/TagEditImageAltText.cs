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
        internal static Pdfix pdfix;

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetFirstFigure
        // get reference to the first figure on the page
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static PdsStructElement GetFirstFigure(PdsStructElement struct_elem)
        {
            // search kid struct elements
            for (int i = 0; i < struct_elem.GetNumKids(); i++)
            {
                if (struct_elem.GetKidType(i) == PdfStructElementType.kPdsStructKidElement)
                {
                    PdsObject kid_obj = struct_elem.GetKidObject(i);
                    PdsStructElement kid_elem = struct_elem.GetStructTree().AcquireStructElement(kid_obj);
                    if (kid_elem == null)
                        throw new Exception(pdfix.GetErrorType().ToString());

                    string type = kid_elem.GetType_(true);
                    if (type == "Figure")
                        return kid_elem;

                    var table = GetFirstFigure(kid_elem);
                    if (table != null)
                    {
                        kid_elem.Release();
                        return table;
                    }

                    kid_elem.Release();
                }
            }
            return null;
        }

        private static PdsStructElement GetFirstFigure(PdsStructTree struct_tree)
        {
            for (int i = 0; i < struct_tree.GetNumKids(); i++)
            {
                PdsObject kid_obj = struct_tree.GetKidObject(i);
                PdsStructElement kid_elem = struct_tree.AcquireStructElement(kid_obj);
                var paragraph = GetFirstFigure(kid_elem);
                if (paragraph != null)
                {
                    kid_elem.Release();
                    return paragraph;
                }
                kid_elem.Release();
            }
            return null;
        }

        public static void Run(
            String openPath,                            // source PDF document
            String savePath                             // dest PDF document
            )
        {
            pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

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
            pdfix.Destroy();
        }
    }
}