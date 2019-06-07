////////////////////////////////////////////////////////////////////////////////////////////////////
// TagsReadingOrder.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*!
\page CS_Samples C# Samples
- \subpage TagsReadingOrder_cs
*/
/*!
\page TagsReadingOrder_cs Edit structure tree reading order
Example how to manually modify order of struct elements in a structure tree.
\snippet /TagsReadingOrder.cs TagsReadingOrder_cs
*/

//\cond INTERNAL
//! [TagsReadingOrder_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagsReadingOrder
    {
        internal static Pdfix pdfix;
        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetFirstParagraph
        // get reference to the first paragraph on the page
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static PdsStructElement GetFirstParagraph(PdsStructElement struct_elem)
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
                    if (type == "P")
                        return kid_elem;

                    var paragraph = GetFirstParagraph(kid_elem);
                    if (paragraph != null)
                    {
                        kid_elem.Release();
                        return paragraph;
                    }

                    kid_elem.Release();
                }
            }
            return null;
        }

        private static PdsStructElement GetFirstParagraph(PdsStructTree struct_tree)
        {
            for (int i = 0; i < struct_tree.GetNumKids(); i++)
            {
                PdsObject kid_obj = struct_tree.GetKidObject(i);
                PdsStructElement kid_elem = struct_tree.AcquireStructElement(kid_obj);
                var paragraph = GetFirstParagraph(kid_elem);
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
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath                             // dest PDF document
            )
        {
            pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetErrorType().ToString());

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
            PdsStructElement parent = struct_tree.AcquireStructElement(paragraph.GetParentObject());
            if (parent == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            if (!paragraph.SetParent(parent, parent.GetNumKids() - 1))
                throw new Exception(pdfix.GetErrorType().ToString());

            if (!doc.Save(savePath, PdfSaveFlags.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [TagsReadingOrder_cs]
//\endcond
