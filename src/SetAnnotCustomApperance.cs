////////////////////////////////////////////////////////////////////////////////////////////////////
// SetAnnotCustomAppearance.cs
// Copyright (c) 2021 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class SetAnnotCustomAppearance
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String imgPath                              // watermark to apply
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // identify image format from file path
            PdfImageFormat format = PdfImageFormat.kImageFormatJpg;
            if (Path.GetExtension(imgPath).ToLower() == ".png")
                format = PdfImageFormat.kImageFormatPng;

            // load image file data into memory stream
            byte[] bytes = File.ReadAllBytes(imgPath);
            var memStm = pdfix.CreateMemStream();
            if (memStm == null)
                throw new Exception(pdfix.GetError());
            memStm.Write(0, bytes);

            // create XObject from the image
            var image_obj = doc.CreateXObjectFromImage(memStm, format);
            if (image_obj == null)
                throw new Exception(pdfix.GetError());

            // create path object


            // add annotation on the first page
            var page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());

            var page_view = page.AcquirePageView(1, PdfRotate.kRotate0);
            if (page_view == null)
                throw new Exception(pdfix.GetError());

            // rect for the new annotation
            PdfRect annot_rect = new PdfRect()
            {
                left = 100,
                right = 300,
                bottom = 100,
                top = 200
            };

            PdfAnnot annot = page.AddNewAnnot(0, annot_rect, PdfAnnotSubtype.kAnnotStamp);
           
            // create content
            var content = doc.CreateContent();
            
            // add image to content
            var xobjdict = image_obj.GetStreamDict();
            var width = xobjdict.GetNumber("Width");
            var height = xobjdict.GetNumber("Height");
            var ratio = height / width;
            var res_width = annot_rect.right - annot_rect.left;
            var res_height = res_width * ratio;
            var center_adj = ((annot_rect.top - annot_rect.bottom) - res_height) / 2;
            var imageobject = content.AddNewImage(-1, image_obj, new PdfMatrix(res_width,0,0,res_height,0,center_adj));
            PdfGraphicState imageGs = new PdfGraphicState();
            imageGs.color_state.fill_opacity = 255;
            imageobject.SetGState(imageGs);

            // create text state
            PdfTextState textState = new PdfTextState();
            var colorSpace = doc.CreateColorSpace(PdfColorSpaceFamily.kColorSpaceDeviceRGB);
            var fontName = "Segoe UI";
            var fn = fontName.Trim();
            var sysFont = pdfix.FindSysFont(fn, 0, PdfFontCodepage.kFontDefANSICodepage);
            if (sysFont == null)
                throw new Exception(pdfix.GetError());
            textState.font = doc.CreateFont(sysFont, PdfFontCharset.kFontAnsiCharset, 0);
            sysFont.Destroy();
            
            if (textState.font == null)
                throw new Exception(pdfix.GetError());

            textState.font_size = 11;
            textState.color_state.fill_type = PdfFillType.kFillTypeSolid;
            var fill_color = colorSpace.CreateColor();
            fill_color.SetValue(0, 0.5);
            fill_color.SetValue(1, 0.5);
            fill_color.SetValue(2, 0.5);
            textState.color_state.fill_color = fill_color;
            textState.color_state.fill_opacity = 255;
            textState.color_state.stroke_type = PdfFillType.kFillTypeSolid;
            var stroke_color = colorSpace.CreateColor();
            stroke_color.SetValue(0, 0);
            stroke_color.SetValue(1, 0);
            stroke_color.SetValue(2, 0);
            textState.color_state.stroke_color = stroke_color;
            textState.color_state.stroke_opacity = 255;
            textState.char_spacing = 2;

            // add text to content
            var line = "test text in appearance";
            var textObject = content.AddNewText(-1, textState.font, new PdfMatrix(1,0,0,1,10,10));
            if (textObject == null)
                throw new Exception(pdfix.GetError());
            
            textObject.SetTextState(textState);
            textObject.SetText(line);

            // set annotation appearance
            PdsContentParams contentParams = new PdsContentParams();
            contentParams.bbox = new PdfRect(annot_rect.right - annot_rect.left, 0, 0, annot_rect.top - annot_rect.bottom);
            contentParams.matrix = new PdfMatrix(1,0,0,1,0,0);
            contentParams.form_type = 1;
            contentParams.flags = 2;
            var appearance_stream = content.ToObject(doc, contentParams);
            annot.SetAppearanceFromXObject(appearance_stream, PdfAnnotAppearanceMode.kAppearanceNormal);

            page.Release();

            // save document
            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}