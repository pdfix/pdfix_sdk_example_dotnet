////////////////////////////////////////////////////////////////////////////////////////////////////
// AddWatermark.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Xml.Linq;
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

            // set watermark params
            watermarkParams.page_range.start_page = 1;
            watermarkParams.page_range.end_page = 3;
            watermarkParams.page_range.page_range_spec = PdfPageRangeType.kEvenPagesOnly;
            watermarkParams.h_value = 10;
            watermarkParams.v_value = 10;
            watermarkParams.scale = 0.5;
            watermarkParams.opacity = 0.5;

            if (!doc.AddWatermarkFromImage(watermarkParams, image_obj))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}