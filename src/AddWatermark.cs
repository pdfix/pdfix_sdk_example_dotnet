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
            int start_page,                             // start page number
            int end_page,                               // end page number
            int order_top,                              // number specifying where in the page z-order the watermark should be added
            bool percentage_vals,                       // boolean specifying the units of horizValue and vertValue
            PdfAlignment h_align,                       // the horizontal alignment to be used when adding the watermark to a page
            PdfAlignment v_align,                       // the vertical alignment to be used when adding the watermark to a page
            float h_value,                              // the horizontal offset value to be used when adding the watermark on a page
            float v_value,                              // the vertical offset value to be used when adding the watermark on a page
            float scale,                                // the scale factor to be used when adding the watermark, with 1.0 meaning 100%
            float rotation,                             // the counter-clockwise rotation, in degrees, to be used when adding the watermark
            float opacity                               // the opacity to be used when adding the watermark
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

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

            var page_num = doc.GetNumPages();
            if (end_page == -1 || end_page >= page_num)
                end_page = page_num - 1;

            if (start_page >= page_num || end_page < start_page)
                throw new Exception("Page number out of range");

            for (int i = start_page; i <= end_page; i++)
            {
                var page = doc.AcquirePage(i);
                if (page == null)
                  throw new Exception(pdfix.GetError());

                var content = page.GetContent();
                if (content == null)
                  throw new Exception(pdfix.GetError());

                var xobjdict = image_obj.GetStreamDict();
                var width = xobjdict.GetNumber("Width");
                var height = xobjdict.GetNumber("Height");

                // prepare the matrix
                var page_mx = page.GetDefaultMatrix();
                var crop_rect = page.GetCropBox();
                PdfMatrix page_mx_rev = Utils.PdfMatrixInverse(page_mx);

                // scale
                var width_scaled = width * scale;
                var height_scaled = height * scale;

                var matrix = new PdfMatrix(width_scaled, 0, 0, height_scaled, 0, 0);

                if (rotation != 0.0f)
                {
                    matrix = Utils.PdfMatrixTranslate(matrix, -width_scaled / 2, -height_scaled / 2, false);
                    matrix = Utils.PdfMatrixRotate(matrix, (rotation / 180.0f) * Utils.kPi, false);
                    matrix = Utils.PdfMatrixTranslate(matrix, width_scaled / 2, height_scaled / 2, false);
                }

                // horizontal align
                var rect_h = crop_rect.right - crop_rect.left;
                var rect_v = crop_rect.top - crop_rect.bottom;
                if (h_align == PdfAlignment.kAlignmentCenter)
                    matrix = Utils.PdfMatrixTranslate(matrix, (rect_h - width_scaled) / 2, 0.0f, false);
                else if (h_align == PdfAlignment.kAlignmentRight)
                    matrix = Utils.PdfMatrixTranslate(matrix, (rect_h - width_scaled), 0.0f, false);

                // vertical align
                if (v_align == PdfAlignment.kAlignmentCenter)
                    matrix = Utils.PdfMatrixTranslate(matrix, 0.0f, (rect_v - height_scaled) / 2, false);
                else if (v_align == PdfAlignment.kAlignmentTop)
                    matrix = Utils.PdfMatrixTranslate(matrix, 0.0f, (rect_v - height_scaled), false);

                // horizontal and vertical offset
                var offs_h = percentage_vals ? rect_h * h_value : h_value;
                var offs_v = percentage_vals ? rect_v * v_value : v_value;

                //-offs_v because y coordinate from top to bottom
                matrix = Utils.PdfMatrixTranslate(matrix, offs_h, -offs_v, false);

                var position = order_top == 1 ? -1 : 0;
                var imageobject = content.AddNewImage(position, image_obj, matrix);

                // set opacity of the image 0-255
                var graphicState = imageobject.GetGState();
                graphicState.color_state.fill_opacity = (int)(opacity * 255);
                imageobject.SetGState(graphicState);

                page.SetContent();

                page.Release();
            }

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}