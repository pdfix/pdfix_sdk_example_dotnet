////////////////////////////////////////////////////////////////////////////////////////////////////
// ChangeTextColor.cs
// Copyright (c) 2021 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class ChangeTextColor
    {
        public static void Run(
               String openPath,                            // source PDF document
               String savePath                             // output PDF document
               )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // crate color space
            var rgb_color_space = doc.CreateColorSpace(PdfColorSpaceFamily.kColorSpaceDeviceRGB);

            var page_num = doc.GetNumPages();
            for (int i = 0; i < page_num; i++)
            {
                List<PdfRect> link_annots = new List<PdfRect> { };
                var page = doc.AcquirePage(i);
                var annot_num = page.GetNumAnnots();
                for (int x = 0; x < annot_num; x++)
                {
                    var annot = page.GetAnnot(x);
                    if (annot.GetSubtype().Equals(PdfAnnotSubtype.kAnnotLink))
                        link_annots.Add(annot.GetBBox());
                }

                // get page content
                var content = page.GetContent();
                var objects_num = content.GetNumObjects();
                for (int z = 0; z < objects_num; z++)
                {
                    var content_obj = content.GetObject(z);
                    if (content_obj.GetObjectType().Equals(PdfPageObjectType.kPdsPageText))
                    {
                        foreach(var link_rect in link_annots)
                        {
                            if (Utils.contains(link_rect, content_obj.GetBBox()))
                            {
                                var text_obj = (PdsText)content_obj;
                                //create blue color and set to text
                                var blue = rgb_color_space.CreateColor();
                                blue.SetValue(0, 0);
                                blue.SetValue(1, 0);
                                blue.SetValue(2, 1);
                                var text_state = text_obj.GetTextState(doc);
                                text_state.color_state.fill_color = blue;
                                text_obj.SetTextState(text_state);
                            }
                        }
                    }
                }
                // apply changes on content
                page.SetContent();
            }

            // save document
            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();    
            pdfix.Destroy();
        }
    }
}