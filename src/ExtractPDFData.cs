using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class ExtractData
    {
        public class DataType
        {
            public bool doc_info = false;                // general document information (title, author, creator, page count)
            public bool doc_acroform = false;            // pdf form fields
            public bool doc_outlines = false;            // document bookmarks
            public bool doc_struct_tree = false;         // document structure tree (list pdf tags)

            // page data extraction
            public int page_num = -1;                    // page to process, default -1 to process all pages
            public bool page_info = false;               // general page information (bbox, rotation, etc.)
            public bool page_map = false;                // page logical content extraction, scrape pdf data
            public bool page_content = false;            // page raw contnet
            public bool page_annots = false;             // page annotations

            // page content
            public bool page_object_info = false;        // extract general page object information (bbox, etc.)

            // page map and page content extraction
            public bool extract_text = false;           // extract text when extracting page map or page content
            public bool extract_text_style = false;     // extract text style of the text element
            public bool extract_text_state = false;     // extract text state if the text object or element
            public bool extract_tables = false;         // extract table strecture extracting page map
            public bool extract_images = false;         // extract images when extracting page map or page content
            public bool extract_paths = false;          // extract images when extracting page content
            public bool extract_bbox = false;           // extract element or object bbox
            public bool extract_graphic_state = false;  // extract object's graphic state

            // structure tree
            public bool struct_tree_content = false;     // extract content when listing structure tree using doc_struct_tree

            // rendering and images
            public float render_zoom = 1.0f;              // page rasterizing zoom of image extraction
            public PdfRotate render_rotate = PdfRotate.kRotate0;   // page rasterizing rotation of image extraction
            public PdfImageFormat image_format = PdfImageFormat.kImageFormatJpg;  // format of the image
        }

        private static void ExtractBBox(PdfRect bbox, JObject node, DataType data_types)
        {
            node.Add("left", bbox.left);
            node.Add("top", bbox.top);
            node.Add("right", bbox.right);
            node.Add("bottom", bbox.bottom);
        }
        private static void ExtractWidgetAnnot(PdfWidgetAnnot widget, JObject node, DataType data_types)
        {
            var form_field = widget.GetFormField();
            if (form_field != null)
            {
                node.Add("field_name", form_field.GetFullName());
                PdfFieldType field_type = PdfFieldType.kFieldUnknown;
                switch (field_type)
                {
                    case PdfFieldType.kFieldButton:
                        node.Add("field_type", "button");
                        break;
                    case PdfFieldType.kFieldText:
                        node.Add("field_type", "text");
                        break;
                    case PdfFieldType.kFieldCombo:
                        node.Add("field_type", "dropdown");
                        break;
                    case PdfFieldType.kFieldCheck:
                        node.Add("field_type", "checkbox");
                        break;
                    case PdfFieldType.kFieldRadio:
                        node.Add("field_type", "radio");
                        break;
                    case PdfFieldType.kFieldList:
                        node.Add("field_type", "list");
                        break;
                    case PdfFieldType.kFieldSignature:
                        node.Add("field_type", "signature");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                node.Add("field_type", "invalid");
            }
        }

        private static void ExtractAnnot(PdfAnnot annot, JObject node, DataType data_types)
        {
            var annot_dict = annot.GetObject();
            var subtype = annot_dict.GetText("Subtype");
            node.Add("subtype", subtype);
            if (data_types.extract_bbox)
            {
                var bbox_node = new JObject();
                ExtractBBox(annot.GetBBox(), bbox_node, data_types);
                node.Add("bbox", bbox_node);
            }

            if (subtype == "Widget")
                ExtractWidgetAnnot((PdfWidgetAnnot)annot, node, data_types);
        }

        private static void ExtractPageAnnots(PdfPage page, JObject node, DataType data_types)
        {
            // annotations
            var annots_node = new JArray();
            for (int i = 0; i < page.GetNumAnnots(); i++)
            {
                var annot = page.GetAnnot(i);
                if (annot == null)
                    continue;
                var annot_node = new JObject();
                ExtractAnnot(annot, annot_node, data_types);
                annots_node.Add(annot_node);
            }
            if (annots_node.Count > 0)
                node.Add("annots", annots_node);
        }

        private static void ExtractPageInfo(PdfPage page, JObject node, DataType data_types) 
        {
            // TODO
        }

        // extract page data
        private static void ExtractPageData(PdfPage page, JObject node, DataType data_types)
        {
            if (data_types.page_info)
                ExtractPageInfo(page, node, data_types);

            if (data_types.page_annots)
                ExtractPageAnnots(page, node, data_types);

            //if (data_types.page_map)
            //    ExtractPageMap(page, node, data_types);

            //if (data_types.page_content)
            //    ExtractPageContent(page, node, data_types);
        }

        // extract general document information (metadata, page count, is tagged, is form)
            public static void ExtractDocumentInfo(PdfDoc doc, JObject node, DataType data_types) {
            node.Add("title", doc.GetInfo("Title"));
            node.Add("author", doc.GetInfo("Author"));
            node.Add("creator", doc.GetInfo("Creator"));
            node.Add("num_pages", doc.GetNumPages());
            node.Add("tagged", doc.GetStructTree() != null);
        }

        private static void ExtractDocumentPages(PdfDoc doc, JObject node, DataType data_types)
        {
            var pages_node = new JArray(); // node holding the page array

            var from_page = data_types.page_num == -1 ? 0 : data_types.page_num;
            var to_page = data_types.page_num == -1 ? doc.GetNumPages() - 1 : data_types.page_num;

            for (var i = from_page; i <= to_page; i++)
            {
                var page = doc.AcquirePage(i);
                if (page == null)
                    throw new Exception(new Pdfix().GetError());

                var page_node = new JObject(); // node holding the page
                page_node.Add("page_number", i + 1);
                ExtractPageData(page, page_node, data_types);
                if (page_node.Count > 0)
                    pages_node.Add(page_node);
            }
            if (pages_node.Count > 0)
                node.Add("pages", pages_node);
        }

        private static void ExtractDocumentStructTree(PdfDoc doc, JObject node, DataType data_types) 
        {
            // TODO
        }

        // save document information
        private static void ExtractDocumentData(PdfDoc doc, JObject node, DataType data_types) {
            if (data_types.doc_info)
                ExtractDocumentInfo(doc, node, data_types);

            if (data_types.doc_struct_tree)
                ExtractDocumentStructTree(doc, node, data_types);

            // if (data_types.doc_acroform)
            //   ExtractDocumentAcroForm(doc, ptree & node, data_types);

            // pages
            ExtractDocumentPages(doc, node, data_types);
        }

            public static void Run(
            String openPath,                            // source PDF document
            String configPath,                          // configuration file
            bool preflight                              // create document preflight
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            var docTemplate = doc.GetTemplate();
            if (docTemplate == null)
                throw new Exception(pdfix.GetError());

            // load config if set
            if (configPath.Length > 0)
            {
                var stm = pdfix.CreateFileStream(configPath, PsFileMode.kPsReadOnly);
                if (stm != null)
                {
                    if (!docTemplate.LoadFromStream(stm, PsDataFormat.kDataFormatJson))
                        throw new Exception(pdfix.GetError());
                    stm.Destroy();
                }
            }

            if (preflight)
            {
                for (var i = 0; i < doc.GetNumPages(); i++)
                {
                    if (!docTemplate.AddPage(i))
                        throw new Exception(pdfix.GetError());
                }
                if (docTemplate.Update())
                    throw new Exception(pdfix.GetError());
            }

            // prepare the output JSON 
            var docObj = new JObject();

            var dataType = new DataType();
            dataType.page_annots = true;
            dataType.extract_bbox = true;

            ExtractDocumentData(doc, docObj, dataType);

            doc.Close();

            Console.Write(docObj.ToString());
        }
    }
}
