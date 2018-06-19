////////////////////////////////////////////////////////////////////////////////////////////////////
// AddWatermark.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*! 
\page CS_Samples C# Samples
- \subpage AddWatermark_cs
*/
/*! 
\page AddWatermark_cs Add Watermark Sample
// Example how to add a watermark.
\snippet /AddWatermark.cs AddWatermark_cs
*/

//\cond INTERNAL
//! [AddWatermark_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class AddWatermark
    {
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String imgPath,                             // watermark to apply
            PdfWatermarkParams watermarkParams          // watermark params
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetError());

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // set watermark params
            watermarkParams.page_range.start_page = 1;
            watermarkParams.page_range.end_page = 3;
            watermarkParams.page_range.page_range_spec = PdfPageRangeType.kEvenPagesOnly;
            watermarkParams.h_value = 10;
            watermarkParams.v_value = 10;
            watermarkParams.scale = 0.5;
            watermarkParams.opacity = 0.5;

            if (!doc.AddWatermarkFromImage(watermarkParams, imgPath))
                throw new Exception(pdfix.GetError());

            if (!doc.Save(savePath, PdfSaveFlags.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [AddWatermark_cs]
//\endcond
