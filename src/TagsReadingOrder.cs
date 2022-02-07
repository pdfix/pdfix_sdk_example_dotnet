////////////////////////////////////////////////////////////////////////////////////////////////////
// TagsReadingOrder.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagsReadingOrder
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetFirstParagraph
        // get reference to the first paragraph on the page
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static bool MoveParagraphToParent(PdsStructElement struct_elem)
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
                    if (type == "P")
                    {
                        if (!struct_elem.MoveChild(i, struct_elem, struct_elem.GetNumChildren() - 1))
                            throw new Exception();
                        return true;
                    }
                    var paragraph = MoveParagraphToParent(kid_elem);
                    return paragraph;
                }
            }
            return false;
        }

        private static bool MoveParagraphToParent(PdsStructTree struct_tree)
        {
            for (int i = 0; i < struct_tree.GetNumChildren();)
            {
                PdsObject kid_obj = struct_tree.GetChildObject(i);
                PdsStructElement kid_elem = struct_tree.GetStructElementFromObject(kid_obj);
                var paragraph = MoveParagraphToParent(kid_elem);
                return paragraph;
            }
            return false;
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

            // cleanup any previous structure tree
            if (!doc.RemoveTags(null, null))
                throw new Exception(pdfix.GetErrorType().ToString());

            // autotag document first
            if (!doc.AddTags(null, null))
                throw new Exception(pdfix.GetErrorType().ToString());

            // get the struct tree
            PdsStructTree struct_tree = doc.GetStructTree();
            if (struct_tree == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            // move paragraph to the back of it's parent
            if (!MoveParagraphToParent(struct_tree))
                throw new Exception("No table found.");

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}