////////////////////////////////////////////////////////////////////////////////////////////////////
// ExtractTextFromOCGLayer.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;
using System.Collections.Generic;

namespace PDFix.App.Module
{
    class ExtractTextFromOCGLayer
    {
        // get the ocg layers of the page object
        internal static List<KeyValuePair<string, int>> GetPageObjectLayers(PdsPageObject page_object)
        {
            List<KeyValuePair<string, int>> layers = new List<KeyValuePair<string, int>>();

            var content_mark = page_object.GetContentMark();
            if (content_mark != null)
            {
                for (var i = 0; i < content_mark.GetNumTags(); i++)
                {
                    var name = content_mark.GetTagName(i);
                    if (name == "OC")
                    {
                        var content_mark_obj = content_mark.GetTagObject(i);
                        if (content_mark_obj != null)
                        {
                            void push_ocg(PdsDictionary ocg)
                            {
                                var ocg_name = ocg.GetText("Name");
                                var id = ocg.GetId();
                                layers.Add(new KeyValuePair<string, int>(ocg_name, id));
                            }

                            var type = content_mark_obj.GetText("Type");

                            if (type == "OCMD")
                            {
                                var ocgs_dict = content_mark_obj.GetDictionary("OCGs");
                                if (ocgs_dict != null)
                                {
                                    push_ocg(ocgs_dict);
                                }
                                var ocgs_arr = content_mark_obj.GetArray("OCGs");
                                if (ocgs_arr != null)
                                {
                                    for (var j = 0; j < ocgs_arr.GetNumObjects(); j++)
                                    {
                                        var ocg_dict = ocgs_arr.GetDictionary(j);
                                        push_ocg(ocg_dict);
                                    }
                                }
                            }
                            else if (type == "OCG")
                            {
                                push_ocg(content_mark_obj);
                            }
                        }
                    }
                }
            }
            return layers;
        }

        // check page object if it fits to
        internal static void CheckPageObject(PdsPageObject page_object, KeyValuePair<string, int> layer)
        {
            switch (page_object.GetObjectType())
            {
                case PdfPageObjectType.kPdsPageText:
                    {
                        var text_obj = (PdsText)page_object;
                        string text = text_obj.GetText();
                        var layers = GetPageObjectLayers(page_object);
                        foreach (KeyValuePair<string, int> l in layers)
                        {
                            if (layer.Key == l.Key && layer.Value == l.Value)
                            {
                                Console.WriteLine(text);
                                break;
                            }
                        }
                    }
                    break;
            }
        }

        public static void Run(
            String openPath                             // source PDF document
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            var rootObj = doc.GetRootObject();
            var layers = ReadOCGLayers.ReadLayerNames(rootObj);

            var page = doc.AcquirePage(0);
            foreach (KeyValuePair<string, int> layer in layers)
            {
                Console.WriteLine("Text in layer " + layer.Key + "(" + layer.Value.ToString() + ")");
                var content = page.GetContent();
                for (var i = 0; i < content.GetNumObjects(); i++)
                {
                    var page_obj = content.GetObject(i);
                    CheckPageObject(page_obj, layer);
                }

            }
            page.Release();
            doc.Close();
            pdfix.Destroy();
        }
    }
}