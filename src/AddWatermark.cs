////////////////////////////////////////////////////////////////////////////////////////////////////
// AddWatermark.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class AddWatermark
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String imgPath,                             // watermark to apply
            PdfWatermarkParams watermarkParams          // watermark params
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            var img_stm = pdfix.CreateFileStream(imgPath, PsFileMode.kPsReadOnly);
            if (img_stm == null)
                throw new Exception(pdfix.GetError());

            // identify image format from file path
            PdfImageFormat format = PdfImageFormat.kImageFormatJpg;
            if (Path.GetExtension(imgPath).ToLower() == ".png")
                format = PdfImageFormat.kImageFormatPng;

            var image_obj = doc.CreateXObjectFromImage(img_stm, format);
            if (image_obj == null)
                throw new Exception(pdfix.GetError());

            var page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());

            var content = page.GetContent();
            if (content == null)
                throw new Exception(pdfix.GetError());

            var xobjdict = image_obj.GetStreamDict();
            var scale = 0.5f;
            var width = xobjdict.GetNumber("Width") * scale;
            var height = xobjdict.GetNumber("Height") * scale;
            var h_value = 20.0f;
            var v_value = 50.0f;

            //z order represented by the position in the content, -1 or last add to the top, 0 to the background
            var imageobject = content.AddNewImage(-1, image_obj, new PdfMatrix(width, 0, 0, height, h_value, v_value));

            //set opacity of the image 0-255
            var graphicState = imageobject.GetGState();
            graphicState.color_state.fill_opacity = 200;
            imageobject.SetGState(graphicState);

            page.SetContent();

            page.Release();

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}