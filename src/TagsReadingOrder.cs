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
        private static PdsStructElement GetFirstParagraph(PdsStructElement struct_elem)
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
                        return kid_elem;

                    var paragraph = GetFirstParagraph(kid_elem);
                    if (paragraph != null)
                    {
                        return paragraph;
                    }

                }
            }
            return null;
        }

        private static PdsStructElement GetFirstParagraph(PdsStructTree struct_tree)
        {
            for (int i = 0; i < struct_tree.GetNumChildren(); i++)
            {
                PdsObject kid_obj = struct_tree.GetChildObject(i);
                PdsStructElement kid_elem = struct_tree.GetStructElementFromObject(kid_obj);
                var paragraph = GetFirstParagraph(kid_elem);
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

            // cleanup any previous structure tree
            if (!doc.RemoveTags(null, IntPtr.Zero))
                throw new Exception(pdfix.GetErrorType().ToString());

            // autotag document first
            if (!doc.AddTags(null, IntPtr.Zero))
                throw new Exception(pdfix.GetErrorType().ToString());

            // get the struct tree
            PdsStructTree struct_tree = doc.GetStructTree();
            if (struct_tree == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            PdsStructElement paragraph = GetFirstParagraph(struct_tree);
            if (paragraph == null)
                throw new Exception("No table found.");

            // move paragraph to the back of it's parent
            PdsStructElement parent = struct_tree.GetStructElementFromObject(paragraph.GetParentObject());
            if (parent == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            if (!paragraph.SetParent(parent, parent.GetNumChildren() - 1))
                throw new Exception(pdfix.GetErrorType().ToString());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}