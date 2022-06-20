////////////////////////////////////////////////////////////////////////////////////////////////////
// TagsReadStructTree.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagsReadStructTree
    {

        // collect all bounding boxes of the page object with specified mcid
        static List<PdfRect> GetMcidBBoxes(PdsPageObject obj, int mcid)
        {
            var bboxes = new List<PdfRect>();
            // check object mcid
            var content_mark = obj.GetContentMark();
            if (content_mark != null && content_mark.GetTagMcid() == mcid)
            {
                bboxes.Add(obj.GetBBox());
            }
            else {
                if (obj.GetObjectType() == PdfPageObjectType.kPdsPageForm)
                {
                    var form_obj = (PdsForm)obj;
                    var content = form_obj.GetContent();
                    for (var i = 0; i < content.GetNumObjects(); i++)
                    {
                        bboxes.AddRange(GetMcidBBoxes(content.GetObject(i), mcid));
                    }
                }
            }
            return bboxes;
        }

        // collect bounding boxes of elements on a page with specified mcid
        static List<PdfRect> GetMcidBBoxes(PdfDoc doc, int page_num, int mcid)
        {
            var bboxes = new List<PdfRect>();
            var page = doc.AcquirePage(page_num);
            var content = page.GetContent();
            for (var i = 0; i < content.GetNumObjects(); i++)
            {
                bboxes.AddRange(GetMcidBBoxes(content.GetObject(i), mcid));
            }
            page.Release();
            return bboxes;
        }

        // process struct element childs and collect all bboxes of the content elements
        // bounding boxes of child elements and content can be placed on different pages
        static List<PdfRect> GetStructElementBboxes(PdfDoc doc, PdsStructElement struct_elem)
        {
            var bboxes = new List<PdfRect>();
            int num_kids = struct_elem.GetNumChildren();
            for (int i = 0; i < num_kids; i++)
            {
                var kid_obj = struct_elem.GetChildObject(i);
                switch (struct_elem.GetChildType(i))
                {
                    case PdfStructElementType.kPdsStructChildElement:
                        {
                            var kid_struct_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                            if (kid_struct_elem == null)
                                PdfixEngine.ThrowException();
                            bboxes.AddRange(GetStructElementBboxes(doc, kid_struct_elem));
                        }
                        break;
                    case PdfStructElementType.kPdsStructChildObject:
                        break;
                    case PdfStructElementType.kPdsStructChildStreamContent:
                    case PdfStructElementType.kPdsStructChildPageContent:
                        {
                            var kid_page_num = struct_elem.GetChildPageNumber(i);
                            var mcid = struct_elem.GetChildMcid(i);
                            bboxes.AddRange(GetMcidBBoxes(doc, kid_page_num, mcid));
                        }
                        break;
                }
            }
            return bboxes;
        }

        static void ProcessStructElement(PdfDoc doc, PdsStructElement struct_elem, string indent)
        {
            indent += " ";
            if (struct_elem == null)
                PdfixEngine.ThrowException();

            // get the element type
            string type_str = struct_elem.GetType_(true);
            if (type_str.Length != 0)
                Console.WriteLine(indent + "Struct Element: " + type_str);


            // get struct element bounding boxes (can be on multiple pages)
            // skip document struct element - can take long time to collect all bboxes
            if (type_str != "Document") 
            {
                List<PdfRect> bboxes = GetStructElementBboxes(doc, struct_elem);
                bboxes.ForEach(delegate (PdfRect bbox)
                {
                    Console.WriteLine(indent + "[" + bbox.left + ", " + bbox.bottom + ", " + bbox.right + ", " +
                        bbox.top + "]");
                });
            }

            string tile_str = struct_elem.GetTitle();
            if (tile_str.Length != 0) 
                Console.WriteLine(indent + "title: " + tile_str);

            string actual_text_str = struct_elem.GetActualText();
            if (actual_text_str.Length != 0) 
                Console.WriteLine(indent + "actual text: " + actual_text_str);

            string alt_str = struct_elem.GetAlt();
            if (alt_str.Length != 0)
                Console.WriteLine(indent, "alt: " + alt_str);

            var page_num = struct_elem.GetPageNumber();
            if (page_num != -1)
                Console.WriteLine(indent, "Page number: "+ page_num);

            int num_kids = struct_elem.GetNumChildren();
            for (int i = 0; i < num_kids; i++)
            {
                var kid_obj = struct_elem.GetChildObject(i);
                // based on structure element you can obtain different data
                switch (struct_elem.GetChildType(i))
                {
                    case PdfStructElementType.kPdsStructChildElement:
                        {
                            var kid_struct_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                            if (kid_struct_elem == null)
                                PdfixEngine.ThrowException();
                            ProcessStructElement(doc, kid_struct_elem, indent);
                        }
                        break;
                    case PdfStructElementType.kPdsStructChildObject:
                        break;
                    case PdfStructElementType.kPdsStructChildStreamContent:
                        {
                            var kid_page_num = struct_elem.GetChildPageNumber(i);
                            Console.WriteLine(indent + "Kid Page number: " + kid_page_num);
                            var mcid = struct_elem.GetChildMcid(i);
                            Console.WriteLine(indent + "MCID: " + mcid);
                        }
                        break;
                    case PdfStructElementType.kPdsStructChildPageContent:
                        {
                            var mcid = struct_elem.GetChildMcid(i);
                            Console.WriteLine(indent + "MCID: " + mcid);
                        }
                        break;               
                }
            }
            Console.WriteLine("");
        }
        public static void Run(
            String openPath                             // source PDF document
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
            if (!doc.AddTags(new PdfTagsParams(), null, null))
                throw new Exception(pdfix.GetErrorType().ToString());

            // read document structure tree
            PdsStructTree struct_tree = doc.GetStructTree();
            if (struct_tree == null)
                Console.WriteLine("No Tags available");
            else
            {
                for (var i = 0; i < struct_tree.GetNumChildren(); i++)
                {
                    PdsObject kid_object = struct_tree.GetChildObject(i);
                    PdsStructElement struct_elem = struct_tree.GetStructElementFromObject(kid_object);
                    ProcessStructElement(doc, struct_elem, "");
                }
            }


            doc.Close();
        }
    }
}