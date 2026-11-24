////////////////////////////////////////////////////////////////////////////////////////////////////
// TagTableAsFigure.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagTableAsFigure
    {
        internal static Pdfix pdfix;

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
                    if (page == null)
                        throw new Exception(pdfix.GetError());

                    // find page objects with the same mcid on the page to get their bbox
                    int mcid = struct_elem.GetChildMcid(i);
                    var content = page.GetContent();
                    for (int j = 0; j < content.GetNumObjects(); j++)
                    {
                        PdsPageObject page_object = content.GetObject(j);

                        // check if this page object has the same mcid
                        // (PdsContentMark.GetTagMcid returns the index of the tag, not the MCID)
                        if (page_object.GetMcid() == mcid)
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
                    page.Release();
                }
                else if (struct_elem.GetChildType(i) == PdfStructElementType.kPdsStructChildElement)
                {
                    PdsObject kid_obj = struct_elem.GetChildObject(i);
                    PdsStructElement kid_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                    if (GetStructElementBBox(kid_elem, ref bbox))
                        result = true;
                }
            }
            return result;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // SetStateFlagsOutside
        // set state flags on page objects and annotations that do not intersect the bbox
        // (all of them when bbox is null), and reset the others to the default state
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static bool Intersects(PdfRect a, PdfRect b)
        {
            return (a.left < b.right) && (b.left < a.right) && (a.bottom < b.top) && (b.bottom < a.top);
        }

        private static void SetStateFlagsOutside(PdfPage page, PdfRect bbox, int flags)
        {
            var content = page.GetContent();
            for (int i = 0; i < content.GetNumObjects(); i++)
            {
                PdsPageObject page_object = content.GetObject(i);
                bool inside = bbox != null && Intersects(page_object.GetBBox(), bbox);
                page_object.SetStateFlags(inside ? Pdfix.kStateDefault : flags);
            }
            for (int i = 0; i < page.GetNumAnnots(); i++)
            {
                PdfAnnot annot = page.GetAnnot(i);
                if (annot == null)
                    continue;
                bool inside = bbox != null && Intersects(annot.GetBBox(), bbox);
                annot.SetStateFlags(inside ? Pdfix.kStateDefault : flags);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // HasChildOfType
        // check if the struct element has a direct kid struct element of the given type
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static bool HasChildOfType(PdsStructElement struct_elem, string type)
        {
            for (int i = 0; i < struct_elem.GetNumChildren(); i++)
            {
                if (struct_elem.GetChildType(i) != PdfStructElementType.kPdsStructChildElement)
                    continue;
                PdsObject kid_obj = struct_elem.GetChildObject(i);
                PdsStructElement kid_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                if (kid_elem != null && kid_elem.GetType_(true) == type)
                    return true;
            }
            return false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetFirstParagraph
        // get reference to the first paragraph on the page
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private static PdsStructElement GetFirstTable(PdsStructElement struct_elem)
        {
            // search kid struct elements
            for (int i = 0; i < struct_elem.GetNumChildren(); i++)
            {
                if (struct_elem.GetChildType(i) == PdfStructElementType.kPdsStructChildElement)
                {
                    PdsObject kid_obj = struct_elem.GetChildObject(i);
                    PdsStructElement kid_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                    if (kid_elem == null)
                        throw new Exception(pdfix.GetErrorType().ToString());

                    string type = kid_elem.GetType_(true);
                    if (type == "Table")
                        return kid_elem;

                    var table = GetFirstTable(kid_elem);
                    if (table != null)
                    {
                        return table;
                    }

                }
            }
            return null;
        }

        private static PdsStructElement GetFirstTable(PdsStructTree struct_tree)
        {
            for (int i = 0; i < struct_tree.GetNumChildren(); i++)
            {
                PdsObject kid_obj = struct_tree.GetChildObject(i);
                PdsStructElement kid_elem = struct_tree.GetStructElementFromObject(kid_obj);
                var paragraph = GetFirstTable(kid_elem);
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
            pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // cleanup any previous structure tree
            if (!doc.RemoveTags())
                throw new Exception(pdfix.GetErrorType().ToString());

            // autotag document first
            if (!doc.AddTags(new PdfTagsParams()))
                throw new Exception(pdfix.GetErrorType().ToString());

            // get the struct tree
            PdsStructTree struct_tree = doc.GetStructTree();
            if (struct_tree == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            PdsStructElement table = GetFirstTable(struct_tree);
            if (table == null)
                throw new Exception("No table found.");

            PdfRect bbox = new PdfRect();
            if (!GetStructElementBBox(table, ref bbox))
                throw new Exception("Table has no content.");

            // remove all items from the table to make it untagged cotnent
            for (int i = table.GetNumChildren() - 1; i >= 0; i--)
                table.RemoveChild(i);

            // tag page
            PdfPage page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());
            PdePageMap page_map = null;
            try
            {
                // exclude content and annotations outside the table so AddTags writes only the
                // figure; otherwise the whole page would be re-tagged into the table element
                SetStateFlagsOutside(page, bbox, Pdfix.kStateNoRender | Pdfix.kStateExclude);

                page_map = page.AcquirePageMap();
                if (page_map == null)
                    throw new Exception(pdfix.GetError());
                PdeElement elem = page_map.CreateElement(PdfElementType.kPdeImage, null);
                if (elem == null)
                    throw new Exception(pdfix.GetError());
                elem.SetBBox(bbox);
                elem.SetAlt("This is image caption");

                // re-tag the table content as a figure
                if (!page_map.CreateElements())
                    throw new Exception(pdfix.GetError());

                if (!page_map.AddTags(table, false, new PdfTagsParams()))
                    throw new Exception(pdfix.GetErrorType().ToString());
            }
            finally
            {
                if (page_map != null)
                    page_map.Release();
                SetStateFlagsOutside(page, null, Pdfix.kStateDefault);
                page.Release();
            }

            // AddTags must put the new Figure into the table element passed as the parent
            if (!HasChildOfType(table, "Figure"))
                throw new Exception("Figure was not tagged into the table element.");

            // udpate the table element type
            if (!table.SetType("Sect"))
                throw new Exception(pdfix.GetErrorType().ToString());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}