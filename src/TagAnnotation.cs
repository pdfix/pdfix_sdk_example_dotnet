////////////////////////////////////////////////////////////////////////////////////////////////////
// TagAnnotation.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagAnnotation
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetParagraphBBox
        // get the text state of the text objects inside paragraph by iterating content kid objects
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static bool GetStructElementBBox(PdsStructElement struct_elem, ref PdfRect bbox)
        {
            bool result = false;
            for (int i = 0; i < struct_elem.GetNumChildren(); i++)
            {
                if (struct_elem.GetChildType(i) == PdfStructElementType.kPdsStructChildPageContent)
                {
                    // acquire page on which the element is present
                    PdfDoc doc = struct_elem.GetStructTree().GetDoc();
                    PdfPage page = doc.AcquirePage(struct_elem.GetChildPageNumber(i));

                    // find text object with mcid on the page to get the text state
                    int mcid = struct_elem.GetChildMcid(i);
                    var content = page.GetContent();
                    for (int j = 0; j < content.GetNumObjects(); j++)
                    {
                        PdsPageObject page_object = content.GetObject(j);

                        // check if this text page object has the same mcid
                        PdsContentMark content_mark = page_object.GetContentMark();
                        if (content_mark != null && content_mark.GetTagMcid() == mcid)
                        {
                            PdfRect elem_bbox = page_object.GetBBox();
                            if ((bbox.left - bbox.right == 0) || (bbox.top - bbox.bottom == 0))
                                bbox = elem_bbox;
                            else
                            {
                                bbox.left = Math.Min(bbox.left, elem_bbox.left);
                                bbox.right = Math.Max(bbox.right, elem_bbox.right);
                                bbox.top = Math.Max(bbox.top, elem_bbox.top);
                                bbox.bottom = Math.Min(bbox.bottom, elem_bbox.bottom);
                            }
                            result = true;
                        }
                    }
                }
                else if (struct_elem.GetChildType(i) == PdfStructElementType.kPdsStructChildElement)
                {
                    PdsObject kid_obj = struct_elem.GetChildObject(i);
                    PdsStructElement kid_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                    GetStructElementBBox(kid_elem, ref bbox);
                }
            }
            return result;
        }

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
            if (!doc.RemoveTags(null, null))
                throw new Exception(pdfix.GetErrorType().ToString());

            // autotag document first
            if (!doc.AddTags(null, null))
                throw new Exception(pdfix.GetErrorType().ToString());

            // get the struct tree
            PdsStructTree struct_tree = doc.GetStructTree();
            if (struct_tree == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            PdsStructElement paragraph = GetFirstParagraph(struct_tree);
            if (paragraph == null)
                throw new Exception("No paragraph found.");

            PdfRect annot_bbox = new PdfRect();
            GetStructElementBBox(paragraph, ref annot_bbox);

            // add new link annotation to the page
            PdfPage page = doc.AcquirePage(0);
            PdfLinkAnnot annot = (PdfLinkAnnot)page.CreateAnnot(PdfAnnotSubtype.kAnnotLink, annot_bbox);
            page.AddAnnot(0, annot);
            if (annot == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            // re-tag the document the link annotation
            if (!doc.RemoveTags(null, null))
                throw new Exception(pdfix.GetErrorType().ToString());
            if (!doc.AddTags(null, null))
                throw new Exception(pdfix.GetErrorType().ToString());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}