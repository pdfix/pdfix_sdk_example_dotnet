﻿////////////////////////////////////////////////////////////////////////////////////////////////////
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
            Pdfix pdfix = PdfixEngine.Instance;

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
            GetStructElementBBox(table, ref bbox);

            // remove all items from the table to make it untagged cotnent
            for (int i = table.GetNumChildren() - 1; i >= 0; i--)
                table.RemoveChild(i);

            // tag page
            PdfPage page = doc.AcquirePage(0);

            PdePageMap page_map = page.AcquirePageMap();
            PdeElement elem = page_map.CreateElement(PdfElementType.kPdeImage, null);
            elem.SetBBox(bbox);
            elem.SetAlt("This is image caption");

            // prepare document template to ignore already tagged content
            var doc_prelight = doc.GetTemplate();
            doc_prelight.SetProperty("ignore_tags", 1);

            // re-tag non-tagged page content
            PdePageMap pageMap = page.AcquirePageMap();
            if (pageMap == null)
                throw new Exception(pdfix.GetError());
            if (!pageMap.CreateElements())
                throw new Exception(pdfix.GetError());

            if (!page_map.AddTags(table, false, new PdfTagsParams()))
                throw new Exception(pdfix.GetErrorType().ToString());

            // udpate the table element type
            if (!table.SetType("Sect"))
                throw new Exception(pdfix.GetErrorType().ToString());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}