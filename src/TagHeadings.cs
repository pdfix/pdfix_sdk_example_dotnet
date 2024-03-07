﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// TagAsArtifact.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagHeadings
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetPageObjectTextState
        // get text object's of specified mcid the text state
        //////////////////////////////////////////////////////////////////////////////////////////////////
        static PdfTextState GetPageObjectTextState(PdsPageObject page_object, int mcid)
        {
            if (page_object.GetObjectType() == PdfPageObjectType.kPdsPageText)
            {
                PdsText text = (PdsText)page_object;

                // check if this text page object has the same mcid
                PdsContentMark content_mark = page_object.GetContentMark();
                if (content_mark != null && content_mark.GetTagMcid() == mcid)
                {
                    PdfTextState ts = text.GetTextState();
                    if (ts.font != null)
                        return ts;
                }
            }
            else if (page_object.GetObjectType() == PdfPageObjectType.kPdsPageForm)
            {
                // search for the text object inside of the form XObject
                PdsForm form = (PdsForm)page_object;
                var content = form.GetContent();
                for (int i = 0; i < content.GetNumObjects(); i++)
                {
                    var ts = GetPageObjectTextState(content.GetObject(i), mcid);
                    if (ts.font != null)
                        return ts;
                }
            }
            return new PdfTextState();
        }        

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // GetParagraphTextState
        // get the text state of the text objects inside paragraph by iterating content kid objects
        //////////////////////////////////////////////////////////////////////////////////////////////////
        static PdfTextState GetParagraphTextState(PdsStructElement struct_elem)
        {
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
                    for (int j = 0; j < content.GetNumObjects();)
                    {
                        var ts = GetPageObjectTextState(content.GetObject(j), mcid);
                        page.Release();
                        return ts;
                    }
                    page.Release();
                }
            }
            return new PdfTextState();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // TagParagraphAsHeading
        // re-tag the struct element to heading based on font properties
        //////////////////////////////////////////////////////////////////////////////////////////////////
        static void TagParagraphAsHeading(PdsStructElement struct_elem)
        {
            string type = struct_elem.GetType_(true);
            if (type == "P") {
                // get the paragraph text_state
                PdfTextState ts = GetParagraphTextState(struct_elem);

                // get the font name
                string font_name = ts.font != null ? ts.font.GetFontName() : "";
                string tag_type = "";
                if (font_name.Contains("Black") && ts.font_size >= 25)
                    tag_type = "H1";
                else if (font_name.Contains("Bold") && ts.font_size >= 16)
                    tag_type = "H2";

                // update tag type
                if (tag_type.Length != 0)
                {
                    struct_elem.SetType(tag_type);
                }
                return; // this was a P tag, no need to continue to kid struct elements
            }
            // search kid struct elements
            for (int i = 0; i < struct_elem.GetNumChildren(); i++)
            {
                if (struct_elem.GetChildType(i) == PdfStructElementType.kPdsStructChildElement)
                {
                    PdsObject kid_obj = struct_elem.GetChildObject(i);
                    PdsStructElement kid_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);
                    TagParagraphAsHeading(kid_elem);
                }
            }
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

            // tag text on the bottom of the page as artifact
            for (int i = 0; i < struct_tree.GetNumChildren(); i++)
            {
                PdsObject kid_obj = struct_tree.GetChildObject(i);
                PdsStructElement kid_elem = struct_tree.GetStructElementFromObject(kid_obj);
                TagParagraphAsHeading(kid_elem);
            }

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}