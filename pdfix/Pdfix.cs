////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2016 PDFix. All Rights Reserved.
// This file was generated automatically
////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Runtime.InteropServices;

namespace PDFixSDK {
  namespace Pdfix {
    internal class Util
    {
      static internal double PtrReadDouble(IntPtr ptr)
      {
        double[] d = { 0 };
        Marshal.Copy(ptr, d, 0, 1);
        return d[0];
      }
      static internal void PtrWriteDouble(IntPtr ptr, double value)
      {
        double[] d = { value };
        Marshal.Copy(d, 0, ptr, 1);
      }
      static internal int PtrReadInt(IntPtr ptr)
      {
        int[] i = { 0 };
        Marshal.Copy(ptr, i, 0, 1);
        return i[0];
      }
      static internal void PtrWriteInt(IntPtr ptr, int value)
      {
        int[] i = { value };
        Marshal.Copy(i, 0, ptr, 1);
      }
      static internal void PtrWritePtr(IntPtr ptr, IntPtr value)
      {
      }
    }
    public class PdfixBase
    {
      public IntPtr m_obj = IntPtr.Zero;
      public PdfixBase(IntPtr obj)
      {
        m_obj = obj;
      }
      protected void CheckBaseObj()
      {
        if (m_obj == IntPtr.Zero)
        {
          throw new Exception("Invalid object");
        }
      }
    }

    public enum PdfAuthPlatform
    {
      kAuthPlatformWin = 0,
      kAuthPlatformMac = 1,
      kAuthPlatformLinux = 2,
      kAuthPlatformAndroid = 3,
      kAuthPlatformiOS = 4,
      kAuthPlatformServer = 5,
    }
    public enum PdfAuthOption
    {
      kAuthOptionBasic = 0,
      kAuthOptionProfessional = 1,
      kAuthOptionEnterprise = 2,
    }
    public enum PdfEventType
    {
      kEventUnknown = 0,
      kEventDocWillSave = 1,
      kEventDocWillClose = 2,
      kEventDocDidOpen = 3,
      kEventDocDidSave = 4,
      kEventAnnotWillChange = 5,
      kEventAnnotDidChange = 6,
      kEventPageWillAddAnnot = 7,
      kEventPageWillRemoveAnnot = 8,
      kEventPageDidAddAnnot = 9,
      kEventPageDidRemoveAnnot = 10,
      kEventageContentsDidChange = 11,
    }
    public enum PdfSaveFlags
    {
      kSaveIncremental = 0,
      kSaveFull = 1,
    }
    public enum PdfDigSigValidState
    {
      kDigSigBlank = 0,
      kDigSigUnknown = 1,
      kDigSigInvalid = 2,
      kDigSigValid = 3,
      kDigSigDoubleChecked = 4,
      kDigSigValidStateEnumSize = 5,
    }
    public enum PdfAlignment
    {
      kAlignmentNone = 0,
      kAlignmentLeft = 1,
      kAlignmentRight = 2,
      kAlignmentJustify = 3,
      kAlignmentTop = 4,
      kAlignmentBottom = 5,
      kAlignmentCenter = 6,
    }
    public enum PdfRotate
    {
      kRotate0 = 0,
      kRotate90 = 90,
      kRotate180 = 180,
      kRotate270 = 270,
    }
    public enum PdfObjectType
    {
      kPdsUnknown = 0,
      kPdsBoolean = 1,
      kPdsNumber = 2,
      kPdsString = 3,
      kPdsName = 4,
      kPdsArray = 5,
      kPdsDictionary = 6,
      kPdsStream = 7,
      kPdsNull = 8,
      kPdsReference = 9,
    }
    public enum PdfElementType
    {
      kPdeUnknown = 0,
      kPdeText = 1,
      kPdeTextLine = 2,
      kPdeWord = 3,
      kPdeTextRun = 4,
      kPdeImage = 5,
      kPdeContainer = 6,
      kPdeList = 7,
      kPdeLine = 8,
      kPdeRect = 9,
      kPdeTable = 10,
      kPdeCell = 11,
      kPdeToc = 12,
      kPdeFormField = 13,
      kPdeHeader = 14,
      kPdeFooter = 15,
      kPdeTag = 16,
      kPdeColumn = 17,
      kPdeRow = 18,
    }
    public enum PdfLineCap
    {
      kPdfLineCapButt = 0,
      kPdfLineCapRound = 1,
      kPdfLineCapSquare = 2,
    }
    public enum PdfLineJoin
    {
      kPdfLineJoinMiter = 0,
      kPdfLineJoinRound = 1,
      kPdfLineJoinBevel = 2,
    }
    public enum PdfFillType
    {
      kFillTypeNone = 0,
      kFillTypeSolid = 1,
      kFillTypePattern = 2,
    }
    public enum PdfTextAlignment
    {
      kTextAlignmentNone = 0,
      kTextAlignmentLeft = 1,
      kTextAlignmentRight = 2,
      kTextAlignmentCenter = 3,
      kTextAlignmentJustify = 4,
    }
    public enum PdfAnnotSubtype
    {
      kAnnotUnknown = 0,
      kAnnotText = 1,
      kAnnotLink = 2,
      kAnnotFreeText = 3,
      kAnnotLine = 4,
      kAnnotSquare = 5,
      kAnnotCircle = 6,
      kAnnotPolygon = 7,
      kAnnotPolyLine = 8,
      kAnnotHighlight = 9,
      kAnnotUnderline = 10,
      kAnnotSquiggly = 11,
      kAnnotStrikeOut = 12,
      kAnnotStamp = 13,
      kAnnotCaret = 14,
      kAnnotInk = 15,
      kAnnotPopup = 16,
      kAnnotFileAttachment = 17,
      kAnnotSound = 18,
      kAnnotMovie = 19,
      kAnnotWidget = 20,
      kAnnotScreen = 21,
      kAnnotPrinterMark = 22,
      kAnnotTrapNet = 23,
      kAnnotWatermark = 24,
      kAnnot3D = 25,
      kAnnotRedact = 26,
    }
    public enum PdfBorderStyle
    {
      kBorderSolid = 0,
      kBorderDashed = 1,
      kBorderBeveled = 2,
      kBorderInset = 3,
      kBorderUnderline = 4,
    }
    public enum PdfFieldType
    {
      kFieldUnknown = 0,
      kFieldButton = 1,
      kFieldRadio = 2,
      kFieldCheck = 3,
      kFieldText = 4,
      kFieldCombo = 5,
      kFieldList = 6,
      kFieldSignature = 7,
    }
    public enum PdfActionEventType
    {
      kActionEventAnnotEnter = 0,
      kActionEventAnnotExit = 1,
      kActionEventAnnotMouseDown = 2,
      kActionEventAnnotMouseUp = 3,
      kActionEventAnnotFocus = 4,
      kActionEventAnnotBlur = 5,
      kActionEventAnnotPageOpen = 6,
      kActionEventAnnotPageClose = 7,
      kActionEventAnnotPageVisible = 8,
      kActionEventAnnotPageInvisible = 9,
      kActionEventPageOpen = 10,
      kActionEventPageClose = 11,
      kActionEventFieldKeystroke = 12,
      kActionEventFieldFormat = 13,
      kActionEventFieldValidate = 14,
      kActionEventFieldCalculate = 15,
      kActionEventDocWillClose = 16,
      kActionEventDocWillSave = 17,
      kActionEventDocDidSave = 18,
      kActionEventDocWillPrint = 19,
      kActionEventDocDidPrint = 20,
    }
    public enum PdfActionType
    {
      kActionUnknown = 0,
      kActionGoTo = 1,
      kActionGoToR = 2,
      kActionGoToE = 3,
      kActionLaunch = 4,
      kActionThread = 5,
      kActionURI = 6,
      kActionSound = 7,
      kActionMovie = 8,
      kActionHide = 9,
      kActionNamed = 10,
      kActionSubmitForm = 11,
      kActionResetForm = 12,
      kActionImportData = 13,
      kActionJavaScript = 14,
      kActionSetOCGState = 15,
      kActionRendition = 16,
      kActionTrans = 17,
      kActionGoTo3DView = 18,
    }
    public enum PdfRenderMode
    {
      kRenderElemNone = 0,
      kRenderElem = 1,
    }
    public enum PdfImageFormat
    {
      kImageFormatPng = 0,
      kImageFormatJpg = 1,
      kImageFormatBmp = 2,
      kImageFormatEmf = 3,
    }
    public enum PdfFontCharset
    {
      kFontAnsiCharset = 0,
      kFontDefaultCharset = 1,
      kFontSymbolCharset = 2,
      kFontUnknownCharset = 3,
      kFontMacintoshCharset = 77,
      kFontShiftJISCharset = 128,
      kFontHangeulCharset = 129,
      kFontKoreanCharset = 130,
      kFontGB2312Charset = 134,
      kFontCHineseBig5Charset = 136,
      kFontGreekCharset = 161,
      kFontTurkishCharset = 162,
      kFontVietnameseCharset = 163,
      kFontHebrewCharset = 177,
      kFontArabicCharset = 178,
      kFontArabicTCharset = 179,
      kFontArabicUCharset = 180,
      kFontHebrewUCharset = 181,
      kFontBalticCharset = 186,
      kFontRussianCharset = 204,
      kFontThaiCharset = 222,
      kFontEastEuropeCharset = 238,
    }
    public enum PdfPageRangeType
    {
      kAllPages = 0,
      kEvenPagesOnly = 1,
      kOddPagesOnly = 2,
    }
    public enum PdfFontType
    {
      kFontUnknownType = 0,
      kFontType1 = 1,
      kFontTrueType = 2,
      kFontType3 = 3,
      kFontCIDFont = 4,
    }
    public enum PdfFontFormat
    {
      kFontFormatTtf = 0,
      kFontFormatWoff = 1,
    }
    public enum PdfDestZoomType
    {
      kPdfZoomXYZ = 1,
      kPdfZoomFitPage = 2,
      kPdfZoomFitHorz = 3,
      kPdfZoomFitVert = 4,
      kPdfZoomFitRect = 5,
      kPdfZoomFitBbox = 6,
      kPdfZoomFitBHorz = 7,
      kPdfZoomFitBVert = 8,
    }
    public enum PdfDigSigType
    {
      kDigSigOpenSSL = 0,
      kDigSigCert = 1,
      kDigSigCustom = 2,
    }
    public enum PdfImageType
    {
      kImageFigure = 0,
      kImageImage = 1,
      kImagePath = 2,
      kImageRect = 3,
      kImageShading = 4,
      kImageTable = 5,
    }
    public enum PdfListType
    {
      kListUnordered = 0,
      kListOrdered = 1,
    }
    public enum PdfTextStyle
    {
      kTextNormal = 0,
      kTextH1 = 1,
      kTextH2 = 2,
      kTextH3 = 3,
      kTextH4 = 4,
      kTextH5 = 5,
      kTextH6 = 6,
      kTextH7 = 7,
      kTextH8 = 8,
      kTextNote = 9,
    }
    public enum PdfRegexType
    {
      kRegexHyphen = 0,
      kRegexBullet = 1,
      kRegexBulletFont = 2,
      kRegexBulletLine = 3,
      kRegexFilling = 4,
      kRegexToc = 5,
      kRegexNumber = 6,
      kRegexAllCaps = 7,
      kRegexFirstCap = 8,
      kRegexCurrency = 9,
      kRegexPercent = 10,
      kRegexTerminal = 11,
      kRegexTableCaption = 12,
      kRegexImageCaption = 13,
      kRegexChartCaption = 14,
      kRegexNoteCaption = 15,
      kRegexNumberedList = 16,
      kRegexNumberedSplit = 17,
      kRegexSentences = 18,
      kRegexAlphaNum = 19,
      kRegexColon = 20,
      kRegexPhoneNumber = 21,
      kRegexDate = 22,
      kRegexPageNumber = 23,
      kRegexLast = 24,
    }
    public enum PsFileMode
    {
      kPsWrite = 0,
      kPsReadOnly = 1,
      kPsTruncate = 2,
    }
    public enum PdfAlternateType
    {
      kAlternatePdf = 0,
      kAlternateHtml = 1,
    }
    public enum PdfMediaType
    {
      kCSSMediaTypeAll = 0,
      kCSSMediaTypePrint = 1,
      kCSSMediaTypeScreen = 2,
      kCSSMediaTypeSpeech = 3,
    }
    public enum PsImageDIBFormat
    {
      kImageDIBFormatArgb = 0x220,
    }
    public enum PsDataFormat
    {
      kDataFormatJson = 0,
      kDataFormatXml = 1,
    }
    public enum PdfStreamType
    {
      kFileStream = 0,
      kMemoryStream = 1,
      kProcStream = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfEventParamsInt
    {
      public int type;
      public IntPtr doc;
      public IntPtr page;
      public IntPtr annot;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfPageRangeParamsInt
    {
      public int start_page;
      public int end_page;
      public int page_range_spec;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfWatermarkParamsInt
    {
      public PdfPageRangeParamsInt page_range;
      public int order_top;
      public int h_align;
      public int v_align;
      public int percentage_vals;
      public double h_value;
      public double v_value;
      public double scale;
      public double rotation;
      public double opacity;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfPointInt
    {
      public double x;
      public double y;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfDevPointInt
    {
      public int x;
      public int y;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfRectInt
    {
      public double left;
      public double top;
      public double right;
      public double bottom;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfDevRectInt
    {
      public int left;
      public int top;
      public int right;
      public int bottom;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfQuadInt
    {
      public PdfPointInt tl;
      public PdfPointInt tr;
      public PdfPointInt bl;
      public PdfPointInt br;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfDevQuadInt
    {
      public PdfDevPointInt tl;
      public PdfDevPointInt tr;
      public PdfDevPointInt bl;
      public PdfDevPointInt br;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfMatrixInt
    {
      public double a;
      public double b;
      public double c;
      public double d;
      public double e;
      public double f;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfRGBInt
    {
      public int r;
      public int g;
      public int b;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfColorStateInt
    {
      public int fill_type;
      public int stroke_type;
      public PdfRGBInt fill_color;
      public PdfRGBInt stroke_color;
      public int fill_opacity;
      public int stroke_opacity;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfTextStateInt
    {
      public PdfColorStateInt color_state;
      public IntPtr font;
      public double font_size;
      public double char_spacing;
      public double word_spacing;
      public int flags;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfGraphicStateInt
    {
      public PdfColorStateInt color_state;
      public double line_width;
      public double miter_limit;
      public int line_cap;
      public int line_join;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfFontStateInt
    {
      public int type;
      public int flags;
      public PdfRectInt bbox;
      public int ascent;
      public int descent;
      public int italic;
      public int bold;
      public int fixed_width;
      public int vertical;
      public int embedded;
      public int height;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfPageRenderParamsInt
    {
      public IntPtr device;
      public IntPtr image;
      public PdfMatrixInt matrix;
      public PdfDevRectInt clip_rect;
      public int render_flags;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfAnnotAppearanceInt
    {
      public PdfRGBInt fill_color;
      public int fill_type;
      public PdfRGBInt border_color;
      public double border_width;
      public int border;
      public double opacity;
      public double font_size;
      public int text_align;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfBookmarkAppearanceInt
    {
      public PdfRGBInt color;
      public int italic;
      public int bold;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfWhitespaceParamsInt
    {
      public double width;
      public double height;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfFlattenAnnotsParamsInt
    {
      public PdfPageRangeParamsInt page_range;
      public int flags;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfMediaQueryParamsInt
    {
      public int type;
      public int min_width;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfImageParamsInt
    {
      public int format;
      public int quality;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfAccessibleParamsInt
    {
      public int accept_tags;
      public int embed_fonts;
      public int subset_fonts;
    }
    public struct PdfEventParams
    {
      public PdfEventType type;
      public PdfDoc doc;
      public PdfPage page;
      public PdfAnnot annot;
      public PdfEventParams(PdfEventType _type, PdfDoc _doc, PdfPage _page, PdfAnnot _annot)
      {
        type = _type;
        doc = _doc;
        page = _page;
        annot = _annot;
      }
      internal PdfEventParamsInt GetIntStruct()
      {
        PdfEventParamsInt result = new PdfEventParamsInt();
        result.type = (int)type;
        result.doc = (IntPtr)doc.m_obj;
        result.page = (IntPtr)page.m_obj;
        result.annot = (IntPtr)annot.m_obj;
        return result;
      }
      internal void SetIntStruct(PdfEventParamsInt inStruct)
      {
        type = (PdfEventType)inStruct.type;
        doc = new PdfDoc((IntPtr)inStruct.doc);
        page = new PdfPage((IntPtr)inStruct.page);
        annot = new PdfAnnot((IntPtr)inStruct.annot);
      }
    }
    public struct PdfPageRangeParams
    {
      public int start_page;
      public int end_page;
      public PdfPageRangeType page_range_spec;
      public PdfPageRangeParams(int _start_page, int _end_page, PdfPageRangeType _page_range_spec)
      {
        start_page = _start_page;
        end_page = _end_page;
        page_range_spec = _page_range_spec;
      }
      internal PdfPageRangeParamsInt GetIntStruct()
      {
        PdfPageRangeParamsInt result = new PdfPageRangeParamsInt();
        result.start_page = start_page;
        result.end_page = end_page;
        result.page_range_spec = (int)page_range_spec;
        return result;
      }
      internal void SetIntStruct(PdfPageRangeParamsInt inStruct)
      {
        start_page = inStruct.start_page;
        end_page = inStruct.end_page;
        page_range_spec = (PdfPageRangeType)inStruct.page_range_spec;
      }
    }
    public struct PdfWatermarkParams
    {
      public PdfPageRangeParams page_range;
      public int order_top;
      public PdfAlignment h_align;
      public PdfAlignment v_align;
      public int percentage_vals;
      public double h_value;
      public double v_value;
      public double scale;
      public double rotation;
      public double opacity;
      public PdfWatermarkParams(PdfPageRangeParams _page_range, int _order_top, PdfAlignment _h_align, PdfAlignment _v_align, int _percentage_vals, double _h_value, double _v_value, double _scale, double _rotation, double _opacity)
      {
        page_range = _page_range;
        order_top = _order_top;
        h_align = _h_align;
        v_align = _v_align;
        percentage_vals = _percentage_vals;
        h_value = _h_value;
        v_value = _v_value;
        scale = _scale;
        rotation = _rotation;
        opacity = _opacity;
      }
      internal PdfWatermarkParamsInt GetIntStruct()
      {
        PdfWatermarkParamsInt result = new PdfWatermarkParamsInt();
        result.page_range = (PdfPageRangeParamsInt)page_range.GetIntStruct();
        result.order_top = order_top;
        result.h_align = (int)h_align;
        result.v_align = (int)v_align;
        result.percentage_vals = percentage_vals;
        result.h_value = h_value;
        result.v_value = v_value;
        result.scale = scale;
        result.rotation = rotation;
        result.opacity = opacity;
        return result;
      }
      internal void SetIntStruct(PdfWatermarkParamsInt inStruct)
      {
        page_range = new PdfPageRangeParams();
        page_range.SetIntStruct(inStruct.page_range);
        order_top = inStruct.order_top;
        h_align = (PdfAlignment)inStruct.h_align;
        v_align = (PdfAlignment)inStruct.v_align;
        percentage_vals = inStruct.percentage_vals;
        h_value = inStruct.h_value;
        v_value = inStruct.v_value;
        scale = inStruct.scale;
        rotation = inStruct.rotation;
        opacity = inStruct.opacity;
      }
    }
    public struct PdfPoint
    {
      public double x;
      public double y;
      public PdfPoint(double _x, double _y)
      {
        x = _x;
        y = _y;
      }
      internal PdfPointInt GetIntStruct()
      {
        PdfPointInt result = new PdfPointInt();
        result.x = x;
        result.y = y;
        return result;
      }
      internal void SetIntStruct(PdfPointInt inStruct)
      {
        x = inStruct.x;
        y = inStruct.y;
      }
    }
    public struct PdfDevPoint
    {
      public int x;
      public int y;
      public PdfDevPoint(int _x, int _y)
      {
        x = _x;
        y = _y;
      }
      internal PdfDevPointInt GetIntStruct()
      {
        PdfDevPointInt result = new PdfDevPointInt();
        result.x = x;
        result.y = y;
        return result;
      }
      internal void SetIntStruct(PdfDevPointInt inStruct)
      {
        x = inStruct.x;
        y = inStruct.y;
      }
    }
    public struct PdfRect
    {
      public double left;
      public double top;
      public double right;
      public double bottom;
      public PdfRect(double _left, double _top, double _right, double _bottom)
      {
        left = _left;
        top = _top;
        right = _right;
        bottom = _bottom;
      }
      internal PdfRectInt GetIntStruct()
      {
        PdfRectInt result = new PdfRectInt();
        result.left = left;
        result.top = top;
        result.right = right;
        result.bottom = bottom;
        return result;
      }
      internal void SetIntStruct(PdfRectInt inStruct)
      {
        left = inStruct.left;
        top = inStruct.top;
        right = inStruct.right;
        bottom = inStruct.bottom;
      }
    }
    public struct PdfDevRect
    {
      public int left;
      public int top;
      public int right;
      public int bottom;
      public PdfDevRect(int _left, int _top, int _right, int _bottom)
      {
        left = _left;
        top = _top;
        right = _right;
        bottom = _bottom;
      }
      internal PdfDevRectInt GetIntStruct()
      {
        PdfDevRectInt result = new PdfDevRectInt();
        result.left = left;
        result.top = top;
        result.right = right;
        result.bottom = bottom;
        return result;
      }
      internal void SetIntStruct(PdfDevRectInt inStruct)
      {
        left = inStruct.left;
        top = inStruct.top;
        right = inStruct.right;
        bottom = inStruct.bottom;
      }
    }
    public struct PdfQuad
    {
      public PdfPoint tl;
      public PdfPoint tr;
      public PdfPoint bl;
      public PdfPoint br;
      public PdfQuad(PdfPoint _tl, PdfPoint _tr, PdfPoint _bl, PdfPoint _br)
      {
        tl = _tl;
        tr = _tr;
        bl = _bl;
        br = _br;
      }
      internal PdfQuadInt GetIntStruct()
      {
        PdfQuadInt result = new PdfQuadInt();
        result.tl = (PdfPointInt)tl.GetIntStruct();
        result.tr = (PdfPointInt)tr.GetIntStruct();
        result.bl = (PdfPointInt)bl.GetIntStruct();
        result.br = (PdfPointInt)br.GetIntStruct();
        return result;
      }
      internal void SetIntStruct(PdfQuadInt inStruct)
      {
        tl = new PdfPoint();
        tl.SetIntStruct(inStruct.tl);
        tr = new PdfPoint();
        tr.SetIntStruct(inStruct.tr);
        bl = new PdfPoint();
        bl.SetIntStruct(inStruct.bl);
        br = new PdfPoint();
        br.SetIntStruct(inStruct.br);
      }
    }
    public struct PdfDevQuad
    {
      public PdfDevPoint tl;
      public PdfDevPoint tr;
      public PdfDevPoint bl;
      public PdfDevPoint br;
      public PdfDevQuad(PdfDevPoint _tl, PdfDevPoint _tr, PdfDevPoint _bl, PdfDevPoint _br)
      {
        tl = _tl;
        tr = _tr;
        bl = _bl;
        br = _br;
      }
      internal PdfDevQuadInt GetIntStruct()
      {
        PdfDevQuadInt result = new PdfDevQuadInt();
        result.tl = (PdfDevPointInt)tl.GetIntStruct();
        result.tr = (PdfDevPointInt)tr.GetIntStruct();
        result.bl = (PdfDevPointInt)bl.GetIntStruct();
        result.br = (PdfDevPointInt)br.GetIntStruct();
        return result;
      }
      internal void SetIntStruct(PdfDevQuadInt inStruct)
      {
        tl = new PdfDevPoint();
        tl.SetIntStruct(inStruct.tl);
        tr = new PdfDevPoint();
        tr.SetIntStruct(inStruct.tr);
        bl = new PdfDevPoint();
        bl.SetIntStruct(inStruct.bl);
        br = new PdfDevPoint();
        br.SetIntStruct(inStruct.br);
      }
    }
    public struct PdfMatrix
    {
      public double a;
      public double b;
      public double c;
      public double d;
      public double e;
      public double f;
      public PdfMatrix(double _a, double _b, double _c, double _d, double _e, double _f)
      {
        a = _a;
        b = _b;
        c = _c;
        d = _d;
        e = _e;
        f = _f;
      }
      internal PdfMatrixInt GetIntStruct()
      {
        PdfMatrixInt result = new PdfMatrixInt();
        result.a = a;
        result.b = b;
        result.c = c;
        result.d = d;
        result.e = e;
        result.f = f;
        return result;
      }
      internal void SetIntStruct(PdfMatrixInt inStruct)
      {
        a = inStruct.a;
        b = inStruct.b;
        c = inStruct.c;
        d = inStruct.d;
        e = inStruct.e;
        f = inStruct.f;
      }
    }
    public struct PdfRGB
    {
      public int r;
      public int g;
      public int b;
      public PdfRGB(int _r, int _g, int _b)
      {
        r = _r;
        g = _g;
        b = _b;
      }
      internal PdfRGBInt GetIntStruct()
      {
        PdfRGBInt result = new PdfRGBInt();
        result.r = r;
        result.g = g;
        result.b = b;
        return result;
      }
      internal void SetIntStruct(PdfRGBInt inStruct)
      {
        r = inStruct.r;
        g = inStruct.g;
        b = inStruct.b;
      }
    }
    public struct PdfColorState
    {
      public PdfFillType fill_type;
      public PdfFillType stroke_type;
      public PdfRGB fill_color;
      public PdfRGB stroke_color;
      public int fill_opacity;
      public int stroke_opacity;
      public PdfColorState(PdfFillType _fill_type, PdfFillType _stroke_type, PdfRGB _fill_color, PdfRGB _stroke_color, int _fill_opacity, int _stroke_opacity)
      {
        fill_type = _fill_type;
        stroke_type = _stroke_type;
        fill_color = _fill_color;
        stroke_color = _stroke_color;
        fill_opacity = _fill_opacity;
        stroke_opacity = _stroke_opacity;
      }
      internal PdfColorStateInt GetIntStruct()
      {
        PdfColorStateInt result = new PdfColorStateInt();
        result.fill_type = (int)fill_type;
        result.stroke_type = (int)stroke_type;
        result.fill_color = (PdfRGBInt)fill_color.GetIntStruct();
        result.stroke_color = (PdfRGBInt)stroke_color.GetIntStruct();
        result.fill_opacity = fill_opacity;
        result.stroke_opacity = stroke_opacity;
        return result;
      }
      internal void SetIntStruct(PdfColorStateInt inStruct)
      {
        fill_type = (PdfFillType)inStruct.fill_type;
        stroke_type = (PdfFillType)inStruct.stroke_type;
        fill_color = new PdfRGB();
        fill_color.SetIntStruct(inStruct.fill_color);
        stroke_color = new PdfRGB();
        stroke_color.SetIntStruct(inStruct.stroke_color);
        fill_opacity = inStruct.fill_opacity;
        stroke_opacity = inStruct.stroke_opacity;
      }
    }
    public struct PdfTextState
    {
      public PdfColorState color_state;
      public PdfFont font;
      public double font_size;
      public double char_spacing;
      public double word_spacing;
      public int flags;
      public PdfTextState(PdfColorState _color_state, PdfFont _font, double _font_size, double _char_spacing, double _word_spacing, int _flags)
      {
        color_state = _color_state;
        font = _font;
        font_size = _font_size;
        char_spacing = _char_spacing;
        word_spacing = _word_spacing;
        flags = _flags;
      }
      internal PdfTextStateInt GetIntStruct()
      {
        PdfTextStateInt result = new PdfTextStateInt();
        result.color_state = (PdfColorStateInt)color_state.GetIntStruct();
        result.font = (IntPtr)font.m_obj;
        result.font_size = font_size;
        result.char_spacing = char_spacing;
        result.word_spacing = word_spacing;
        result.flags = flags;
        return result;
      }
      internal void SetIntStruct(PdfTextStateInt inStruct)
      {
        color_state = new PdfColorState();
        color_state.SetIntStruct(inStruct.color_state);
        font = new PdfFont((IntPtr)inStruct.font);
        font_size = inStruct.font_size;
        char_spacing = inStruct.char_spacing;
        word_spacing = inStruct.word_spacing;
        flags = inStruct.flags;
      }
    }
    public struct PdfGraphicState
    {
      public PdfColorState color_state;
      public double line_width;
      public double miter_limit;
      public PdfLineCap line_cap;
      public PdfLineJoin line_join;
      public PdfGraphicState(PdfColorState _color_state, double _line_width, double _miter_limit, PdfLineCap _line_cap, PdfLineJoin _line_join)
      {
        color_state = _color_state;
        line_width = _line_width;
        miter_limit = _miter_limit;
        line_cap = _line_cap;
        line_join = _line_join;
      }
      internal PdfGraphicStateInt GetIntStruct()
      {
        PdfGraphicStateInt result = new PdfGraphicStateInt();
        result.color_state = (PdfColorStateInt)color_state.GetIntStruct();
        result.line_width = line_width;
        result.miter_limit = miter_limit;
        result.line_cap = (int)line_cap;
        result.line_join = (int)line_join;
        return result;
      }
      internal void SetIntStruct(PdfGraphicStateInt inStruct)
      {
        color_state = new PdfColorState();
        color_state.SetIntStruct(inStruct.color_state);
        line_width = inStruct.line_width;
        miter_limit = inStruct.miter_limit;
        line_cap = (PdfLineCap)inStruct.line_cap;
        line_join = (PdfLineJoin)inStruct.line_join;
      }
    }
    public struct PdfFontState
    {
      public PdfFontType type;
      public int flags;
      public PdfRect bbox;
      public int ascent;
      public int descent;
      public int italic;
      public int bold;
      public int fixed_width;
      public int vertical;
      public int embedded;
      public int height;
      public PdfFontState(PdfFontType _type, int _flags, PdfRect _bbox, int _ascent, int _descent, int _italic, int _bold, int _fixed_width, int _vertical, int _embedded, int _height)
      {
        type = _type;
        flags = _flags;
        bbox = _bbox;
        ascent = _ascent;
        descent = _descent;
        italic = _italic;
        bold = _bold;
        fixed_width = _fixed_width;
        vertical = _vertical;
        embedded = _embedded;
        height = _height;
      }
      internal PdfFontStateInt GetIntStruct()
      {
        PdfFontStateInt result = new PdfFontStateInt();
        result.type = (int)type;
        result.flags = flags;
        result.bbox = (PdfRectInt)bbox.GetIntStruct();
        result.ascent = ascent;
        result.descent = descent;
        result.italic = italic;
        result.bold = bold;
        result.fixed_width = fixed_width;
        result.vertical = vertical;
        result.embedded = embedded;
        result.height = height;
        return result;
      }
      internal void SetIntStruct(PdfFontStateInt inStruct)
      {
        type = (PdfFontType)inStruct.type;
        flags = inStruct.flags;
        bbox = new PdfRect();
        bbox.SetIntStruct(inStruct.bbox);
        ascent = inStruct.ascent;
        descent = inStruct.descent;
        italic = inStruct.italic;
        bold = inStruct.bold;
        fixed_width = inStruct.fixed_width;
        vertical = inStruct.vertical;
        embedded = inStruct.embedded;
        height = inStruct.height;
      }
    }
    public struct PdfPageRenderParams
    {
      public IntPtr device;
      public PsImage image;
      public PdfMatrix matrix;
      public PdfDevRect clip_rect;
      public int render_flags;
      public PdfPageRenderParams(IntPtr _device, PsImage _image, PdfMatrix _matrix, PdfDevRect _clip_rect, int _render_flags)
      {
        device = _device;
        image = _image;
        matrix = _matrix;
        clip_rect = _clip_rect;
        render_flags = _render_flags;
      }
      internal PdfPageRenderParamsInt GetIntStruct()
      {
        PdfPageRenderParamsInt result = new PdfPageRenderParamsInt();
        result.device = device;
        result.image = (IntPtr)image.m_obj;
        result.matrix = (PdfMatrixInt)matrix.GetIntStruct();
        result.clip_rect = (PdfDevRectInt)clip_rect.GetIntStruct();
        result.render_flags = render_flags;
        return result;
      }
      internal void SetIntStruct(PdfPageRenderParamsInt inStruct)
      {
        device = inStruct.device;
        image = new PsImage((IntPtr)inStruct.image);
        matrix = new PdfMatrix();
        matrix.SetIntStruct(inStruct.matrix);
        clip_rect = new PdfDevRect();
        clip_rect.SetIntStruct(inStruct.clip_rect);
        render_flags = inStruct.render_flags;
      }
    }
    public struct PdfAnnotAppearance
    {
      public PdfRGB fill_color;
      public PdfFillType fill_type;
      public PdfRGB border_color;
      public double border_width;
      public PdfBorderStyle border;
      public double opacity;
      public double font_size;
      public PdfTextAlignment text_align;
      public PdfAnnotAppearance(PdfRGB _fill_color, PdfFillType _fill_type, PdfRGB _border_color, double _border_width, PdfBorderStyle _border, double _opacity, double _font_size, PdfTextAlignment _text_align)
      {
        fill_color = _fill_color;
        fill_type = _fill_type;
        border_color = _border_color;
        border_width = _border_width;
        border = _border;
        opacity = _opacity;
        font_size = _font_size;
        text_align = _text_align;
      }
      internal PdfAnnotAppearanceInt GetIntStruct()
      {
        PdfAnnotAppearanceInt result = new PdfAnnotAppearanceInt();
        result.fill_color = (PdfRGBInt)fill_color.GetIntStruct();
        result.fill_type = (int)fill_type;
        result.border_color = (PdfRGBInt)border_color.GetIntStruct();
        result.border_width = border_width;
        result.border = (int)border;
        result.opacity = opacity;
        result.font_size = font_size;
        result.text_align = (int)text_align;
        return result;
      }
      internal void SetIntStruct(PdfAnnotAppearanceInt inStruct)
      {
        fill_color = new PdfRGB();
        fill_color.SetIntStruct(inStruct.fill_color);
        fill_type = (PdfFillType)inStruct.fill_type;
        border_color = new PdfRGB();
        border_color.SetIntStruct(inStruct.border_color);
        border_width = inStruct.border_width;
        border = (PdfBorderStyle)inStruct.border;
        opacity = inStruct.opacity;
        font_size = inStruct.font_size;
        text_align = (PdfTextAlignment)inStruct.text_align;
      }
    }
    public struct PdfBookmarkAppearance
    {
      public PdfRGB color;
      public int italic;
      public int bold;
      public PdfBookmarkAppearance(PdfRGB _color, int _italic, int _bold)
      {
        color = _color;
        italic = _italic;
        bold = _bold;
      }
      internal PdfBookmarkAppearanceInt GetIntStruct()
      {
        PdfBookmarkAppearanceInt result = new PdfBookmarkAppearanceInt();
        result.color = (PdfRGBInt)color.GetIntStruct();
        result.italic = italic;
        result.bold = bold;
        return result;
      }
      internal void SetIntStruct(PdfBookmarkAppearanceInt inStruct)
      {
        color = new PdfRGB();
        color.SetIntStruct(inStruct.color);
        italic = inStruct.italic;
        bold = inStruct.bold;
      }
    }
    public struct PdfWhitespaceParams
    {
      public double width;
      public double height;
      public PdfWhitespaceParams(double _width, double _height)
      {
        width = _width;
        height = _height;
      }
      internal PdfWhitespaceParamsInt GetIntStruct()
      {
        PdfWhitespaceParamsInt result = new PdfWhitespaceParamsInt();
        result.width = width;
        result.height = height;
        return result;
      }
      internal void SetIntStruct(PdfWhitespaceParamsInt inStruct)
      {
        width = inStruct.width;
        height = inStruct.height;
      }
    }
    public struct PdfFlattenAnnotsParams
    {
      public PdfPageRangeParams page_range;
      public int flags;
      public PdfFlattenAnnotsParams(PdfPageRangeParams _page_range, int _flags)
      {
        page_range = _page_range;
        flags = _flags;
      }
      internal PdfFlattenAnnotsParamsInt GetIntStruct()
      {
        PdfFlattenAnnotsParamsInt result = new PdfFlattenAnnotsParamsInt();
        result.page_range = (PdfPageRangeParamsInt)page_range.GetIntStruct();
        result.flags = flags;
        return result;
      }
      internal void SetIntStruct(PdfFlattenAnnotsParamsInt inStruct)
      {
        page_range = new PdfPageRangeParams();
        page_range.SetIntStruct(inStruct.page_range);
        flags = inStruct.flags;
      }
    }
    public struct PdfMediaQueryParams
    {
      public PdfMediaType type;
      public int min_width;
      public PdfMediaQueryParams(PdfMediaType _type, int _min_width)
      {
        type = _type;
        min_width = _min_width;
      }
      internal PdfMediaQueryParamsInt GetIntStruct()
      {
        PdfMediaQueryParamsInt result = new PdfMediaQueryParamsInt();
        result.type = (int)type;
        result.min_width = min_width;
        return result;
      }
      internal void SetIntStruct(PdfMediaQueryParamsInt inStruct)
      {
        type = (PdfMediaType)inStruct.type;
        min_width = inStruct.min_width;
      }
    }
    public struct PdfImageParams
    {
      public PdfImageFormat format;
      public int quality;
      public PdfImageParams(PdfImageFormat _format, int _quality)
      {
        format = _format;
        quality = _quality;
      }
      internal PdfImageParamsInt GetIntStruct()
      {
        PdfImageParamsInt result = new PdfImageParamsInt();
        result.format = (int)format;
        result.quality = quality;
        return result;
      }
      internal void SetIntStruct(PdfImageParamsInt inStruct)
      {
        format = (PdfImageFormat)inStruct.format;
        quality = inStruct.quality;
      }
    }
    public struct PdfAccessibleParams
    {
      public int accept_tags;
      public int embed_fonts;
      public int subset_fonts;
      public PdfAccessibleParams(int _accept_tags, int _embed_fonts, int _subset_fonts)
      {
        accept_tags = _accept_tags;
        embed_fonts = _embed_fonts;
        subset_fonts = _subset_fonts;
      }
      internal PdfAccessibleParamsInt GetIntStruct()
      {
        PdfAccessibleParamsInt result = new PdfAccessibleParamsInt();
        result.accept_tags = accept_tags;
        result.embed_fonts = embed_fonts;
        result.subset_fonts = subset_fonts;
        return result;
      }
      internal void SetIntStruct(PdfAccessibleParamsInt inStruct)
      {
        accept_tags = inStruct.accept_tags;
        embed_fonts = inStruct.embed_fonts;
        subset_fonts = inStruct.subset_fonts;
      }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PdfCancelProc(IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PdfEventProc(PdfEventParams _event, IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PsStreamProc(string _buffer, int _offset, int _size, IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PsStreamDestroyProc(IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PsStreamGetSizeProc(IntPtr _data);

    public class PdsObject : PdfixBase
    {
      public PdsObject(IntPtr obj) : base(obj) { }
      public PdfObjectType GetType_()
      {
        CheckBaseObj();
        PdfObjectType ret = PdsObjectGetType(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfObjectType PdsObjectGetType(IntPtr obj);
    }
    public class PdsBoolean : PdsObject    {
      public PdsBoolean(IntPtr obj) : base(obj) { }
      public bool GetValue()
      {
        CheckBaseObj();
        bool ret = PdsBooleanGetValue(m_obj);
        return ret;
      }
      public bool SetValue(bool _value)
      {
        CheckBaseObj();
        bool ret = PdsBooleanSetValue(m_obj, _value);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdsBooleanGetValue(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdsBooleanSetValue(IntPtr obj, bool _value);
    }
    public class PdsNumber : PdsObject    {
      public PdsNumber(IntPtr obj) : base(obj) { }
      public int GetIntegerValue()
      {
        CheckBaseObj();
        int ret = PdsNumberGetIntegerValue(m_obj);
        return ret;
      }
      public double GetNumberValue()
      {
        CheckBaseObj();
        double ret = PdsNumberGetNumberValue(m_obj);
        return ret;
      }
      public bool SetIntegerValue(int _value)
      {
        CheckBaseObj();
        bool ret = PdsNumberSetIntegerValue(m_obj, _value);
        return ret;
      }
      public bool SetNumberValue(double _value)
      {
        CheckBaseObj();
        bool ret = PdsNumberSetNumberValue(m_obj, _value);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsNumberGetIntegerValue(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdsNumberGetNumberValue(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdsNumberSetIntegerValue(IntPtr obj, int _value);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdsNumberSetNumberValue(IntPtr obj, double _value);
    }
    public class PdsString : PdsObject    {
      public PdsString(IntPtr obj) : base(obj) { }
      public string GetValue()
      {
        CheckBaseObj();
        int _buffer_sz = PdsStringGetValue(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStringGetValue(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetValue(string _buffer)
      {
        CheckBaseObj();
        bool ret = PdsStringSetValue(m_obj, _buffer);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStringGetValue(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdsStringSetValue(IntPtr obj, string _buffer);
    }
    public class PdsName : PdsObject    {
      public PdsName(IntPtr obj) : base(obj) { }

    }
    public class PdsArray : PdsObject    {
      public PdsArray(IntPtr obj) : base(obj) { }

    }
    public class PdsDictionary : PdsObject    {
      public PdsDictionary(IntPtr obj) : base(obj) { }
      public bool KnownObject(string _key)
      {
        CheckBaseObj();
        bool ret = PdsDictionaryKnownObject(m_obj, _key);
        return ret;
      }
      public PdsObject GetObject(string _key)
      {
        CheckBaseObj();
        IntPtr ret = PdsDictionaryGetObject(m_obj, _key);
        if (ret != IntPtr.Zero)
        {
          return new PdsObject(ret);
        }
        return null;
      }
      public bool SetObject(string _key, PdsObject _value)
      {
        CheckBaseObj();
        bool ret = PdsDictionarySetObject(m_obj, _key, _value.m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdsDictionaryKnownObject(IntPtr obj, string _key);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGetObject(IntPtr obj, string _key);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdsDictionarySetObject(IntPtr obj, string _key, IntPtr _value);
    }
    public class PdsStream : PdsObject    {
      public PdsStream(IntPtr obj) : base(obj) { }

    }
    public class PdsNull : PdsObject    {
      public PdsNull(IntPtr obj) : base(obj) { }

    }
    public class PdsReference : PdsObject    {
      public PdsReference(IntPtr obj) : base(obj) { }

    }
    public class PdeElement : PdfixBase
    {
      public PdeElement(IntPtr obj) : base(obj) { }
      public PdfElementType GetType_()
      {
        CheckBaseObj();
        PdfElementType ret = PdeElementGetType(m_obj);
        return ret;
      }
      public PdfRect GetBBox()
      {
        CheckBaseObj();
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        PdeElementGetBBox(m_obj, _bbox_ptr);
        PdfRectInt _bboxInt = (PdfRectInt)Marshal.PtrToStructure(_bbox_ptr, typeof(PdfRectInt));
        PdfRect _bbox = new PdfRect();
        _bbox.SetIntStruct(_bboxInt);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
        return _bbox;
      }
      public int GetId()
      {
        CheckBaseObj();
        int ret = PdeElementGetId(m_obj);
        return ret;
      }
      public PdfGraphicState GetGraphicState()
      {
        CheckBaseObj();
        IntPtr _g_state_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfGraphicStateInt)));
        PdeElementGetGraphicState(m_obj, _g_state_ptr);
        PdfGraphicStateInt _g_stateInt = (PdfGraphicStateInt)Marshal.PtrToStructure(_g_state_ptr, typeof(PdfGraphicStateInt));
        PdfGraphicState _g_state = new PdfGraphicState();
        _g_state.SetIntStruct(_g_stateInt);
        Marshal.FreeHGlobal(_g_state_ptr);
        _g_state_ptr = IntPtr.Zero;
        return _g_state;
      }
      public int GetNumChildren()
      {
        CheckBaseObj();
        int ret = PdeElementGetNumChildren(m_obj);
        return ret;
      }
      public PdeElement GetChild(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdeElementGetChild(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdeElementGetType(ret))
          {
            case PdfElementType.kPdeText: return new PdeText(ret);
            case PdfElementType.kPdeTextLine: return new PdeTextLine(ret);
            case PdfElementType.kPdeWord: return new PdeWord(ret);
            case PdfElementType.kPdeImage: return new PdeImage(ret);
            case PdfElementType.kPdeContainer: return new PdeContainer(ret);
            case PdfElementType.kPdeList: return new PdeList(ret);
            case PdfElementType.kPdeLine: return new PdeLine(ret);
            case PdfElementType.kPdeRect: return new PdeRect(ret);
            case PdfElementType.kPdeHeader: return new PdeHeader(ret);
            case PdfElementType.kPdeFooter: return new PdeFooter(ret);
            case PdfElementType.kPdeTable: return new PdeTable(ret);
            case PdfElementType.kPdeCell: return new PdeCell(ret);
            case PdfElementType.kPdeFormField: return new PdeFormField(ret);
            case PdfElementType.kPdeTag: return new PdeTag(ret);
            case PdfElementType.kPdeToc: return new PdeToc(ret);
            default: return new PdeElement(ret);
          }
        }
        return null;
      }
      public PdfAlignment GetAlignment()
      {
        CheckBaseObj();
        PdfAlignment ret = PdeElementGetAlignment(m_obj);
        return ret;
      }
      public double GetAngle()
      {
        CheckBaseObj();
        double ret = PdeElementGetAngle(m_obj);
        return ret;
      }
      public void SetRenderMode(PdfRenderMode _mode)
      {
        CheckBaseObj();
        PdeElementSetRenderMode(m_obj, (int)_mode);
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfElementType PdeElementGetType(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementGetBBox(IntPtr obj, IntPtr _bbox);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetId(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementGetGraphicState(IntPtr obj, IntPtr _g_state);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetNumChildren(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeElementGetChild(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeElementGetAlignment(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeElementGetAngle(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementSetRenderMode(IntPtr obj, int _mode);
    }
    public class PdeContainer : PdeElement    {
      public PdeContainer(IntPtr obj) : base(obj) { }

    }
    public class PdeList : PdeElement    {
      public PdeList(IntPtr obj) : base(obj) { }

    }
    public class PdeToc : PdeElement    {
      public PdeToc(IntPtr obj) : base(obj) { }

    }
    public class PdeTag : PdeElement    {
      public PdeTag(IntPtr obj) : base(obj) { }
      public PdfStructElement GetStructElement()
      {
        CheckBaseObj();
        IntPtr ret = PdeTagGetStructElement(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfStructElement(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTagGetStructElement(IntPtr obj);
    }
    public class PdeAnnot : PdeElement    {
      public PdeAnnot(IntPtr obj) : base(obj) { }
      public PdfAnnot GetAnnot()
      {
        CheckBaseObj();
        IntPtr ret = PdeAnnotGetAnnot(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfAnnot(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeAnnotGetAnnot(IntPtr obj);
    }
    public class PdeFormField : PdeAnnot    {
      public PdeFormField(IntPtr obj) : base(obj) { }

    }
    public class PdeImage : PdeContainer    {
      public PdeImage(IntPtr obj) : base(obj) { }
      public PdfImageType GetImageType()
      {
        CheckBaseObj();
        PdfImageType ret = PdeImageGetImageType(m_obj);
        return ret;
      }
      public PdeElement GetCaption()
      {
        CheckBaseObj();
        IntPtr ret = PdeImageGetCaption(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdeElement(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfImageType PdeImageGetImageType(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeImageGetCaption(IntPtr obj);
    }
    public class PdeLine : PdeElement    {
      public PdeLine(IntPtr obj) : base(obj) { }

    }
    public class PdeRect : PdeContainer    {
      public PdeRect(IntPtr obj) : base(obj) { }

    }
    public class PdeHeader : PdeContainer    {
      public PdeHeader(IntPtr obj) : base(obj) { }

    }
    public class PdeFooter : PdeContainer    {
      public PdeFooter(IntPtr obj) : base(obj) { }

    }
    public class PdeCell : PdeContainer    {
      public PdeCell(IntPtr obj) : base(obj) { }
      public int GetRowSpan()
      {
        CheckBaseObj();
        int ret = PdeCellGetRowSpan(m_obj);
        return ret;
      }
      public int GetColSpan()
      {
        CheckBaseObj();
        int ret = PdeCellGetColSpan(m_obj);
        return ret;
      }
      public bool HasBorderGraphicState(int _index)
      {
        CheckBaseObj();
        bool ret = PdeCellHasBorderGraphicState(m_obj, _index);
        return ret;
      }
      public PdeCell GetSpanCell()
      {
        CheckBaseObj();
        IntPtr ret = PdeCellGetSpanCell(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdeCell(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeCellGetRowSpan(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeCellGetColSpan(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdeCellHasBorderGraphicState(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeCellGetSpanCell(IntPtr obj);
    }
    public class PdeTable : PdeContainer    {
      public PdeTable(IntPtr obj) : base(obj) { }
      public int GetNumRows()
      {
        CheckBaseObj();
        int ret = PdeTableGetNumRows(m_obj);
        return ret;
      }
      public int GetNumCols()
      {
        CheckBaseObj();
        int ret = PdeTableGetNumCols(m_obj);
        return ret;
      }
      public PdeCell GetCell(int _row, int _col)
      {
        CheckBaseObj();
        IntPtr ret = PdeTableGetCell(m_obj, _row, _col);
        if (ret != IntPtr.Zero)
        {
          return new PdeCell(ret);
        }
        return null;
      }
      public PdfAlignment GetRowAlignment(int _row)
      {
        CheckBaseObj();
        PdfAlignment ret = PdeTableGetRowAlignment(m_obj, _row);
        return ret;
      }
      public PdfAlignment GetColAlignment(int _col)
      {
        CheckBaseObj();
        PdfAlignment ret = PdeTableGetColAlignment(m_obj, _col);
        return ret;
      }
      public PdeElement GetCaption()
      {
        CheckBaseObj();
        IntPtr ret = PdeTableGetCaption(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdeElement(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetNumRows(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetNumCols(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTableGetCell(IntPtr obj, int _row, int _col);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeTableGetRowAlignment(IntPtr obj, int _row);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeTableGetColAlignment(IntPtr obj, int _col);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTableGetCaption(IntPtr obj);
    }
    public class PdeWord : PdeElement    {
      public PdeWord(IntPtr obj) : base(obj) { }
      public string GetText()
      {
        CheckBaseObj();
        int _buffer_sz = PdeWordGetText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdeWordGetText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool HasTextState()
      {
        CheckBaseObj();
        bool ret = PdeWordHasTextState(m_obj);
        return ret;
      }
      public PdfTextState GetTextState()
      {
        CheckBaseObj();
        IntPtr _text_state_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfTextStateInt)));
        PdeWordGetTextState(m_obj, _text_state_ptr);
        PdfTextStateInt _text_stateInt = (PdfTextStateInt)Marshal.PtrToStructure(_text_state_ptr, typeof(PdfTextStateInt));
        PdfTextState _text_state = new PdfTextState();
        _text_state.SetIntStruct(_text_stateInt);
        Marshal.FreeHGlobal(_text_state_ptr);
        _text_state_ptr = IntPtr.Zero;
        return _text_state;
      }
      public int GetNumChars()
      {
        CheckBaseObj();
        int ret = PdeWordGetNumChars(m_obj);
        return ret;
      }
      public string GetCharText(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdeWordGetCharText(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdeWordGetCharText(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdfTextState GetCharTextState(int _index)
      {
        CheckBaseObj();
        IntPtr _text_state_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfTextStateInt)));
        PdeWordGetCharTextState(m_obj, _index, _text_state_ptr);
        PdfTextStateInt _text_stateInt = (PdfTextStateInt)Marshal.PtrToStructure(_text_state_ptr, typeof(PdfTextStateInt));
        PdfTextState _text_state = new PdfTextState();
        _text_state.SetIntStruct(_text_stateInt);
        Marshal.FreeHGlobal(_text_state_ptr);
        _text_state_ptr = IntPtr.Zero;
        return _text_state;
      }
      public PdfRect GetCharBBox(int _index)
      {
        CheckBaseObj();
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        PdeWordGetCharBBox(m_obj, _index, _bbox_ptr);
        PdfRectInt _bboxInt = (PdfRectInt)Marshal.PtrToStructure(_bbox_ptr, typeof(PdfRectInt));
        PdfRect _bbox = new PdfRect();
        _bbox.SetIntStruct(_bboxInt);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
        return _bbox;
      }
      public int GetFlags()
      {
        CheckBaseObj();
        int ret = PdeWordGetFlags(m_obj);
        return ret;
      }
      public PdeElement GetBackground()
      {
        CheckBaseObj();
        IntPtr ret = PdeWordGetBackground(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdeElement(ret);
        }
        return null;
      }
      public PdfPoint GetOrigin()
      {
        CheckBaseObj();
        IntPtr _point_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfPointInt)));
        PdeWordGetOrigin(m_obj, _point_ptr);
        PdfPointInt _pointInt = (PdfPointInt)Marshal.PtrToStructure(_point_ptr, typeof(PdfPointInt));
        PdfPoint _point = new PdfPoint();
        _point.SetIntStruct(_pointInt);
        Marshal.FreeHGlobal(_point_ptr);
        _point_ptr = IntPtr.Zero;
        return _point;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetText(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdeWordHasTextState(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetTextState(IntPtr obj, IntPtr _text_state);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetNumChars(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetCharText(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetCharTextState(IntPtr obj, int _index, IntPtr _text_state);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetCharBBox(IntPtr obj, int _index, IntPtr _bbox);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetFlags(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeWordGetBackground(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetOrigin(IntPtr obj, IntPtr _point);
    }
    public class PdeTextLine : PdeElement    {
      public PdeTextLine(IntPtr obj) : base(obj) { }
      public string GetText()
      {
        CheckBaseObj();
        int _buffer_sz = PdeTextLineGetText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdeTextLineGetText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool HasTextState()
      {
        CheckBaseObj();
        bool ret = PdeTextLineHasTextState(m_obj);
        return ret;
      }
      public PdfTextState GetTextState()
      {
        CheckBaseObj();
        IntPtr _text_state_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfTextStateInt)));
        PdeTextLineGetTextState(m_obj, _text_state_ptr);
        PdfTextStateInt _text_stateInt = (PdfTextStateInt)Marshal.PtrToStructure(_text_state_ptr, typeof(PdfTextStateInt));
        PdfTextState _text_state = new PdfTextState();
        _text_state.SetIntStruct(_text_stateInt);
        Marshal.FreeHGlobal(_text_state_ptr);
        _text_state_ptr = IntPtr.Zero;
        return _text_state;
      }
      public int GetNumWords()
      {
        CheckBaseObj();
        int ret = PdeTextLineGetNumWords(m_obj);
        return ret;
      }
      public PdeWord GetWord(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdeTextLineGetWord(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdeWord(ret);
        }
        return null;
      }
      public int GetFlags()
      {
        CheckBaseObj();
        int ret = PdeTextLineGetFlags(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetText(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdeTextLineHasTextState(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeTextLineGetTextState(IntPtr obj, IntPtr _text_state);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetNumWords(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextLineGetWord(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetFlags(IntPtr obj);
    }
    public class PdeText : PdeElement    {
      public PdeText(IntPtr obj) : base(obj) { }
      public string GetText()
      {
        CheckBaseObj();
        int _buffer_sz = PdeTextGetText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdeTextGetText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool HasTextState()
      {
        CheckBaseObj();
        bool ret = PdeTextHasTextState(m_obj);
        return ret;
      }
      public PdfTextState GetTextState()
      {
        CheckBaseObj();
        IntPtr _text_state_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfTextStateInt)));
        PdeTextGetTextState(m_obj, _text_state_ptr);
        PdfTextStateInt _text_stateInt = (PdfTextStateInt)Marshal.PtrToStructure(_text_state_ptr, typeof(PdfTextStateInt));
        PdfTextState _text_state = new PdfTextState();
        _text_state.SetIntStruct(_text_stateInt);
        Marshal.FreeHGlobal(_text_state_ptr);
        _text_state_ptr = IntPtr.Zero;
        return _text_state;
      }
      public int GetNumTextLines()
      {
        CheckBaseObj();
        int ret = PdeTextGetNumTextLines(m_obj);
        return ret;
      }
      public PdeTextLine GetTextLine(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdeTextGetTextLine(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdeTextLine(ret);
        }
        return null;
      }
      public int GetNumWords()
      {
        CheckBaseObj();
        int ret = PdeTextGetNumWords(m_obj);
        return ret;
      }
      public PdeWord GetWord(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdeTextGetWord(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdeWord(ret);
        }
        return null;
      }
      public double GetLineSpacing()
      {
        CheckBaseObj();
        double ret = PdeTextGetLineSpacing(m_obj);
        return ret;
      }
      public double GetIndent()
      {
        CheckBaseObj();
        double ret = PdeTextGetIndent(m_obj);
        return ret;
      }
      public PdfTextStyle GetTextStyle()
      {
        CheckBaseObj();
        PdfTextStyle ret = PdeTextGetTextStyle(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetText(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdeTextHasTextState(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeTextGetTextState(IntPtr obj, IntPtr _text_state);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetNumTextLines(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextGetTextLine(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetNumWords(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextGetWord(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeTextGetLineSpacing(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeTextGetIndent(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfTextStyle PdeTextGetTextStyle(IntPtr obj);
    }
    public class PdfAction : PdfixBase
    {
      public PdfAction(IntPtr obj) : base(obj) { }
      public PdfActionType GetSubtype()
      {
        CheckBaseObj();
        PdfActionType ret = PdfActionGetSubtype(m_obj);
        return ret;
      }
      public string GetJavaScript()
      {
        CheckBaseObj();
        int _buffer_sz = PdfActionGetJavaScript(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfActionGetJavaScript(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetURI()
      {
        CheckBaseObj();
        int _buffer_sz = PdfActionGetURI(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfActionGetURI(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfActionType PdfActionGetSubtype(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetJavaScript(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetURI(IntPtr obj, string _buffer, int _len);
    }
    public class PdfAnnot : PdfixBase
    {
      public PdfAnnot(IntPtr obj) : base(obj) { }
      public PdfAnnotSubtype GetSubtype()
      {
        CheckBaseObj();
        PdfAnnotSubtype ret = PdfAnnotGetSubtype(m_obj);
        return ret;
      }
      public int GetFlags()
      {
        CheckBaseObj();
        int ret = PdfAnnotGetFlags(m_obj);
        return ret;
      }
      public PdfAnnotAppearance GetAppearance()
      {
        CheckBaseObj();
        IntPtr _appearance_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfAnnotAppearanceInt)));
        PdfAnnotGetAppearance(m_obj, _appearance_ptr);
        PdfAnnotAppearanceInt _appearanceInt = (PdfAnnotAppearanceInt)Marshal.PtrToStructure(_appearance_ptr, typeof(PdfAnnotAppearanceInt));
        PdfAnnotAppearance _appearance = new PdfAnnotAppearance();
        _appearance.SetIntStruct(_appearanceInt);
        Marshal.FreeHGlobal(_appearance_ptr);
        _appearance_ptr = IntPtr.Zero;
        return _appearance;
      }
      public PdfRect GetBBox()
      {
        CheckBaseObj();
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        PdfAnnotGetBBox(m_obj, _bbox_ptr);
        PdfRectInt _bboxInt = (PdfRectInt)Marshal.PtrToStructure(_bbox_ptr, typeof(PdfRectInt));
        PdfRect _bbox = new PdfRect();
        _bbox.SetIntStruct(_bboxInt);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
        return _bbox;
      }
      public bool PointInAnnot(PdfPoint _point)
      {
        CheckBaseObj();
        PdfPointInt _pointInt = _point.GetIntStruct();
        IntPtr _point_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfPointInt)));
        Marshal.StructureToPtr(_pointInt, _point_ptr, true);
        bool ret = PdfAnnotPointInAnnot(m_obj, _point_ptr);
        Marshal.FreeHGlobal(_point_ptr);
        _point_ptr = IntPtr.Zero;
        return ret;
      }
      public bool RectInAnnot(PdfRect _rect)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        bool ret = PdfAnnotRectInAnnot(m_obj, _rect_ptr);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAnnotSubtype PdfAnnotGetSubtype(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAnnotGetFlags(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAnnotGetAppearance(IntPtr obj, IntPtr _appearance);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAnnotGetBBox(IntPtr obj, IntPtr _bbox);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfAnnotPointInAnnot(IntPtr obj, IntPtr _point);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfAnnotRectInAnnot(IntPtr obj, IntPtr _rect);
    }
    public class PdfLinkAnnot : PdfAnnot    {
      public PdfLinkAnnot(IntPtr obj) : base(obj) { }
      public int GetNumQuads()
      {
        CheckBaseObj();
        int ret = PdfLinkAnnotGetNumQuads(m_obj);
        return ret;
      }
      public PdfQuad GetQuad(int _index)
      {
        CheckBaseObj();
        IntPtr _quad_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfQuadInt)));
        PdfLinkAnnotGetQuad(m_obj, _index, _quad_ptr);
        PdfQuadInt _quadInt = (PdfQuadInt)Marshal.PtrToStructure(_quad_ptr, typeof(PdfQuadInt));
        PdfQuad _quad = new PdfQuad();
        _quad.SetIntStruct(_quadInt);
        Marshal.FreeHGlobal(_quad_ptr);
        _quad_ptr = IntPtr.Zero;
        return _quad;
      }
      public bool AddQuad(PdfQuad _quad)
      {
        CheckBaseObj();
        PdfQuadInt _quadInt = _quad.GetIntStruct();
        IntPtr _quad_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfQuadInt)));
        Marshal.StructureToPtr(_quadInt, _quad_ptr, true);
        bool ret = PdfLinkAnnotAddQuad(m_obj, _quad_ptr);
        Marshal.FreeHGlobal(_quad_ptr);
        _quad_ptr = IntPtr.Zero;
        return ret;
      }
      public bool RemoveQuad(int _index)
      {
        CheckBaseObj();
        bool ret = PdfLinkAnnotRemoveQuad(m_obj, _index);
        return ret;
      }
      public PdfAction GetAction()
      {
        CheckBaseObj();
        IntPtr ret = PdfLinkAnnotGetAction(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfAction(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfLinkAnnotGetNumQuads(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfLinkAnnotGetQuad(IntPtr obj, int _index, IntPtr _quad);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfLinkAnnotAddQuad(IntPtr obj, IntPtr _quad);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfLinkAnnotRemoveQuad(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfLinkAnnotGetAction(IntPtr obj);
    }
    public class PdfMarkupAnnot : PdfAnnot    {
      public PdfMarkupAnnot(IntPtr obj) : base(obj) { }
      public string GetContents()
      {
        CheckBaseObj();
        int _buffer_sz = PdfMarkupAnnotGetContents(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfMarkupAnnotGetContents(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetContents(string _buffer)
      {
        CheckBaseObj();
        bool ret = PdfMarkupAnnotSetContents(m_obj, _buffer);
        return ret;
      }
      public string GetAuthor()
      {
        CheckBaseObj();
        int _buffer_sz = PdfMarkupAnnotGetAuthor(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfMarkupAnnotGetAuthor(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetAuthor(string _buffer)
      {
        CheckBaseObj();
        bool ret = PdfMarkupAnnotSetAuthor(m_obj, _buffer);
        return ret;
      }
      public int GetNumReplies()
      {
        CheckBaseObj();
        int ret = PdfMarkupAnnotGetNumReplies(m_obj);
        return ret;
      }
      public PdfAnnot GetReply(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdfMarkupAnnotGetReply(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdfAnnot(ret);
        }
        return null;
      }
      public PdfAnnot AddReply(string _author, string _text)
      {
        CheckBaseObj();
        IntPtr ret = PdfMarkupAnnotAddReply(m_obj, _author, _text);
        if (ret != IntPtr.Zero)
        {
          return new PdfAnnot(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetContents(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfMarkupAnnotSetContents(IntPtr obj, string _buffer);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetAuthor(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfMarkupAnnotSetAuthor(IntPtr obj, string _buffer);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetNumReplies(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfMarkupAnnotGetReply(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfMarkupAnnotAddReply(IntPtr obj, string _author, string _text);
    }
    public class PdfTextAnnot : PdfMarkupAnnot    {
      public PdfTextAnnot(IntPtr obj) : base(obj) { }

    }
    public class PdfTextMarkupAnnot : PdfMarkupAnnot    {
      public PdfTextMarkupAnnot(IntPtr obj) : base(obj) { }
      public int GetNumQuads()
      {
        CheckBaseObj();
        int ret = PdfTextMarkupAnnotGetNumQuads(m_obj);
        return ret;
      }
      public PdfQuad GetQuad(int _index)
      {
        CheckBaseObj();
        IntPtr _quad_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfQuadInt)));
        PdfTextMarkupAnnotGetQuad(m_obj, _index, _quad_ptr);
        PdfQuadInt _quadInt = (PdfQuadInt)Marshal.PtrToStructure(_quad_ptr, typeof(PdfQuadInt));
        PdfQuad _quad = new PdfQuad();
        _quad.SetIntStruct(_quadInt);
        Marshal.FreeHGlobal(_quad_ptr);
        _quad_ptr = IntPtr.Zero;
        return _quad;
      }
      public bool AddQuad(PdfQuad _quad)
      {
        CheckBaseObj();
        PdfQuadInt _quadInt = _quad.GetIntStruct();
        IntPtr _quad_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfQuadInt)));
        Marshal.StructureToPtr(_quadInt, _quad_ptr, true);
        bool ret = PdfTextMarkupAnnotAddQuad(m_obj, _quad_ptr);
        Marshal.FreeHGlobal(_quad_ptr);
        _quad_ptr = IntPtr.Zero;
        return ret;
      }
      public bool RemoveQuad(int _index)
      {
        CheckBaseObj();
        bool ret = PdfTextMarkupAnnotRemoveQuad(m_obj, _index);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfTextMarkupAnnotGetNumQuads(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfTextMarkupAnnotGetQuad(IntPtr obj, int _index, IntPtr _quad);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfTextMarkupAnnotAddQuad(IntPtr obj, IntPtr _quad);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfTextMarkupAnnotRemoveQuad(IntPtr obj, int _index);
    }
    public class PdfWidgetAnnot : PdfAnnot    {
      public PdfWidgetAnnot(IntPtr obj) : base(obj) { }
      public string GetCaption()
      {
        CheckBaseObj();
        int _buffer_sz = PdfWidgetAnnotGetCaption(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfWidgetAnnotGetCaption(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetFontName()
      {
        CheckBaseObj();
        int _buffer_sz = PdfWidgetAnnotGetFontName(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfWidgetAnnotGetFontName(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdfAction GetAction()
      {
        CheckBaseObj();
        IntPtr ret = PdfWidgetAnnotGetAction(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfAction(ret);
        }
        return null;
      }
      public PdfAction GetAAction(PdfActionEventType _event)
      {
        CheckBaseObj();
        IntPtr ret = PdfWidgetAnnotGetAAction(m_obj, (int)_event);
        if (ret != IntPtr.Zero)
        {
          return new PdfAction(ret);
        }
        return null;
      }
      public PdfFormField GetFormField()
      {
        CheckBaseObj();
        IntPtr ret = PdfWidgetAnnotGetFormField(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfFormField(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfWidgetAnnotGetCaption(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfWidgetAnnotGetFontName(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetAction(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetAAction(IntPtr obj, int _event);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetFormField(IntPtr obj);
    }
    public class PdfBaseDigSig : PdfixBase
    {
      public PdfBaseDigSig(IntPtr obj) : base(obj) { }
      public void Destroy()
      {
        CheckBaseObj();
        PdfBaseDigSigDestroy(m_obj);
      }
      public bool SetReason(string _reason)
      {
        CheckBaseObj();
        bool ret = PdfBaseDigSigSetReason(m_obj, _reason);
        return ret;
      }
      public bool SetLocation(string _location)
      {
        CheckBaseObj();
        bool ret = PdfBaseDigSigSetLocation(m_obj, _location);
        return ret;
      }
      public bool SetContactInfo(string _contact)
      {
        CheckBaseObj();
        bool ret = PdfBaseDigSigSetContactInfo(m_obj, _contact);
        return ret;
      }
      public bool SetName(string _name)
      {
        CheckBaseObj();
        bool ret = PdfBaseDigSigSetName(m_obj, _name);
        return ret;
      }
      public bool SetTimeStampServer(string _url, string _user_name, string _password)
      {
        CheckBaseObj();
        bool ret = PdfBaseDigSigSetTimeStampServer(m_obj, _url, _user_name, _password);
        return ret;
      }
      public bool SignDoc(PdfDoc _doc, string _path)
      {
        CheckBaseObj();
        bool ret = PdfBaseDigSigSignDoc(m_obj, _doc.m_obj, _path);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfBaseDigSigDestroy(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfBaseDigSigSetReason(IntPtr obj, string _reason);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfBaseDigSigSetLocation(IntPtr obj, string _location);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfBaseDigSigSetContactInfo(IntPtr obj, string _contact);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfBaseDigSigSetName(IntPtr obj, string _name);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfBaseDigSigSetTimeStampServer(IntPtr obj, string _url, string _user_name, string _password);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfBaseDigSigSignDoc(IntPtr obj, IntPtr _doc, string _path);
    }
    public class PdfDigSig : PdfBaseDigSig    {
      public PdfDigSig(IntPtr obj) : base(obj) { }
      public bool SetPfxFile(string _pfx_file, string _pfx_password)
      {
        CheckBaseObj();
        bool ret = PdfDigSigSetPfxFile(m_obj, _pfx_file, _pfx_password);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDigSigSetPfxFile(IntPtr obj, string _pfx_file, string _pfx_password);
    }
    public class PdfCertDigSig : PdfBaseDigSig    {
      public PdfCertDigSig(IntPtr obj) : base(obj) { }
      public bool SetPfxFile(string _pfx_file, string _pfx_password)
      {
        CheckBaseObj();
        bool ret = PdfCertDigSigSetPfxFile(m_obj, _pfx_file, _pfx_password);
        return ret;
      }
      public bool SetCertContext(IntPtr _cert_context)
      {
        CheckBaseObj();
        bool ret = PdfCertDigSigSetCertContext(m_obj, _cert_context);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfCertDigSigSetPfxFile(IntPtr obj, string _pfx_file, string _pfx_password);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfCertDigSigSetCertContext(IntPtr obj, IntPtr _cert_context);
    }
    public class PdsStructTree : PdfixBase
    {
      public PdsStructTree(IntPtr obj) : base(obj) { }

    }
    public class PdfDoc : PdfixBase
    {
      public PdfDoc(IntPtr obj) : base(obj) { }
      public bool Save(string _path, PdfSaveFlags _flags)
      {
        CheckBaseObj();
        bool ret = PdfDocSave(m_obj, _path, (int)_flags);
        return ret;
      }
      public bool SaveToStream(PsStream _stream, PdfSaveFlags _flags)
      {
        CheckBaseObj();
        bool ret = PdfDocSaveToStream(m_obj, _stream.m_obj, (int)_flags);
        return ret;
      }
      public bool Close()
      {
        CheckBaseObj();
        bool ret = PdfDocClose(m_obj);
        return ret;
      }
      public bool AddWatermarkFromImage(PdfWatermarkParams _params, string _path)
      {
        CheckBaseObj();
        PdfWatermarkParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfWatermarkParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PdfDocAddWatermarkFromImage(m_obj, _params_ptr, _path);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }
      public int GetNumPages()
      {
        CheckBaseObj();
        int ret = PdfDocGetNumPages(m_obj);
        return ret;
      }
      public PdfPage AcquirePage(int _page_num)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocAcquirePage(m_obj, _page_num);
        if (ret != IntPtr.Zero)
        {
          return new PdfPage(ret);
        }
        return null;
      }
      public bool ReleasePage(PdfPage _page)
      {
        CheckBaseObj();
        bool ret = PdfDocReleasePage(m_obj, _page.m_obj);
        return ret;
      }
      public int GetNumDocumentJavaScripts()
      {
        CheckBaseObj();
        int ret = PdfDocGetNumDocumentJavaScripts(m_obj);
        return ret;
      }
      public string GetDocumentJavaScript(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdfDocGetDocumentJavaScript(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfDocGetDocumentJavaScript(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetDocumentJavaScriptName(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdfDocGetDocumentJavaScriptName(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfDocGetDocumentJavaScriptName(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public int GetNumCalculatedFormFields()
      {
        CheckBaseObj();
        int ret = PdfDocGetNumCalculatedFormFields(m_obj);
        return ret;
      }
      public PdfFormField GetCalculatedFormField(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetCalculatedFormField(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdfFormField(ret);
        }
        return null;
      }
      public int GetNumFormFields()
      {
        CheckBaseObj();
        int ret = PdfDocGetNumFormFields(m_obj);
        return ret;
      }
      public PdfFormField GetFormField(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetFormField(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdfFormField(ret);
        }
        return null;
      }
      public PdfFormField GetFormFieldByName(string _buffer)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetFormFieldByName(m_obj, _buffer);
        if (ret != IntPtr.Zero)
        {
          return new PdfFormField(ret);
        }
        return null;
      }
      public string GetInfo(string _key)
      {
        CheckBaseObj();
        int _buffer_sz = PdfDocGetInfo(m_obj, _key, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfDocGetInfo(m_obj, _key, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetInfo(string _key, string _buffer)
      {
        CheckBaseObj();
        bool ret = PdfDocSetInfo(m_obj, _key, _buffer);
        return ret;
      }
      public PdfBookmark GetBookmarkRoot()
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetBookmarkRoot(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfBookmark(ret);
        }
        return null;
      }
      public bool FlattenAnnots(PdfFlattenAnnotsParams _params)
      {
        CheckBaseObj();
        PdfFlattenAnnotsParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfFlattenAnnotsParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PdfDocFlattenAnnots(m_obj, _params_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }
      public void RemoveStructTree()
      {
        CheckBaseObj();
        PdfDocRemoveStructTree(m_obj);
      }
      public int GetNumAlternates()
      {
        CheckBaseObj();
        int ret = PdfDocGetNumAlternates(m_obj);
        return ret;
      }
      public PdfAlternate AcquireAlternate(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocAcquireAlternate(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdfAlternate(ret);
        }
        return null;
      }
      public PdsObject CreatePdsObject(PdfObjectType _type, bool _indirect)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreatePdsObject(m_obj, (int)_type, _indirect);
        if (ret != IntPtr.Zero)
        {
          return new PdsObject(ret);
        }
        return null;
      }
      public bool AddTags(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        bool ret = PdfDocAddTags(m_obj, _cancel_proc, _cancel_data);
        return ret;
      }
      public PdfDocTemplate GetDocTemplate()
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetDocTemplate(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfDocTemplate(ret);
        }
        return null;
      }
      public PsMetadata GetMetadata()
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetMetadata(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PsMetadata(ret);
        }
        return null;
      }
      public string GetLang()
      {
        CheckBaseObj();
        int _buffer_sz = PdfDocGetLang(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfDocGetLang(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetLang(string _buffer)
      {
        CheckBaseObj();
        bool ret = PdfDocSetLang(m_obj, _buffer);
        return ret;
      }
      public bool EmbedFonts(bool _subset, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        bool ret = PdfDocEmbedFonts(m_obj, _subset, _cancel_proc, _cancel_data);
        return ret;
      }
      public bool MakeAccessible(PdfAccessibleParams _params, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfAccessibleParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfAccessibleParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PdfDocMakeAccessible(m_obj, _params_ptr, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocSave(IntPtr obj, string _path, int _flags);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocSaveToStream(IntPtr obj, IntPtr _stream, int _flags);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocClose(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocAddWatermarkFromImage(IntPtr obj, IntPtr _params, string _path);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumPages(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocAcquirePage(IntPtr obj, int _page_num);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocReleasePage(IntPtr obj, IntPtr _page);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumDocumentJavaScripts(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetDocumentJavaScript(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetDocumentJavaScriptName(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumCalculatedFormFields(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetCalculatedFormField(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumFormFields(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetFormField(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetFormFieldByName(IntPtr obj, string _buffer);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetInfo(IntPtr obj, string _key, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocSetInfo(IntPtr obj, string _key, string _buffer);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetBookmarkRoot(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocFlattenAnnots(IntPtr obj, IntPtr _params);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfDocRemoveStructTree(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumAlternates(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocAcquireAlternate(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreatePdsObject(IntPtr obj, int _type, bool _indirect);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocAddTags(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetDocTemplate(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetMetadata(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetLang(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocSetLang(IntPtr obj, string _buffer);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocEmbedFonts(IntPtr obj, bool _subset, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocMakeAccessible(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
    }
    public class PdfDocTemplate : PdfixBase
    {
      public PdfDocTemplate(IntPtr obj) : base(obj) { }
      public bool PreflightDoc(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        bool ret = PdfDocTemplatePreflightDoc(m_obj, _cancel_proc, _cancel_data);
        return ret;
      }
      public bool LoadFromStream(PsStream _stream, PsDataFormat _format)
      {
        CheckBaseObj();
        bool ret = PdfDocTemplateLoadFromStream(m_obj, _stream.m_obj, (int)_format);
        return ret;
      }
      public bool SaveToStream(PsStream _stream, PsDataFormat _format)
      {
        CheckBaseObj();
        bool ret = PdfDocTemplateSaveToStream(m_obj, _stream.m_obj, (int)_format);
        return ret;
      }
      public bool SetDefaults()
      {
        CheckBaseObj();
        bool ret = PdfDocTemplateSetDefaults(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocTemplatePreflightDoc(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocTemplateLoadFromStream(IntPtr obj, IntPtr _stream, int _format);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocTemplateSaveToStream(IntPtr obj, IntPtr _stream, int _format);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfDocTemplateSetDefaults(IntPtr obj);
    }
    public class PdfAlternate : PdfixBase
    {
      public PdfAlternate(IntPtr obj) : base(obj) { }
      public PdfAlternateType GetSubtype()
      {
        CheckBaseObj();
        PdfAlternateType ret = PdfAlternateGetSubtype(m_obj);
        return ret;
      }
      public string GetName()
      {
        CheckBaseObj();
        int _buffer_sz = PdfAlternateGetName(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfAlternateGetName(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetDescription()
      {
        CheckBaseObj();
        int _buffer_sz = PdfAlternateGetDescription(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfAlternateGetDescription(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetFileName()
      {
        CheckBaseObj();
        int _buffer_sz = PdfAlternateGetFileName(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfAlternateGetFileName(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SaveContent(string _path)
      {
        CheckBaseObj();
        bool ret = PdfAlternateSaveContent(m_obj, _path);
        return ret;
      }
      public void Release()
      {
        CheckBaseObj();
        PdfAlternateRelease(m_obj);
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlternateType PdfAlternateGetSubtype(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetName(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetDescription(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetFileName(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfAlternateSaveContent(IntPtr obj, string _path);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAlternateRelease(IntPtr obj);
    }
    public class PdfHtmlAlternate : PdfAlternate    {
      public PdfHtmlAlternate(IntPtr obj) : base(obj) { }
      public bool SaveResource(string _resource_name, string _path)
      {
        CheckBaseObj();
        bool ret = PdfHtmlAlternateSaveResource(m_obj, _resource_name, _path);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfHtmlAlternateSaveResource(IntPtr obj, string _resource_name, string _path);
    }
    public class PdfFont : PdfixBase
    {
      public PdfFont(IntPtr obj) : base(obj) { }
      public string GetFontName()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFontGetFontName(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFontGetFontName(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetFaceName()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFontGetFaceName(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFontGetFaceName(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdfFontState GetFontState()
      {
        CheckBaseObj();
        IntPtr _font_state_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfFontStateInt)));
        PdfFontGetFontState(m_obj, _font_state_ptr);
        PdfFontStateInt _font_stateInt = (PdfFontStateInt)Marshal.PtrToStructure(_font_state_ptr, typeof(PdfFontStateInt));
        PdfFontState _font_state = new PdfFontState();
        _font_state.SetIntStruct(_font_stateInt);
        Marshal.FreeHGlobal(_font_state_ptr);
        _font_state_ptr = IntPtr.Zero;
        return _font_state;
      }
      public string GetSystemFontName()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFontGetSystemFontName(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFontGetSystemFontName(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdfFontCharset GetSystemFontCharset()
      {
        CheckBaseObj();
        PdfFontCharset ret = PdfFontGetSystemFontCharset(m_obj);
        return ret;
      }
      public bool GetSystemFontBold()
      {
        CheckBaseObj();
        bool ret = PdfFontGetSystemFontBold(m_obj);
        return ret;
      }
      public bool GetSystemFontItalic()
      {
        CheckBaseObj();
        bool ret = PdfFontGetSystemFontItalic(m_obj);
        return ret;
      }
      public bool SaveToStream(PsStream _stream, PdfFontFormat _format)
      {
        CheckBaseObj();
        bool ret = PdfFontSaveToStream(m_obj, _stream.m_obj, (int)_format);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetFontName(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetFaceName(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfFontGetFontState(IntPtr obj, IntPtr _font_state);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetSystemFontName(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfFontCharset PdfFontGetSystemFontCharset(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfFontGetSystemFontBold(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfFontGetSystemFontItalic(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfFontSaveToStream(IntPtr obj, IntPtr _stream, int _format);
    }
    public class PdfFormField : PdfixBase
    {
      public PdfFormField(IntPtr obj) : base(obj) { }
      public PdfFieldType GetType_()
      {
        CheckBaseObj();
        PdfFieldType ret = PdfFormFieldGetType(m_obj);
        return ret;
      }
      public int GetFlags()
      {
        CheckBaseObj();
        int ret = PdfFormFieldGetFlags(m_obj);
        return ret;
      }
      public bool SetFlags(int _flags)
      {
        CheckBaseObj();
        bool ret = PdfFormFieldSetFlags(m_obj, _flags);
        return ret;
      }
      public string GetValue()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetValue(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetValue(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetValue(string _buffer)
      {
        CheckBaseObj();
        bool ret = PdfFormFieldSetValue(m_obj, _buffer);
        return ret;
      }
      public string GetDefaultValue()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetDefaultValue(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetDefaultValue(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetFullName()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetFullName(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetFullName(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetTooltip()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetTooltip(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetTooltip(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public int GetOptionCount()
      {
        CheckBaseObj();
        int ret = PdfFormFieldGetOptionCount(m_obj);
        return ret;
      }
      public string GetOptionValue(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetOptionValue(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetOptionValue(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetOptionCaption(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetOptionCaption(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetOptionCaption(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdfAction GetAction()
      {
        CheckBaseObj();
        IntPtr ret = PdfFormFieldGetAction(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfAction(ret);
        }
        return null;
      }
      public PdfAction GetAAction(PdfActionEventType _event)
      {
        CheckBaseObj();
        IntPtr ret = PdfFormFieldGetAAction(m_obj, (int)_event);
        if (ret != IntPtr.Zero)
        {
          return new PdfAction(ret);
        }
        return null;
      }
      public int GetMaxLength()
      {
        CheckBaseObj();
        int ret = PdfFormFieldGetMaxLength(m_obj);
        return ret;
      }
      public string GetWidgetExportValue(PdfAnnot _annot)
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetWidgetExportValue(m_obj, _annot.m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetWidgetExportValue(m_obj, _annot.m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfFieldType PdfFormFieldGetType(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetFlags(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfFormFieldSetFlags(IntPtr obj, int _flags);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetValue(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfFormFieldSetValue(IntPtr obj, string _buffer);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetDefaultValue(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetFullName(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetTooltip(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionCount(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionValue(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionCaption(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfFormFieldGetAction(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfFormFieldGetAAction(IntPtr obj, int _event);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetMaxLength(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetWidgetExportValue(IntPtr obj, IntPtr _annot, string _buffer, int _len);
    }
    public class PsImage : PdfixBase
    {
      public PsImage(IntPtr obj) : base(obj) { }
      public void Destroy()
      {
        CheckBaseObj();
        PsImageDestroy(m_obj);
      }
      public bool Save(string _path, PdfImageParams _params)
      {
        CheckBaseObj();
        PdfImageParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfImageParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PsImageSave(m_obj, _path, _params_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }
      public bool SaveRect(string _path, PdfImageParams _params, PdfDevRect _dev_rect)
      {
        CheckBaseObj();
        PdfImageParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfImageParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        PdfDevRectInt _dev_rectInt = _dev_rect.GetIntStruct();
        IntPtr _dev_rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfDevRectInt)));
        Marshal.StructureToPtr(_dev_rectInt, _dev_rect_ptr, true);
        bool ret = PsImageSaveRect(m_obj, _path, _params_ptr, _dev_rect_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        Marshal.FreeHGlobal(_dev_rect_ptr);
        _dev_rect_ptr = IntPtr.Zero;
        return ret;
      }
      public bool SaveToStream(PsStream _stream, PdfImageParams _params)
      {
        CheckBaseObj();
        PdfImageParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfImageParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PsImageSaveToStream(m_obj, _stream.m_obj, _params_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }
      public bool SaveRectToStream(PsStream _stream, PdfImageParams _params, PdfDevRect _dev_rect)
      {
        CheckBaseObj();
        PdfImageParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfImageParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        PdfDevRectInt _dev_rectInt = _dev_rect.GetIntStruct();
        IntPtr _dev_rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfDevRectInt)));
        Marshal.StructureToPtr(_dev_rectInt, _dev_rect_ptr, true);
        bool ret = PsImageSaveRectToStream(m_obj, _stream.m_obj, _params_ptr, _dev_rect_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        Marshal.FreeHGlobal(_dev_rect_ptr);
        _dev_rect_ptr = IntPtr.Zero;
        return ret;
      }
      public PdfRGB GetPointColor(PdfDevPoint _point)
      {
        CheckBaseObj();
        PdfDevPointInt _pointInt = _point.GetIntStruct();
        IntPtr _point_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfDevPointInt)));
        Marshal.StructureToPtr(_pointInt, _point_ptr, true);
        IntPtr _color_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRGBInt)));
        PsImageGetPointColor(m_obj, _point_ptr, _color_ptr);
        Marshal.FreeHGlobal(_point_ptr);
        _point_ptr = IntPtr.Zero;
        PdfRGBInt _colorInt = (PdfRGBInt)Marshal.PtrToStructure(_color_ptr, typeof(PdfRGBInt));
        PdfRGB _color = new PdfRGB();
        _color.SetIntStruct(_colorInt);
        Marshal.FreeHGlobal(_color_ptr);
        _color_ptr = IntPtr.Zero;
        return _color;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsImageDestroy(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsImageSave(IntPtr obj, string _path, IntPtr _params);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsImageSaveRect(IntPtr obj, string _path, IntPtr _params, IntPtr _dev_rect);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsImageSaveToStream(IntPtr obj, IntPtr _stream, IntPtr _params);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsImageSaveRectToStream(IntPtr obj, IntPtr _stream, IntPtr _params, IntPtr _dev_rect);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsImageGetPointColor(IntPtr obj, IntPtr _point, IntPtr _color);
    }
    public class PdfPage : PdfixBase
    {
      public PdfPage(IntPtr obj) : base(obj) { }
      public PdfRect GetCropBox()
      {
        CheckBaseObj();
        IntPtr _crop_box_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        PdfPageGetCropBox(m_obj, _crop_box_ptr);
        PdfRectInt _crop_boxInt = (PdfRectInt)Marshal.PtrToStructure(_crop_box_ptr, typeof(PdfRectInt));
        PdfRect _crop_box = new PdfRect();
        _crop_box.SetIntStruct(_crop_boxInt);
        Marshal.FreeHGlobal(_crop_box_ptr);
        _crop_box_ptr = IntPtr.Zero;
        return _crop_box;
      }
      public PdfRect GetMediaBox()
      {
        CheckBaseObj();
        IntPtr _media_box_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        PdfPageGetMediaBox(m_obj, _media_box_ptr);
        PdfRectInt _media_boxInt = (PdfRectInt)Marshal.PtrToStructure(_media_box_ptr, typeof(PdfRectInt));
        PdfRect _media_box = new PdfRect();
        _media_box.SetIntStruct(_media_boxInt);
        Marshal.FreeHGlobal(_media_box_ptr);
        _media_box_ptr = IntPtr.Zero;
        return _media_box;
      }
      public PdfRotate GetRotate()
      {
        CheckBaseObj();
        PdfRotate ret = PdfPageGetRotate(m_obj);
        return ret;
      }
      public PdfMatrix GetDefaultMatrix()
      {
        CheckBaseObj();
        IntPtr _matrix_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfMatrixInt)));
        PdfPageGetDefaultMatrix(m_obj, _matrix_ptr);
        PdfMatrixInt _matrixInt = (PdfMatrixInt)Marshal.PtrToStructure(_matrix_ptr, typeof(PdfMatrixInt));
        PdfMatrix _matrix = new PdfMatrix();
        _matrix.SetIntStruct(_matrixInt);
        Marshal.FreeHGlobal(_matrix_ptr);
        _matrix_ptr = IntPtr.Zero;
        return _matrix;
      }
      public int GetNumber()
      {
        CheckBaseObj();
        int ret = PdfPageGetNumber(m_obj);
        return ret;
      }
      public PdePageMap AcquirePageMap(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        IntPtr ret = PdfPageAcquirePageMap(m_obj, _cancel_proc, _cancel_data);
        if (ret != IntPtr.Zero)
        {
          return new PdePageMap(ret);
        }
        return null;
      }
      public bool ReleasePageMap()
      {
        CheckBaseObj();
        bool ret = PdfPageReleasePageMap(m_obj);
        return ret;
      }
      public PdfPageView AcquirePageView(double _zoom, PdfRotate _rotate)
      {
        CheckBaseObj();
        IntPtr ret = PdfPageAcquirePageView(m_obj, _zoom, (int)_rotate);
        if (ret != IntPtr.Zero)
        {
          return new PdfPageView(ret);
        }
        return null;
      }
      public bool ReleasePageView(PdfPageView _page_view)
      {
        CheckBaseObj();
        bool ret = PdfPageReleasePageView(m_obj, _page_view.m_obj);
        return ret;
      }
      public int GetNumAnnots()
      {
        CheckBaseObj();
        int ret = PdfPageGetNumAnnots(m_obj);
        return ret;
      }
      public PdfAnnot GetAnnot(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdfPageGetAnnot(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdfAnnot(ret);
        }
        return null;
      }
      public bool RemoveAnnot(int _index, int _flags)
      {
        CheckBaseObj();
        bool ret = PdfPageRemoveAnnot(m_obj, _index, _flags);
        return ret;
      }
      public PdfTextAnnot AddTextAnnot(int _index, PdfRect _rect)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        IntPtr ret = PdfPageAddTextAnnot(m_obj, _index, _rect_ptr);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        if (ret != IntPtr.Zero)
        {
          return new PdfTextAnnot(ret);
        }
        return null;
      }
      public PdfLinkAnnot AddLinkAnnot(int _index, PdfRect _rect)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        IntPtr ret = PdfPageAddLinkAnnot(m_obj, _index, _rect_ptr);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        if (ret != IntPtr.Zero)
        {
          return new PdfLinkAnnot(ret);
        }
        return null;
      }
      public PdfTextMarkupAnnot AddTextMarkupAnnot(int _index, PdfRect _rect, PdfAnnotSubtype _subtype)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        IntPtr ret = PdfPageAddTextMarkupAnnot(m_obj, _index, _rect_ptr, (int)_subtype);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        if (ret != IntPtr.Zero)
        {
          return new PdfTextMarkupAnnot(ret);
        }
        return null;
      }
      public int GetNumAnnotsAtPoint(PdfPoint _point)
      {
        CheckBaseObj();
        PdfPointInt _pointInt = _point.GetIntStruct();
        IntPtr _point_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfPointInt)));
        Marshal.StructureToPtr(_pointInt, _point_ptr, true);
        int ret = PdfPageGetNumAnnotsAtPoint(m_obj, _point_ptr);
        Marshal.FreeHGlobal(_point_ptr);
        _point_ptr = IntPtr.Zero;
        return ret;
      }
      public PdfAnnot GetAnnotAtPoint(PdfPoint _point, int _index)
      {
        CheckBaseObj();
        PdfPointInt _pointInt = _point.GetIntStruct();
        IntPtr _point_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfPointInt)));
        Marshal.StructureToPtr(_pointInt, _point_ptr, true);
        IntPtr ret = PdfPageGetAnnotAtPoint(m_obj, _point_ptr, _index);
        Marshal.FreeHGlobal(_point_ptr);
        _point_ptr = IntPtr.Zero;
        if (ret != IntPtr.Zero)
        {
          return new PdfAnnot(ret);
        }
        return null;
      }
      public int GetNumAnnotsAtRect(PdfRect _rect)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        int ret = PdfPageGetNumAnnotsAtRect(m_obj, _rect_ptr);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        return ret;
      }
      public PdfAnnot GetAnnotAtRect(PdfRect _rect, int _index)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        IntPtr ret = PdfPageGetAnnotAtRect(m_obj, _rect_ptr, _index);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        if (ret != IntPtr.Zero)
        {
          return new PdfAnnot(ret);
        }
        return null;
      }
      public bool DrawContent(PdfPageRenderParams _params, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfPageRenderParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfPageRenderParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PdfPageDrawContent(m_obj, _params_ptr, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetCropBox(IntPtr obj, IntPtr _crop_box);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetMediaBox(IntPtr obj, IntPtr _media_box);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfRotate PdfPageGetRotate(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetDefaultMatrix(IntPtr obj, IntPtr _matrix);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumber(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAcquirePageMap(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfPageReleasePageMap(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAcquirePageView(IntPtr obj, double _zoom, int _rotate);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfPageReleasePageView(IntPtr obj, IntPtr _page_view);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnots(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnot(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfPageRemoveAnnot(IntPtr obj, int _index, int _flags);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddTextAnnot(IntPtr obj, int _index, IntPtr _rect);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddLinkAnnot(IntPtr obj, int _index, IntPtr _rect);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddTextMarkupAnnot(IntPtr obj, int _index, IntPtr _rect, int _subtype);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnotsAtPoint(IntPtr obj, IntPtr _point);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnotAtPoint(IntPtr obj, IntPtr _point, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnotsAtRect(IntPtr obj, IntPtr _rect);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnotAtRect(IntPtr obj, IntPtr _rect, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfPageDrawContent(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
    }
    public class PdePageMap : PdfixBase
    {
      public PdePageMap(IntPtr obj) : base(obj) { }
      public PdeElement GetElement()
      {
        CheckBaseObj();
        IntPtr ret = PdePageMapGetElement(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdeElement(ret);
        }
        return null;
      }
      public PdfRect GetWhitespace(PdfWhitespaceParams _params, int _index)
      {
        CheckBaseObj();
        PdfWhitespaceParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfWhitespaceParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        bool ret = PdePageMapGetWhitespace(m_obj, _params_ptr, _index, _bbox_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        PdfRectInt _bboxInt = (PdfRectInt)Marshal.PtrToStructure(_bbox_ptr, typeof(PdfRectInt));
        PdfRect _bbox = new PdfRect();
        _bbox.SetIntStruct(_bboxInt);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
        return _bbox;
      }
      public PdfRect GetBBox()
      {
        CheckBaseObj();
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        PdePageMapGetBBox(m_obj, _bbox_ptr);
        PdfRectInt _bboxInt = (PdfRectInt)Marshal.PtrToStructure(_bbox_ptr, typeof(PdfRectInt));
        PdfRect _bbox = new PdfRect();
        _bbox.SetIntStruct(_bboxInt);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
        return _bbox;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdePageMapGetElement(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdePageMapGetWhitespace(IntPtr obj, IntPtr _params, int _index, IntPtr _bbox);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdePageMapGetBBox(IntPtr obj, IntPtr _bbox);
    }
    public class PdfPageView : PdfixBase
    {
      public PdfPageView(IntPtr obj) : base(obj) { }
      public int GetDeviceWidth()
      {
        CheckBaseObj();
        int ret = PdfPageViewGetDeviceWidth(m_obj);
        return ret;
      }
      public int GetDeviceHeight()
      {
        CheckBaseObj();
        int ret = PdfPageViewGetDeviceHeight(m_obj);
        return ret;
      }
      public PdfMatrix GetDeviceMatrix()
      {
        CheckBaseObj();
        IntPtr _matrix_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfMatrixInt)));
        PdfPageViewGetDeviceMatrix(m_obj, _matrix_ptr);
        PdfMatrixInt _matrixInt = (PdfMatrixInt)Marshal.PtrToStructure(_matrix_ptr, typeof(PdfMatrixInt));
        PdfMatrix _matrix = new PdfMatrix();
        _matrix.SetIntStruct(_matrixInt);
        Marshal.FreeHGlobal(_matrix_ptr);
        _matrix_ptr = IntPtr.Zero;
        return _matrix;
      }
      public PdfDevRect RectToDevice(PdfRect _rect)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        IntPtr _dev_rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfDevRectInt)));
        PdfPageViewRectToDevice(m_obj, _rect_ptr, _dev_rect_ptr);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        PdfDevRectInt _dev_rectInt = (PdfDevRectInt)Marshal.PtrToStructure(_dev_rect_ptr, typeof(PdfDevRectInt));
        PdfDevRect _dev_rect = new PdfDevRect();
        _dev_rect.SetIntStruct(_dev_rectInt);
        Marshal.FreeHGlobal(_dev_rect_ptr);
        _dev_rect_ptr = IntPtr.Zero;
        return _dev_rect;
      }
      public PdfDevPoint PointToDevice(PdfPoint _point)
      {
        CheckBaseObj();
        PdfPointInt _pointInt = _point.GetIntStruct();
        IntPtr _point_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfPointInt)));
        Marshal.StructureToPtr(_pointInt, _point_ptr, true);
        IntPtr _dev_point_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfDevPointInt)));
        PdfPageViewPointToDevice(m_obj, _point_ptr, _dev_point_ptr);
        Marshal.FreeHGlobal(_point_ptr);
        _point_ptr = IntPtr.Zero;
        PdfDevPointInt _dev_pointInt = (PdfDevPointInt)Marshal.PtrToStructure(_dev_point_ptr, typeof(PdfDevPointInt));
        PdfDevPoint _dev_point = new PdfDevPoint();
        _dev_point.SetIntStruct(_dev_pointInt);
        Marshal.FreeHGlobal(_dev_point_ptr);
        _dev_point_ptr = IntPtr.Zero;
        return _dev_point;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageViewGetDeviceWidth(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageViewGetDeviceHeight(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewGetDeviceMatrix(IntPtr obj, IntPtr _matrix);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewRectToDevice(IntPtr obj, IntPtr _rect, IntPtr _dev_rect);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewPointToDevice(IntPtr obj, IntPtr _point, IntPtr _dev_point);
    }
    public class PdfBookmark : PdfixBase
    {
      public PdfBookmark(IntPtr obj) : base(obj) { }
      public string GetTitle()
      {
        CheckBaseObj();
        int _buffer_sz = PdfBookmarkGetTitle(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfBookmarkGetTitle(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public void GetAppearance(PdfBookmarkAppearance _appearance)
      {
        CheckBaseObj();
        PdfBookmarkAppearanceInt _appearanceInt = _appearance.GetIntStruct();
        IntPtr _appearance_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfBookmarkAppearanceInt)));
        Marshal.StructureToPtr(_appearanceInt, _appearance_ptr, true);
        PdfBookmarkGetAppearance(m_obj, _appearance_ptr);
        Marshal.FreeHGlobal(_appearance_ptr);
        _appearance_ptr = IntPtr.Zero;
      }
      public PdfAction GetAction()
      {
        CheckBaseObj();
        IntPtr ret = PdfBookmarkGetAction(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfAction(ret);
        }
        return null;
      }
      public int GetNumChildren()
      {
        CheckBaseObj();
        int ret = PdfBookmarkGetNumChildren(m_obj);
        return ret;
      }
      public PdfBookmark GetChild(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdfBookmarkGetChild(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdfBookmark(ret);
        }
        return null;
      }
      public PdfBookmark GetParent()
      {
        CheckBaseObj();
        IntPtr ret = PdfBookmarkGetParent(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfBookmark(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfBookmarkGetTitle(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfBookmarkGetAppearance(IntPtr obj, IntPtr _appearance);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetAction(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfBookmarkGetNumChildren(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetChild(IntPtr obj, int _index);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetParent(IntPtr obj);
    }
    public class PsRegex : PdfixBase
    {
      public PsRegex(IntPtr obj) : base(obj) { }
      public void Destroy()
      {
        CheckBaseObj();
        PsRegexDestroy(m_obj);
      }
      public bool SetPattern(string _pattern)
      {
        CheckBaseObj();
        bool ret = PsRegexSetPattern(m_obj, _pattern);
        return ret;
      }
      public bool Search(string _text, int _position)
      {
        CheckBaseObj();
        bool ret = PsRegexSearch(m_obj, _text, _position);
        return ret;
      }
      public string GetText()
      {
        CheckBaseObj();
        int _buffer_sz = PsRegexGetText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PsRegexGetText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public int GetPosition()
      {
        CheckBaseObj();
        int ret = PsRegexGetPosition(m_obj);
        return ret;
      }
      public int GetLength()
      {
        CheckBaseObj();
        int ret = PsRegexGetLength(m_obj);
        return ret;
      }
      public int GetNumMatches()
      {
        CheckBaseObj();
        int ret = PsRegexGetNumMatches(m_obj);
        return ret;
      }
      public string GetMatchText(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PsRegexGetMatchText(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PsRegexGetMatchText(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsRegexDestroy(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsRegexSetPattern(IntPtr obj, string _pattern);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsRegexSearch(IntPtr obj, string _text, int _position);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetText(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetPosition(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetLength(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetNumMatches(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetMatchText(IntPtr obj, int _index, string _buffer, int _len);
    }
    public class PsStream : PdfixBase
    {
      public PsStream(IntPtr obj) : base(obj) { }
      public void Destroy()
      {
        CheckBaseObj();
        PsStreamDestroy(m_obj);
      }
      public bool IsEof()
      {
        CheckBaseObj();
        bool ret = PsStreamIsEof(m_obj);
        return ret;
      }
      public int GetSize()
      {
        CheckBaseObj();
        int ret = PsStreamGetSize(m_obj);
        return ret;
      }
      public bool Read(int _offset, byte[] _buffer)
      {
        CheckBaseObj();
        IntPtr _buffer_ptr = Marshal.AllocHGlobal(_buffer.Length);
        bool ret = PsStreamRead(m_obj, _offset, _buffer_ptr, _buffer.Length);
        if (ret) Marshal.Copy(_buffer_ptr, _buffer, 0, _buffer.Length);
        Marshal.FreeHGlobal(_buffer_ptr);
        _buffer_ptr = IntPtr.Zero;
        return ret;
      }
      public bool Write(int _offset, byte[] _buffer)
      {
        CheckBaseObj();
        IntPtr _buffer_ptr = Marshal.AllocHGlobal(_buffer.Length);
        Marshal.Copy(_buffer, 0, _buffer_ptr, _buffer.Length);
        bool ret = PsStreamWrite(m_obj, _offset, _buffer_ptr, _buffer.Length);
        Marshal.FreeHGlobal(_buffer_ptr);
        _buffer_ptr = IntPtr.Zero;
        return ret;
      }
      public int GetPos()
      {
        CheckBaseObj();
        int ret = PsStreamGetPos(m_obj);
        return ret;
      }
      public bool Flush()
      {
        CheckBaseObj();
        bool ret = PsStreamFlush(m_obj);
        return ret;
      }
      public PdfStreamType GetType_()
      {
        CheckBaseObj();
        PdfStreamType ret = PsStreamGetType(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsStreamDestroy(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsStreamIsEof(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsStreamGetSize(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsStreamRead(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsStreamWrite(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsStreamGetPos(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsStreamFlush(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfStreamType PsStreamGetType(IntPtr obj);
    }
    public class PsFileStream : PsStream    {
      public PsFileStream(IntPtr obj) : base(obj) { }

    }
    public class PsMemoryStream : PsStream    {
      public PsMemoryStream(IntPtr obj) : base(obj) { }
      public bool Resize(int _size)
      {
        CheckBaseObj();
        bool ret = PsMemoryStreamResize(m_obj, _size);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsMemoryStreamResize(IntPtr obj, int _size);
    }
    public class PsProcStream : PsStream    {
      public PsProcStream(IntPtr obj) : base(obj) { }

    }
    public class PdfStructElement : PdfixBase
    {
      public PdfStructElement(IntPtr obj) : base(obj) { }
      public string GetType_()
      {
        CheckBaseObj();
        string ret = PdfStructElementGetType(m_obj);
        return ret;
      }
      public string GetSubtype()
      {
        CheckBaseObj();
        string ret = PdfStructElementGetSubtype(m_obj);
        return ret;
      }
      public string GetActualText()
      {
        CheckBaseObj();
        int _buffer_sz = PdfStructElementGetActualText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfStructElementGetActualText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern string PdfStructElementGetType(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern string PdfStructElementGetSubtype(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfStructElementGetActualText(IntPtr obj, string _buffer, int _len);
    }
    public class PsMetadata : PdfixBase
    {
      public PsMetadata(IntPtr obj) : base(obj) { }
      public bool SaveToStream(PsStream _stream)
      {
        CheckBaseObj();
        bool ret = PsMetadataSaveToStream(m_obj, _stream.m_obj);
        return ret;
      }
      public bool LoadFromStream(PsStream _stream)
      {
        CheckBaseObj();
        bool ret = PsMetadataLoadFromStream(m_obj, _stream.m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsMetadataSaveToStream(IntPtr obj, IntPtr _stream);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PsMetadataLoadFromStream(IntPtr obj, IntPtr _stream);
    }
    public class Pdfix : PdfixBase
    {
      public const int kErrorUnknown = 1;
      public const int kErrorOutOfMemory = 2;
      public const int kErrorMalformedInput = 3;
      public const int kErrorMethodNotImplemented = 4;
      public const int kErrorPdfDocInvalid = 5;
      public const int kErrorPdfDocOpen = 6;
      public const int kErrorPdfDocCreate = 7;
      public const int kErrorPdfDocSave = 8;
      public const int kErrorPdfDocXFA = 9;
      public const int kErrorPdfDocInterForm = 10;
      public const int kErrorPdfDocClose = 11;
      public const int kErrorPdfDocInfo = 12;
      public const int kErrorPdfDocStructTreeMissing = 13;
      public const int kErrorPdfDigSigDestroy = 14;
      public const int kErrorPdfDigSigOpenPfxFile = 15;
      public const int kErrorPdfDigSigSaveFile = 16;
      public const int kErrorPdfDigSigReadFile = 17;
      public const int kErrorPdfDigSigCertOpenSystemStore = 18;
      public const int kErrorPdfDigSigPFXImportCertStore = 19;
      public const int kErrorPdfDigSigCertFindInStore = 20;
      public const int kErrorPdfDigSigPFXImportOpenSSL = 21;
      public const int kErrorPdfDigSigPFXParseOpenSSL = 22;
      public const int kErrorPdfDigSigByteRange = 23;
      public const int kErrorPdfDigSigCryptMemAlloc = 24;
      public const int kErrorPdfDigSigCryptSignMessage = 25;
      public const int kErrorPdfDigSigTimeStampMessage = 26;
      public const int kErrorPdfDigSigTimeStampRequest = 27;
      public const int kErrorPdfDigSigCryptHash = 28;
      public const int kErrorPdfDigSigVerifyDetachedMessage = 29;
      public const int kErrorPdfDigSigUnknownType = 30;
      public const int kErrorPdfDigSigCallback = 31;
      public const int kErrorPdfCosObjInvalid = 32;
      public const int kErrorPdfFontSubstFontMissing = 33;
      public const int kErrorPdfPageRelease = 34;
      public const int kErrorPdfPageGetImage = 35;
      public const int kErrorPdfPageInvalidObj = 36;
      public const int kErrorPdfPageInvalidColorSpace = 37;
      public const int kErrorPdfPageOutOfRange = 38;
      public const int kErrorPdfPageMapInvalidObj = 39;
      public const int kErrorPdfPageMapParse = 40;
      public const int kErrorPdfPageMapRangeOutOf = 41;
      public const int kErrorPdfPageMapAddElement = 42;
      public const int kErrorPdfPageMapCantInsertTj = 43;
      public const int kErrorPdfPageMapWhitespaceOutOfRange = 44;
      public const int kErrorPdfPageViewNotFound = 45;
      public const int kErrorPsImageOpenFile = 46;
      public const int kErrorPsImageUnsupportedFormat = 47;
      public const int kErrorPsImageWriteBMP = 48;
      public const int kErrorPsImageWritePNG = 49;
      public const int kErrorPsImageWriteJPG = 50;
      public const int kErrorPsImageInvalidBitmap = 51;
      public const int kErrorPsImageFormat = 52;
      public const int kErrorPdfAnnotMalformed = 53;
      public const int kErrorPdfAnnotInvalidType = 54;
      public const int kErrorPdfAnnotOutOfRange = 55;
      public const int kErrorPdeAnnotMalformed = 56;
      public const int kErrorPdeElementChildrenOutOfRange = 57;
      public const int kErrorPdeElementMalformed = 58;
      public const int kErrorPdeTextRunMalformed = 59;
      public const int kErrorPdeWordMalformed = 60;
      public const int kErrorPdeLineMalformed = 61;
      public const int kErrorPdeListMalformed = 62;
      public const int kErrorPdeTextMalformed = 63;
      public const int kErrorPdeTextRangeOutOf = 64;
      public const int kErrorPdeTextSelectRange = 65;
      public const int kErrorPdeTableMalformed = 66;
      public const int kErrorPdeTableCellRangeOutOf = 67;
      public const int kErrorPdeCellRangeOutOf = 68;
      public const int kErrorPsRegexDestroy = 69;
      public const int kErrorPsRegexPatternMissing = 70;
      public const int kErrorPsRegexPositionOutOfRange = 71;
      public const int kErrorPsEventMalformed = 72;
      public const int kErrorPsEventExists = 73;
      public const int kErrorPsNoEvent = 74;
      public const int kErrorPdfBookmarkMalformed = 75;
      public const int kErrorPdfBookmarkRoot = 76;
      public const int kErrorPdfBookmarkChildrenOutOfRange = 77;
      public const int kErrorPsAuthorizationFailed = 78;
      public const int kErrorPsAuthorizationNeeded = 79;
      public const int kErrorPsAuthorizationCalled = 80;
      public const int kErrorPsAuthorizationEmail = 81;
      public const int kErrorPsAuthorizationWin = 82;
      public const int kErrorPsAuthorizationMac = 83;
      public const int kErrorPsAuthorizationAndroid = 84;
      public const int kErrorPsAuthorizationiOS = 85;
      public const int kErrorPsAuthorizationLinux = 86;
      public const int kErrorPsAuthorizationServer = 87;
      public const int kErrorPsAuthorizationFeature = 88;
      public const int kErrorPsAuthorizationDate = 89;
      public const int kErrorPsAuthorizationVersion = 90;
      public const int kErrorPsAuthorizationNumber = 91;
      public const int kErrorPsAuthorizationOsCheck = 92;
      public const int kErrorPdfFontNotEmbedded = 93;
      public const int kErrorPdfFontSave = 94;
      public const int kErrorPathNotFound = 95;
      public const int kErrorPdfPageMapAddTags = 96;
      public const int kErrorPdfPageMapRemoveTags = 97;
      public const int kErrorPdfAlternateNotFound = 98;
      public const int kErrorPdfAlternateInvalid = 99;
      public const int kErrorPdfAlternateResourceNotFound = 100;
      public const int kErrorPdfHtmlAlternateFont = 101;
      public const int kErrorPdfHtmlAlternateCreateAF = 102;
      public const int kErrorPdfHtmlAlternateWriteAF = 103;
      public const int kErrorPdfHtmlAlternateImage = 104;
      public const int kErrorPsStreamReadProcMissing = 105;
      public const int kErrorPsStreamWriteProcMissing = 106;
      public const int kErrorPsStreamGetSizeProcMissing = 107;
      public const int kErrorPdfPageMapTagAttributes = 108;
      public const int kErrorPdfPageMapTagParentTree = 109;
      public const int kErrorPdeContentWriter = 110;
      public const int kErrorParsingDataFile = 111;
      public const int kErrorPsRegexSearchFail = 112;
      public const int kErrorDocTemplateInvalidQuery = 113;
      public const int kErrorDocTemplateInvalidValue = 114;
      public const int kErrorPdsStructTreeInvalid = 115;
      public const int kErrorPsRegexIndexOutOfBounds = 116;
      public const int kErrorInit = 117;
      public const int kAnnotFlagNone = 0x0000;
      public const int kAnnotFlagInvisible = 0x0001;
      public const int kAnnotFlagHidden = 0x0002;
      public const int kAnnotFlagPrint = 0x0004;
      public const int kAnnotFlagNoZoom = 0x0008;
      public const int kAnnotFlagNoRotate = 0x0010;
      public const int kAnnotFlagNoView = 0x0020;
      public const int kAnnotFlagReadOnly = 0x0040;
      public const int kAnnotFlagLocked = 0x0080;
      public const int kAnnotFlagToggleNoView = 0x0100;
      public const int kAnnotFlagLockedContents = 0x0200;
      public const int kRemoveAnnotSingle = 0x0000;
      public const int kRemoveAnnotPopup = 0x0001;
      public const int kRemoveAnnotReply = 0x0002;
      public const int kTextFlagNone = 0x000;
      public const int kTextFlagUnderline = 0x001;
      public const int kTextFlagStrikeout = 0x002;
      public const int kTextFlagHighlight = 0x004;
      public const int kTextFlagSubscript = 0x008;
      public const int kTextFlagSuperscript = 0x010;
      public const int kTextFlagNoUnicode = 0x020;
      public const int kTextFlagPatternFill = 0x040;
      public const int kTextFlagPatternStroke = 0x080;
      public const int kTextFlagAngle = 0x100;
      public const int kTextFlagWhiteSpace = 0x200;
      public const int kFieldFlagNone = 0x00000000;
      public const int kFieldFlagReadOnly = 0x00000001;
      public const int kFieldFlagRequired = 0x00000002;
      public const int kFieldFlagNoExport = 0x00000004;
      public const int kFieldFlagMultiline = 0x00001000;
      public const int kFieldFlagPassword = 0x00002000;
      public const int kFieldFlagNoToggleToOff = 0x00004000;
      public const int kFieldFlagRadio = 0x00008000;
      public const int kFieldFlagPushButton = 0x00010000;
      public const int kFieldFlagCombo = 0x00200000;
      public const int kFieldFlagEdit = 0x00400000;
      public const int kFieldFlagSort = 0x00800000;
      public const int kFieldFlagMultiSelect = 0x00200000;
      public const int kFieldFlagDoNotSpellCheck = 0x00400000;
      public const int kFieldFlagDCommitOnSelChange = 0x04000000;
      public const int kFieldFlagFileSelect = 0x00100000;
      public const int kFieldFlagDoNotScroll = 0x00800000;
      public const int kFieldFlagComb = 0x01000000;
      public const int kFieldFlagRichText = 0x02000000;
      public const int kFieldFlagRadiosInUnison = 0x02000000;
      public const int kRenderAnnot = 0x001;
      public const int kRenderLCDText = 0x002;
      public const int kRenderNoNativeText = 0x004;
      public const int kRenderGrayscale = 0x008;
      public const int kRenderLimitedCache = 0x010;
      public const int kRenderForceHalftone = 0x020;
      public const int kRenderPrinting = 0x040;
      public const int kRenderNoText = 0x080;
      public const int kRenderNoBackground = 0x100;
      public const int kFontFixedPitch = 0x00001;
      public const int kFontSerif = 0x00002;
      public const int kFontSymbolic = 0x00004;
      public const int kFontScript = 0x00008;
      public const int kFontNotSymbolic = 0x00020;
      public const int kFontItalic = 0x00040;
      public const int kFontAllCap = 0x10000;
      public const int kFontSmallCap = 0x20000;
      public const int kFontForceBold = 0x40000;
      public const int kWordHyphen = 0x0001;
      public const int kWordBullet = 0x0002;
      public const int kWordFilling = 0x0008;
      public const int kWordNumber = 0x0010;
      public const int kWordImage = 0x10000;
      public const int kTextLineNewLine = 0x0001;
      public const int kTextLineBullet = 0x0002;
      public const int kTextLineHyphen = 0x0004;
      public const int kTextLineIndent = 0x0008;
      public const int kTextLineDropCap = 0x0010;

      public Pdfix() : base(IntPtr.Zero)
      {
        m_obj = GetPdfix();
      }
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode)]
      internal static extern IntPtr GetPdfix();
      public Pdfix(IntPtr obj) : base(obj) { }
      public void Destroy()
      {
        CheckBaseObj();
        PdfixDestroy(m_obj);
      }
      public bool Authorize(string _email, string _serial_number)
      {
        CheckBaseObj();
        bool ret = PdfixAuthorize(m_obj, _email, _serial_number);
        return ret;
      }
      public bool IsAuthorized()
      {
        CheckBaseObj();
        bool ret = PdfixIsAuthorized(m_obj);
        return ret;
      }
      public bool IsAuthorizedPlatform(PdfAuthPlatform _platform)
      {
        CheckBaseObj();
        bool ret = PdfixIsAuthorizedPlatform(m_obj, (int)_platform);
        return ret;
      }
      public bool IsAuthorizedOption(PdfAuthOption _option)
      {
        CheckBaseObj();
        bool ret = PdfixIsAuthorizedOption(m_obj, (int)_option);
        return ret;
      }
      public int GetErrorType()
      {
        CheckBaseObj();
        int ret = PdfixGetErrorType(m_obj);
        return ret;
      }
      public string GetError()
      {
        CheckBaseObj();
        string ret = PdfixGetError(m_obj);
        return ret;
      }
      public void SetError(int _type, string _error)
      {
        CheckBaseObj();
        PdfixSetError(m_obj, _type, _error);
      }
      public int GetVersionMajor()
      {
        CheckBaseObj();
        int ret = PdfixGetVersionMajor(m_obj);
        return ret;
      }
      public int GetVersionMinor()
      {
        CheckBaseObj();
        int ret = PdfixGetVersionMinor(m_obj);
        return ret;
      }
      public int GetVersionPatch()
      {
        CheckBaseObj();
        int ret = PdfixGetVersionPatch(m_obj);
        return ret;
      }
      public PdfDoc OpenDoc(string _path, string _password)
      {
        CheckBaseObj();
        IntPtr ret = PdfixOpenDoc(m_obj, _path, _password);
        if (ret != IntPtr.Zero)
        {
          return new PdfDoc(ret);
        }
        return null;
      }
      public PdfDoc OpenDocFromStream(PsStream _stream, string _password)
      {
        CheckBaseObj();
        IntPtr ret = PdfixOpenDocFromStream(m_obj, _stream.m_obj, _password);
        if (ret != IntPtr.Zero)
        {
          return new PdfDoc(ret);
        }
        return null;
      }
      public PdfDigSig CreateDigSig()
      {
        CheckBaseObj();
        IntPtr ret = PdfixCreateDigSig(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfDigSig(ret);
        }
        return null;
      }
      public PdfCertDigSig CreateCertDigSig()
      {
        CheckBaseObj();
        IntPtr ret = PdfixCreateCertDigSig(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfCertDigSig(ret);
        }
        return null;
      }
      public PsRegex CreateRegex()
      {
        CheckBaseObj();
        IntPtr ret = PdfixCreateRegex(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PsRegex(ret);
        }
        return null;
      }
      public PsFileStream CreateFileStream(string _path, PsFileMode _mode)
      {
        CheckBaseObj();
        IntPtr ret = PdfixCreateFileStream(m_obj, _path, (int)_mode);
        if (ret != IntPtr.Zero)
        {
          return new PsFileStream(ret);
        }
        return null;
      }
      public PsMemoryStream CreateMemStream()
      {
        CheckBaseObj();
        IntPtr ret = PdfixCreateMemStream(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PsMemoryStream(ret);
        }
        return null;
      }
      public PsProcStream CreateCustomStream(PsStreamProc _read_proc, IntPtr _client_data)
      {
        CheckBaseObj();
        IntPtr ret = PdfixCreateCustomStream(m_obj, _read_proc, _client_data);
        if (ret != IntPtr.Zero)
        {
          return new PsProcStream(ret);
        }
        return null;
      }
      public bool RegisterEvent(PdfEventType _type, PdfEventProc _proc, IntPtr _data)
      {
        CheckBaseObj();
        bool ret = PdfixRegisterEvent(m_obj, (int)_type, _proc, _data);
        return ret;
      }
      public bool UnregisterEvent(PdfEventType _type, PdfEventProc _proc, IntPtr _data)
      {
        CheckBaseObj();
        bool ret = PdfixUnregisterEvent(m_obj, (int)_type, _proc, _data);
        return ret;
      }
      public void SetRegex(PdfRegexType _type, string _regex)
      {
        CheckBaseObj();
        PdfixSetRegex(m_obj, (int)_type, _regex);
      }
      public PsImage CreateImage(int _width, int _height, PsImageDIBFormat _format)
      {
        CheckBaseObj();
        IntPtr ret = PdfixCreateImage(m_obj, _width, _height, (int)_format);
        if (ret != IntPtr.Zero)
        {
          return new PsImage(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixDestroy(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfixAuthorize(IntPtr obj, string _email, string _serial_number);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfixIsAuthorized(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfixIsAuthorizedPlatform(IntPtr obj, int _platform);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfixIsAuthorizedOption(IntPtr obj, int _option);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetErrorType(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern string PdfixGetError(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixSetError(IntPtr obj, int _type, string _error);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionMajor(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionMinor(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionPatch(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixOpenDoc(IntPtr obj, string _path, string _password);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixOpenDocFromStream(IntPtr obj, IntPtr _stream, string _password);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateDigSig(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateCertDigSig(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateRegex(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateFileStream(IntPtr obj, string _path, int _mode);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateMemStream(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateCustomStream(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PsStreamProc _read_proc, IntPtr _client_data);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfixRegisterEvent(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfixUnregisterEvent(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixSetRegex(IntPtr obj, int _type, string _regex);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateImage(IntPtr obj, int _width, int _height, int _format);
    }
    public class PdfixPlugin : PdfixBase
    {
      public PdfixPlugin(IntPtr obj) : base(obj) { }
      public void Destroy()
      {
        CheckBaseObj();
        PdfixPluginDestroy(m_obj);
      }
      public bool Initialize(Pdfix _pdfix)
      {
        CheckBaseObj();
        bool ret = PdfixPluginInitialize(m_obj, _pdfix.m_obj);
        return ret;
      }
      public int GetVersionMajor()
      {
        CheckBaseObj();
        int ret = PdfixPluginGetVersionMajor(m_obj);
        return ret;
      }
      public int GetVersionMinor()
      {
        CheckBaseObj();
        int ret = PdfixPluginGetVersionMinor(m_obj);
        return ret;
      }
      public int GetVersionPatch()
      {
        CheckBaseObj();
        int ret = PdfixPluginGetVersionPatch(m_obj);
        return ret;
      }
      public Pdfix GetPdfix()
      {
        CheckBaseObj();
        IntPtr ret = PdfixPluginGetPdfix(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new Pdfix(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixPluginDestroy(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfixPluginInitialize(IntPtr obj, IntPtr _pdfix);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionMajor(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionMinor(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionPatch(IntPtr obj);
      [DllImport("pdfix.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixPluginGetPdfix(IntPtr obj);
    }
  }
}
