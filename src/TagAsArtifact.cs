////////////////////////////////////////////////////////////////////////////////////////////////////
// TagAsArtifact.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagAsArtifact
    {
        internal static int count;

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // MarkUntaggedObjectsAsArtifact
        // find any non-tagged objects in the page content and mark them as artifact
        //////////////////////////////////////////////////////////////////////////////////////////////////
        internal static void MarkUntaggedObjectsAsArtifact(PdfPage page)
        {
            PdfDoc doc = page.GetDoc();
            var content = page.GetContent();
            for (int i = 0; i < content.GetNumObjects(); i++)
            {
                PdsPageObject page_obj = content.GetObject(i);

                PdsContentMark content_mark = page_obj.GetContentMark();
                if (content_mark.GetTagArtifact() != -1 && content_mark.GetTagMcid() == -1)
                {
                    PdsDictionary artifact_dict = doc.CreateDictObject(false);
                    artifact_dict.Put("Type", doc.CreateNameObject(false, "Pagination"));
                    artifact_dict.Put("Subtype", doc.CreateNameObject(false, "Footer"));
                    content_mark.AddTag("Artifact", artifact_dict, false);
                }
            }
            page.SetContent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Remove paragraph from structure tree
        // re-tag the struct element to heading based on font properties
        //////////////////////////////////////////////////////////////////////////////////////////////////
        internal static void RemoveParagraph(PdsStructElement struct_elem)
        {
            // remove last 2 P struct elements from struct tree
            for (int i = struct_elem.GetNumChildren() - 1; i >= 0; i--)
            {
                if (struct_elem.GetChildType(i) == PdfStructElementType.kPdsStructChildElement)
                {
                    PdsObject kid_obj = struct_elem.GetChildObject(i);
                    PdsStructElement kid_elem = struct_elem.GetStructTree().GetStructElementFromObject(kid_obj);

                    string type = kid_elem.GetType_(true);
                    if (type == "P")
                    {
                        for (int j = kid_elem.GetNumChildren() - 1; j >= 0; j--)
                        {
                            if (!kid_elem.RemoveChild(j))
                                PdfixEngine.ThrowException();
                        }
                    }
                    else if (type == "Figure")
                    {
                        // remove figure if does not contain an alt text
                        string alt = kid_elem.GetAlt();
                        if (alt.Length == 0)
                        {
                            for (int j = kid_elem.GetNumChildren() - 1; j >= 0; j--)
                            {
                                if (!kid_elem.RemoveChild(j))
                                    PdfixEngine.ThrowException();
                            }
                        }
                    }
                    else
                    {
                        RemoveParagraph(kid_elem);
                    }
                    // remove this element if it has no kids
                    if (kid_elem.GetNumChildren() == 0)
                        struct_elem.RemoveChild(i);

                }
                // remove only 2 paragraphs in this sample
                if (++count >= 2) break;
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
            if (!doc.RemoveTags(null, null))
                throw new Exception(pdfix.GetErrorType().ToString());

            // autotag document first
            if (!doc.AddTags(null, null))
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
                RemoveParagraph(kid_elem);
            }

            // the struct tree was updates, save page content on each page to apply changes
            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                PdfPage page = doc.AcquirePage(i);
                MarkUntaggedObjectsAsArtifact(page);
                page.Release();
            }

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}