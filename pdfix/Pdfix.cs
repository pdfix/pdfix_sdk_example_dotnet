////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2020 PDFix (http://pdfix.net). All Rights Reserved.
// This file was generated automatically
////////////////////////////////////////////////////////////////////////////////
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
      static internal bool Is64BitProcess()
      {
        return IntPtr.Size == 8;
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
      kEventPageContentsDidChange = 11,
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
    public enum PdfPageObjectType
    {
      kPdsPageUnknown = 0,
      kPdsPageText = 1,
      kPdsPagePath = 2,
      kPdsPageImage = 3,
      kPdsPageShading = 4,
      kPdsPageForm = 5,
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
      kPdeAnnot = 16,
    }
    public enum PdfContainerType
    {
      kPdeContainerUnknown = 0,
      kPdeContainerPage = 1,
      kPdeContainerArt = 2,
    }
    public enum PdfTagType
    {
      kTagUnknown = 0,
      kTagSect = 1,
      kTagArt = 2,
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
      kImageForm = 5,
    }
    public enum PdfListType
    {
      kListNone = 0,
      kListUnordered = 1,
      kListOrdered = 2,
      kListDecimal = 3,
      kListRomanUpper = 4,
      kListRomanLower = 5,
      kListLetterUpper = 6,
      kListLetterLower = 7,
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
      kTextTitle = 10,
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
    public enum PdfStructElementType
    {
      kPdsStructKidInvalid = 0,
      kPdsStructKidElement = 1,
      kPdsStructKidPageContent = 2,
      kPdsStructKidStreamContent = 3,
      kPdsStructKidObject = 4,
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
      public PdfRectInt clip_box;
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
      public int create_bookmarks;
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
      public PdfRect clip_box;
      public int render_flags;
      public PdfPageRenderParams(IntPtr _device, PsImage _image, PdfMatrix _matrix, PdfRect _clip_box, int _render_flags)
      {
        device = _device;
        image = _image;
        matrix = _matrix;
        clip_box = _clip_box;
        render_flags = _render_flags;
      }
      internal PdfPageRenderParamsInt GetIntStruct()
      {
        PdfPageRenderParamsInt result = new PdfPageRenderParamsInt();
        result.device = device;
        result.image = (IntPtr)image.m_obj;
        result.matrix = (PdfMatrixInt)matrix.GetIntStruct();
        result.clip_box = (PdfRectInt)clip_box.GetIntStruct();
        result.render_flags = render_flags;
        return result;
      }
      internal void SetIntStruct(PdfPageRenderParamsInt inStruct)
      {
        device = inStruct.device;
        image = new PsImage((IntPtr)inStruct.image);
        matrix = new PdfMatrix();
        matrix.SetIntStruct(inStruct.matrix);
        clip_box = new PdfRect();
        clip_box.SetIntStruct(inStruct.clip_box);
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
      public PdfAnnotSubtype flags;
      public PdfFlattenAnnotsParams(PdfPageRangeParams _page_range, PdfAnnotSubtype _flags)
      {
        page_range = _page_range;
        flags = _flags;
      }
      internal PdfFlattenAnnotsParamsInt GetIntStruct()
      {
        PdfFlattenAnnotsParamsInt result = new PdfFlattenAnnotsParamsInt();
        result.page_range = (PdfPageRangeParamsInt)page_range.GetIntStruct();
        result.flags = (int)flags;
        return result;
      }
      internal void SetIntStruct(PdfFlattenAnnotsParamsInt inStruct)
      {
        page_range = new PdfPageRangeParams();
        page_range.SetIntStruct(inStruct.page_range);
        flags = (PdfAnnotSubtype)inStruct.flags;
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
      public int create_bookmarks;
      public PdfAccessibleParams(int _accept_tags, int _embed_fonts, int _subset_fonts, int _create_bookmarks)
      {
        accept_tags = _accept_tags;
        embed_fonts = _embed_fonts;
        subset_fonts = _subset_fonts;
        create_bookmarks = _create_bookmarks;
      }
      internal PdfAccessibleParamsInt GetIntStruct()
      {
        PdfAccessibleParamsInt result = new PdfAccessibleParamsInt();
        result.accept_tags = accept_tags;
        result.embed_fonts = embed_fonts;
        result.subset_fonts = subset_fonts;
        result.create_bookmarks = create_bookmarks;
        return result;
      }
      internal void SetIntStruct(PdfAccessibleParamsInt inStruct)
      {
        accept_tags = inStruct.accept_tags;
        embed_fonts = inStruct.embed_fonts;
        subset_fonts = inStruct.subset_fonts;
        create_bookmarks = inStruct.create_bookmarks;
      }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PdfCancelProc(IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PdfEventProc(IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PsStreamProc(string _buffer, int _offset, int _size, IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PsStreamDestroyProc(IntPtr _data);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PsStreamGetSizeProc(IntPtr _data);

    public class PdsObject : PdfixBase
    {
      public PdsObject(IntPtr obj) : base(obj) { }
      public PdfObjectType GetObjectType()
      {
        CheckBaseObj();
        PdfObjectType ret = PdsObjectGetObjectType(m_obj);
        return ret;
      }
      public int GetId()
      {
        CheckBaseObj();
        int ret = PdsObjectGetId(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsObjectGetObjectType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfObjectType PdsObjectGetObjectType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsObjectGetObjectType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfObjectType PdsObjectGetObjectType64(IntPtr obj);
      internal static PdfObjectType PdsObjectGetObjectType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsObjectGetObjectType64(obj);
        else return PdsObjectGetObjectType32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsObjectGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsObjectGetId32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsObjectGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsObjectGetId64(IntPtr obj);
      internal static int PdsObjectGetId(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsObjectGetId64(obj);
        else return PdsObjectGetId32(obj);
      }
    }
    public class PdsBoolean : PdsObject    {
      public PdsBoolean(IntPtr obj) : base(obj) { }
      public bool GetValue()
      {
        CheckBaseObj();
        byte ret = PdsBooleanGetValue(m_obj);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsBooleanGetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsBooleanGetValue32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsBooleanGetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsBooleanGetValue64(IntPtr obj);
      internal static byte PdsBooleanGetValue(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsBooleanGetValue64(obj);
        else return PdsBooleanGetValue32(obj);
      }
    }
    public class PdsNumber : PdsObject    {
      public PdsNumber(IntPtr obj) : base(obj) { }
      public bool IsIntegerValue()
      {
        CheckBaseObj();
        byte ret = PdsNumberIsIntegerValue(m_obj);
        return ret != 0;
      }
      public int GetIntegerValue()
      {
        CheckBaseObj();
        int ret = PdsNumberGetIntegerValue(m_obj);
        return ret;
      }
      public double GetValue()
      {
        CheckBaseObj();
        double ret = PdsNumberGetValue(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsNumberIsIntegerValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsNumberIsIntegerValue32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsNumberIsIntegerValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsNumberIsIntegerValue64(IntPtr obj);
      internal static byte PdsNumberIsIntegerValue(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsNumberIsIntegerValue64(obj);
        else return PdsNumberIsIntegerValue32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsNumberGetIntegerValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsNumberGetIntegerValue32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsNumberGetIntegerValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsNumberGetIntegerValue64(IntPtr obj);
      internal static int PdsNumberGetIntegerValue(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsNumberGetIntegerValue64(obj);
        else return PdsNumberGetIntegerValue32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsNumberGetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdsNumberGetValue32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsNumberGetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdsNumberGetValue64(IntPtr obj);
      internal static double PdsNumberGetValue(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsNumberGetValue64(obj);
        else return PdsNumberGetValue32(obj);
      }
    }
    public class PdsString : PdsObject    {
      public PdsString(IntPtr obj) : base(obj) { }
      public int GetValue(string _buffer, int _len)
      {
        CheckBaseObj();
        int ret = PdsStringGetValue(m_obj, _buffer, _len);
        return ret;
      }
      public string GetText()
      {
        CheckBaseObj();
        int _buffer_sz = PdsStringGetText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStringGetText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsStringGetValue", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStringGetValue32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStringGetValue", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStringGetValue64(IntPtr obj, string _buffer, int _len);
      internal static int PdsStringGetValue(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStringGetValue64(obj, _buffer, _len);
        else return PdsStringGetValue32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStringGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStringGetText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStringGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStringGetText64(IntPtr obj, string _buffer, int _len);
      internal static int PdsStringGetText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStringGetText64(obj, _buffer, _len);
        else return PdsStringGetText32(obj, _buffer, _len);
      }
    }
    public class PdsName : PdsObject    {
      public PdsName(IntPtr obj) : base(obj) { }
      public int GetValue(string _buffer, int _len)
      {
        CheckBaseObj();
        int ret = PdsNameGetValue(m_obj, _buffer, _len);
        return ret;
      }
      public string GetText()
      {
        CheckBaseObj();
        int _buffer_sz = PdsNameGetText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsNameGetText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsNameGetValue", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsNameGetValue32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsNameGetValue", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsNameGetValue64(IntPtr obj, string _buffer, int _len);
      internal static int PdsNameGetValue(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsNameGetValue64(obj, _buffer, _len);
        else return PdsNameGetValue32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsNameGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsNameGetText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsNameGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsNameGetText64(IntPtr obj, string _buffer, int _len);
      internal static int PdsNameGetText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsNameGetText64(obj, _buffer, _len);
        else return PdsNameGetText32(obj, _buffer, _len);
      }
    }
    public class PdsArray : PdsObject    {
      public PdsArray(IntPtr obj) : base(obj) { }
      public int GetNumObjects()
      {
        CheckBaseObj();
        int ret = PdsArrayGetNumObjects(m_obj);
        return ret;
      }
      public PdsObject Get(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsArrayGet(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public bool Put(int _index, PdsObject _value)
      {
        CheckBaseObj();
        byte ret = PdsArrayPut(m_obj, _index, _value == null ? IntPtr.Zero : _value.m_obj);
        return ret != 0;
      }
      public bool Insert(int _index, PdsObject _value)
      {
        CheckBaseObj();
        byte ret = PdsArrayInsert(m_obj, _index, _value == null ? IntPtr.Zero : _value.m_obj);
        return ret != 0;
      }
      public PdsDictionary GetDictionary(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsArrayGetDictionary(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public PdsArray GetArray(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsArrayGetArray(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdsArray(ret);
        }
        return null;
      }
      public PdsStream GetStream(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsArrayGetStream(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdsStream(ret);
        }
        return null;
      }
      public int GetString(int _index, string _buffer, int _len)
      {
        CheckBaseObj();
        int ret = PdsArrayGetString(m_obj, _index, _buffer, _len);
        return ret;
      }
      public string GetText(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdsArrayGetText(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsArrayGetText(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public double GetNumber(int _index)
      {
        CheckBaseObj();
        double ret = PdsArrayGetNumber(m_obj, _index);
        return ret;
      }
      public int GetInteger(int _index)
      {
        CheckBaseObj();
        int ret = PdsArrayGetInteger(m_obj, _index);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetNumObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetNumObjects32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetNumObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetNumObjects64(IntPtr obj);
      internal static int PdsArrayGetNumObjects(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetNumObjects64(obj);
        else return PdsArrayGetNumObjects32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGet", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGet32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGet", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGet64(IntPtr obj, int _index);
      internal static IntPtr PdsArrayGet(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsArrayGet64(obj, _index);
        else return PdsArrayGet32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayPut", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsArrayPut32(IntPtr obj, int _index, IntPtr _value);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayPut", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsArrayPut64(IntPtr obj, int _index, IntPtr _value);
      internal static byte PdsArrayPut(IntPtr obj, int _index, IntPtr _value)
      {
        if (Util.Is64BitProcess()) return PdsArrayPut64(obj, _index, _value);
        else return PdsArrayPut32(obj, _index, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayInsert", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsArrayInsert32(IntPtr obj, int _index, IntPtr _value);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayInsert", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsArrayInsert64(IntPtr obj, int _index, IntPtr _value);
      internal static byte PdsArrayInsert(IntPtr obj, int _index, IntPtr _value)
      {
        if (Util.Is64BitProcess()) return PdsArrayInsert64(obj, _index, _value);
        else return PdsArrayInsert32(obj, _index, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetDictionary", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGetDictionary32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetDictionary", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGetDictionary64(IntPtr obj, int _index);
      internal static IntPtr PdsArrayGetDictionary(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetDictionary64(obj, _index);
        else return PdsArrayGetDictionary32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetArray", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGetArray32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetArray", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGetArray64(IntPtr obj, int _index);
      internal static IntPtr PdsArrayGetArray(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetArray64(obj, _index);
        else return PdsArrayGetArray32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGetStream32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsArrayGetStream64(IntPtr obj, int _index);
      internal static IntPtr PdsArrayGetStream(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetStream64(obj, _index);
        else return PdsArrayGetStream32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetString", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetString32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetString", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetString64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdsArrayGetString(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetString64(obj, _index, _buffer, _len);
        else return PdsArrayGetString32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetText32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetText64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdsArrayGetText(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetText64(obj, _index, _buffer, _len);
        else return PdsArrayGetText32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdsArrayGetNumber32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdsArrayGetNumber64(IntPtr obj, int _index);
      internal static double PdsArrayGetNumber(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetNumber64(obj, _index);
        else return PdsArrayGetNumber32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsArrayGetInteger", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetInteger32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsArrayGetInteger", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsArrayGetInteger64(IntPtr obj, int _index);
      internal static int PdsArrayGetInteger(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsArrayGetInteger64(obj, _index);
        else return PdsArrayGetInteger32(obj, _index);
      }
    }
    public class PdsDictionary : PdsObject    {
      public PdsDictionary(IntPtr obj) : base(obj) { }
      public bool Known(string _key)
      {
        CheckBaseObj();
        byte ret = PdsDictionaryKnown(m_obj, _key);
        return ret != 0;
      }
      public int GetNumKeys()
      {
        CheckBaseObj();
        int ret = PdsDictionaryGetNumKeys(m_obj);
        return ret;
      }
      public string GetKey(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdsDictionaryGetKey(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsDictionaryGetKey(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdsObject Get(string _key)
      {
        CheckBaseObj();
        IntPtr ret = PdsDictionaryGet(m_obj, _key);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public bool Put(string _key, PdsObject _value)
      {
        CheckBaseObj();
        byte ret = PdsDictionaryPut(m_obj, _key, _value == null ? IntPtr.Zero : _value.m_obj);
        return ret != 0;
      }
      public PdsDictionary GetDictionary(string _key)
      {
        CheckBaseObj();
        IntPtr ret = PdsDictionaryGetDictionary(m_obj, _key);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public PdsArray GetArray(string _key)
      {
        CheckBaseObj();
        IntPtr ret = PdsDictionaryGetArray(m_obj, _key);
        if (ret != IntPtr.Zero)
        {
          return new PdsArray(ret);
        }
        return null;
      }
      public PdsStream GetStream(string _key)
      {
        CheckBaseObj();
        IntPtr ret = PdsDictionaryGetStream(m_obj, _key);
        if (ret != IntPtr.Zero)
        {
          return new PdsStream(ret);
        }
        return null;
      }
      public int GetString(string _key, string _buffer, int _len)
      {
        CheckBaseObj();
        int ret = PdsDictionaryGetString(m_obj, _key, _buffer, _len);
        return ret;
      }
      public string GetText(string _key)
      {
        CheckBaseObj();
        int _buffer_sz = PdsDictionaryGetText(m_obj, _key, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsDictionaryGetText(m_obj, _key, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public double GetNumber(string _key)
      {
        CheckBaseObj();
        double ret = PdsDictionaryGetNumber(m_obj, _key);
        return ret;
      }
      public int GetInteger(string _key, int _default_value)
      {
        CheckBaseObj();
        int ret = PdsDictionaryGetInteger(m_obj, _key, _default_value);
        return ret;
      }
      public bool GetBoolean(string _key, bool _default_value)
      {
        CheckBaseObj();
        byte ret = PdsDictionaryGetBoolean(m_obj, _key, _default_value);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryKnown", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsDictionaryKnown32(IntPtr obj, string _key);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryKnown", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsDictionaryKnown64(IntPtr obj, string _key);
      internal static byte PdsDictionaryKnown(IntPtr obj, string _key)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryKnown64(obj, _key);
        else return PdsDictionaryKnown32(obj, _key);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetNumKeys", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetNumKeys32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetNumKeys", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetNumKeys64(IntPtr obj);
      internal static int PdsDictionaryGetNumKeys(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetNumKeys64(obj);
        else return PdsDictionaryGetNumKeys32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetKey", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetKey32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetKey", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetKey64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdsDictionaryGetKey(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetKey64(obj, _index, _buffer, _len);
        else return PdsDictionaryGetKey32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGet", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGet32(IntPtr obj, string _key);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGet", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGet64(IntPtr obj, string _key);
      internal static IntPtr PdsDictionaryGet(IntPtr obj, string _key)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGet64(obj, _key);
        else return PdsDictionaryGet32(obj, _key);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryPut", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsDictionaryPut32(IntPtr obj, string _key, IntPtr _value);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryPut", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsDictionaryPut64(IntPtr obj, string _key, IntPtr _value);
      internal static byte PdsDictionaryPut(IntPtr obj, string _key, IntPtr _value)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryPut64(obj, _key, _value);
        else return PdsDictionaryPut32(obj, _key, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetDictionary", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGetDictionary32(IntPtr obj, string _key);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetDictionary", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGetDictionary64(IntPtr obj, string _key);
      internal static IntPtr PdsDictionaryGetDictionary(IntPtr obj, string _key)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetDictionary64(obj, _key);
        else return PdsDictionaryGetDictionary32(obj, _key);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetArray", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGetArray32(IntPtr obj, string _key);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetArray", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGetArray64(IntPtr obj, string _key);
      internal static IntPtr PdsDictionaryGetArray(IntPtr obj, string _key)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetArray64(obj, _key);
        else return PdsDictionaryGetArray32(obj, _key);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGetStream32(IntPtr obj, string _key);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsDictionaryGetStream64(IntPtr obj, string _key);
      internal static IntPtr PdsDictionaryGetStream(IntPtr obj, string _key)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetStream64(obj, _key);
        else return PdsDictionaryGetStream32(obj, _key);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetString", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetString32(IntPtr obj, string _key, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetString", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetString64(IntPtr obj, string _key, string _buffer, int _len);
      internal static int PdsDictionaryGetString(IntPtr obj, string _key, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetString64(obj, _key, _buffer, _len);
        else return PdsDictionaryGetString32(obj, _key, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetText32(IntPtr obj, string _key, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetText64(IntPtr obj, string _key, string _buffer, int _len);
      internal static int PdsDictionaryGetText(IntPtr obj, string _key, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetText64(obj, _key, _buffer, _len);
        else return PdsDictionaryGetText32(obj, _key, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdsDictionaryGetNumber32(IntPtr obj, string _key);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdsDictionaryGetNumber64(IntPtr obj, string _key);
      internal static double PdsDictionaryGetNumber(IntPtr obj, string _key)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetNumber64(obj, _key);
        else return PdsDictionaryGetNumber32(obj, _key);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetInteger", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetInteger32(IntPtr obj, string _key, int _default_value);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetInteger", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsDictionaryGetInteger64(IntPtr obj, string _key, int _default_value);
      internal static int PdsDictionaryGetInteger(IntPtr obj, string _key, int _default_value)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetInteger64(obj, _key, _default_value);
        else return PdsDictionaryGetInteger32(obj, _key, _default_value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsDictionaryGetBoolean", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsDictionaryGetBoolean32(IntPtr obj, string _key, bool _default_value);
      [DllImport("pdfix64.dll", EntryPoint="PdsDictionaryGetBoolean", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsDictionaryGetBoolean64(IntPtr obj, string _key, bool _default_value);
      internal static byte PdsDictionaryGetBoolean(IntPtr obj, string _key, bool _default_value)
      {
        if (Util.Is64BitProcess()) return PdsDictionaryGetBoolean64(obj, _key, _default_value);
        else return PdsDictionaryGetBoolean32(obj, _key, _default_value);
      }
    }
    public class PdsStream : PdsObject    {
      public PdsStream(IntPtr obj) : base(obj) { }
      public PdsDictionary GetStreamDict()
      {
        CheckBaseObj();
        IntPtr ret = PdsStreamGetStreamDict(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public int GetRawDataSize()
      {
        CheckBaseObj();
        int ret = PdsStreamGetRawDataSize(m_obj);
        return ret;
      }
      public bool IsEof()
      {
        CheckBaseObj();
        byte ret = PdsStreamIsEof(m_obj);
        return ret != 0;
      }
      public int GetSize()
      {
        CheckBaseObj();
        int ret = PdsStreamGetSize(m_obj);
        return ret;
      }
      public bool Read(int _offset, byte[] _buffer)
      {
        CheckBaseObj();
        IntPtr _buffer_ptr = Marshal.AllocHGlobal(_buffer.Length);
        byte ret = PdsStreamRead(m_obj, _offset, _buffer_ptr, _buffer.Length);
        if (ret != 0) Marshal.Copy(_buffer_ptr, _buffer, 0, _buffer.Length);
        Marshal.FreeHGlobal(_buffer_ptr);
        _buffer_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public int GetPos()
      {
        CheckBaseObj();
        int ret = PdsStreamGetPos(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsStreamGetStreamDict", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStreamGetStreamDict32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStreamGetStreamDict", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStreamGetStreamDict64(IntPtr obj);
      internal static IntPtr PdsStreamGetStreamDict(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStreamGetStreamDict64(obj);
        else return PdsStreamGetStreamDict32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStreamGetRawDataSize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStreamGetRawDataSize32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStreamGetRawDataSize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStreamGetRawDataSize64(IntPtr obj);
      internal static int PdsStreamGetRawDataSize(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStreamGetRawDataSize64(obj);
        else return PdsStreamGetRawDataSize32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStreamIsEof", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStreamIsEof32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStreamIsEof", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStreamIsEof64(IntPtr obj);
      internal static byte PdsStreamIsEof(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStreamIsEof64(obj);
        else return PdsStreamIsEof32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStreamGetSize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStreamGetSize32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStreamGetSize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStreamGetSize64(IntPtr obj);
      internal static int PdsStreamGetSize(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStreamGetSize64(obj);
        else return PdsStreamGetSize32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStreamRead", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStreamRead32(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      [DllImport("pdfix64.dll", EntryPoint="PdsStreamRead", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStreamRead64(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      internal static byte PdsStreamRead(IntPtr obj, int _offset, IntPtr _buffer, int _size)
      {
        if (Util.Is64BitProcess()) return PdsStreamRead64(obj, _offset, _buffer, _size);
        else return PdsStreamRead32(obj, _offset, _buffer, _size);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStreamGetPos", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStreamGetPos32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStreamGetPos", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStreamGetPos64(IntPtr obj);
      internal static int PdsStreamGetPos(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStreamGetPos64(obj);
        else return PdsStreamGetPos32(obj);
      }
    }
    public class PdsNull : PdsObject    {
      public PdsNull(IntPtr obj) : base(obj) { }

    }
    public class PdsPageObject : PdfixBase
    {
      public PdsPageObject(IntPtr obj) : base(obj) { }
      public PdfPageObjectType GetObjectType()
      {
        CheckBaseObj();
        PdfPageObjectType ret = PdsPageObjectGetObjectType(m_obj);
        return ret;
      }
      public PdfRect GetBBox()
      {
        CheckBaseObj();
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        PdsPageObjectGetBBox(m_obj, _bbox_ptr);
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
        int ret = PdsPageObjectGetId(m_obj);
        return ret;
      }
      public void SetRender(bool _render)
      {
        CheckBaseObj();
        PdsPageObjectSetRender(m_obj, _render);
      }
      public PdsObject GetStructObject(bool _struct_parent)
      {
        CheckBaseObj();
        IntPtr ret = PdsPageObjectGetStructObject(m_obj, _struct_parent);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public PdsContentMark GetContentMark()
      {
        CheckBaseObj();
        IntPtr ret = PdsPageObjectGetContentMark(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsContentMark(ret);
        }
        return null;
      }
      public PdfPage GetPage()
      {
        CheckBaseObj();
        IntPtr ret = PdsPageObjectGetPage(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfPage(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsPageObjectGetObjectType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfPageObjectType PdsPageObjectGetObjectType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsPageObjectGetObjectType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfPageObjectType PdsPageObjectGetObjectType64(IntPtr obj);
      internal static PdfPageObjectType PdsPageObjectGetObjectType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsPageObjectGetObjectType64(obj);
        else return PdsPageObjectGetObjectType32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsPageObjectGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsPageObjectGetBBox32(IntPtr obj, IntPtr _bbox);
      [DllImport("pdfix64.dll", EntryPoint="PdsPageObjectGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsPageObjectGetBBox64(IntPtr obj, IntPtr _bbox);
      internal static void PdsPageObjectGetBBox(IntPtr obj, IntPtr _bbox)
      {
        if (Util.Is64BitProcess()) PdsPageObjectGetBBox64(obj, _bbox);
        else PdsPageObjectGetBBox32(obj, _bbox);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsPageObjectGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsPageObjectGetId32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsPageObjectGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsPageObjectGetId64(IntPtr obj);
      internal static int PdsPageObjectGetId(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsPageObjectGetId64(obj);
        else return PdsPageObjectGetId32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsPageObjectSetRender", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsPageObjectSetRender32(IntPtr obj, bool _render);
      [DllImport("pdfix64.dll", EntryPoint="PdsPageObjectSetRender", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsPageObjectSetRender64(IntPtr obj, bool _render);
      internal static void PdsPageObjectSetRender(IntPtr obj, bool _render)
      {
        if (Util.Is64BitProcess()) PdsPageObjectSetRender64(obj, _render);
        else PdsPageObjectSetRender32(obj, _render);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsPageObjectGetStructObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsPageObjectGetStructObject32(IntPtr obj, bool _struct_parent);
      [DllImport("pdfix64.dll", EntryPoint="PdsPageObjectGetStructObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsPageObjectGetStructObject64(IntPtr obj, bool _struct_parent);
      internal static IntPtr PdsPageObjectGetStructObject(IntPtr obj, bool _struct_parent)
      {
        if (Util.Is64BitProcess()) return PdsPageObjectGetStructObject64(obj, _struct_parent);
        else return PdsPageObjectGetStructObject32(obj, _struct_parent);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsPageObjectGetContentMark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsPageObjectGetContentMark32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsPageObjectGetContentMark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsPageObjectGetContentMark64(IntPtr obj);
      internal static IntPtr PdsPageObjectGetContentMark(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsPageObjectGetContentMark64(obj);
        else return PdsPageObjectGetContentMark32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsPageObjectGetPage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsPageObjectGetPage32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsPageObjectGetPage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsPageObjectGetPage64(IntPtr obj);
      internal static IntPtr PdsPageObjectGetPage(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsPageObjectGetPage64(obj);
        else return PdsPageObjectGetPage32(obj);
      }
    }
    public class PdsText : PdsPageObject    {
      public PdsText(IntPtr obj) : base(obj) { }
      public string GetText()
      {
        CheckBaseObj();
        int _buffer_sz = PdsTextGetText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsTextGetText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdfTextState GetTextState(PdfDoc _doc)
      {
        CheckBaseObj();
        IntPtr _text_state_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfTextStateInt)));
        byte ret = PdsTextGetTextState(m_obj, _doc == null ? IntPtr.Zero : _doc.m_obj, _text_state_ptr);
        PdfTextStateInt _text_stateInt = (PdfTextStateInt)Marshal.PtrToStructure(_text_state_ptr, typeof(PdfTextStateInt));
        PdfTextState _text_state = new PdfTextState();
        _text_state.SetIntStruct(_text_stateInt);
        Marshal.FreeHGlobal(_text_state_ptr);
        _text_state_ptr = IntPtr.Zero;
        return _text_state;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsTextGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsTextGetText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsTextGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsTextGetText64(IntPtr obj, string _buffer, int _len);
      internal static int PdsTextGetText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsTextGetText64(obj, _buffer, _len);
        else return PdsTextGetText32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsTextGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsTextGetTextState32(IntPtr obj, IntPtr _doc, IntPtr _text_state);
      [DllImport("pdfix64.dll", EntryPoint="PdsTextGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsTextGetTextState64(IntPtr obj, IntPtr _doc, IntPtr _text_state);
      internal static byte PdsTextGetTextState(IntPtr obj, IntPtr _doc, IntPtr _text_state)
      {
        if (Util.Is64BitProcess()) return PdsTextGetTextState64(obj, _doc, _text_state);
        else return PdsTextGetTextState32(obj, _doc, _text_state);
      }
    }
    public class PdsForm : PdsPageObject    {
      public PdsForm(IntPtr obj) : base(obj) { }
      public int GetNumPageObjects()
      {
        CheckBaseObj();
        int ret = PdsFormGetNumPageObjects(m_obj);
        return ret;
      }
      public PdsPageObject GetPageObject(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsFormGetPageObject(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdsPageObject.PdsPageObjectGetObjectType(ret))
          {
            case PdfPageObjectType.kPdsPageText: return new PdsText(ret);
            case PdfPageObjectType.kPdsPagePath: return new PdsPath(ret);
            case PdfPageObjectType.kPdsPageImage: return new PdsImage(ret);
            case PdfPageObjectType.kPdsPageShading: return new PdsShading(ret);
            case PdfPageObjectType.kPdsPageForm: return new PdsForm(ret);
            default: return new PdsPageObject(ret);
          }
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsFormGetNumPageObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsFormGetNumPageObjects32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsFormGetNumPageObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsFormGetNumPageObjects64(IntPtr obj);
      internal static int PdsFormGetNumPageObjects(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsFormGetNumPageObjects64(obj);
        else return PdsFormGetNumPageObjects32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsFormGetPageObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsFormGetPageObject32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsFormGetPageObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsFormGetPageObject64(IntPtr obj, int _index);
      internal static IntPtr PdsFormGetPageObject(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsFormGetPageObject64(obj, _index);
        else return PdsFormGetPageObject32(obj, _index);
      }
    }
    public class PdsPath : PdsPageObject    {
      public PdsPath(IntPtr obj) : base(obj) { }

    }
    public class PdsImage : PdsPageObject    {
      public PdsImage(IntPtr obj) : base(obj) { }

    }
    public class PdsShading : PdsPageObject    {
      public PdsShading(IntPtr obj) : base(obj) { }

    }
    public class PdsContentMark : PdfixBase
    {
      public PdsContentMark(IntPtr obj) : base(obj) { }
      public int GetNumTags()
      {
        CheckBaseObj();
        int ret = PdsContentMarkGetNumTags(m_obj);
        return ret;
      }
      public string GetTagName(int _index)
      {
        CheckBaseObj();
        int _buffer_sz = PdsContentMarkGetTagName(m_obj, _index, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsContentMarkGetTagName(m_obj, _index, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public PdsDictionary GetTagObject(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsContentMarkGetTagObject(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public int GetTagMcid()
      {
        CheckBaseObj();
        int ret = PdsContentMarkGetTagMcid(m_obj);
        return ret;
      }
      public bool GetTagArtifact()
      {
        CheckBaseObj();
        byte ret = PdsContentMarkGetTagArtifact(m_obj);
        return ret != 0;
      }
      public bool AddTag(string _name, PdsDictionary _object, bool _indirect)
      {
        CheckBaseObj();
        byte ret = PdsContentMarkAddTag(m_obj, _name, _object == null ? IntPtr.Zero : _object.m_obj, _indirect);
        return ret != 0;
      }
      public bool RemoveTag(int _index)
      {
        CheckBaseObj();
        byte ret = PdsContentMarkRemoveTag(m_obj, _index);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsContentMarkGetNumTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsContentMarkGetNumTags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsContentMarkGetNumTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsContentMarkGetNumTags64(IntPtr obj);
      internal static int PdsContentMarkGetNumTags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsContentMarkGetNumTags64(obj);
        else return PdsContentMarkGetNumTags32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsContentMarkGetTagName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsContentMarkGetTagName32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsContentMarkGetTagName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsContentMarkGetTagName64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdsContentMarkGetTagName(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsContentMarkGetTagName64(obj, _index, _buffer, _len);
        else return PdsContentMarkGetTagName32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsContentMarkGetTagObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsContentMarkGetTagObject32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsContentMarkGetTagObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsContentMarkGetTagObject64(IntPtr obj, int _index);
      internal static IntPtr PdsContentMarkGetTagObject(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsContentMarkGetTagObject64(obj, _index);
        else return PdsContentMarkGetTagObject32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsContentMarkGetTagMcid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsContentMarkGetTagMcid32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsContentMarkGetTagMcid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsContentMarkGetTagMcid64(IntPtr obj);
      internal static int PdsContentMarkGetTagMcid(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsContentMarkGetTagMcid64(obj);
        else return PdsContentMarkGetTagMcid32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsContentMarkGetTagArtifact", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsContentMarkGetTagArtifact32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsContentMarkGetTagArtifact", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsContentMarkGetTagArtifact64(IntPtr obj);
      internal static byte PdsContentMarkGetTagArtifact(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsContentMarkGetTagArtifact64(obj);
        else return PdsContentMarkGetTagArtifact32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsContentMarkAddTag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsContentMarkAddTag32(IntPtr obj, string _name, IntPtr _object, bool _indirect);
      [DllImport("pdfix64.dll", EntryPoint="PdsContentMarkAddTag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsContentMarkAddTag64(IntPtr obj, string _name, IntPtr _object, bool _indirect);
      internal static byte PdsContentMarkAddTag(IntPtr obj, string _name, IntPtr _object, bool _indirect)
      {
        if (Util.Is64BitProcess()) return PdsContentMarkAddTag64(obj, _name, _object, _indirect);
        else return PdsContentMarkAddTag32(obj, _name, _object, _indirect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsContentMarkRemoveTag", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsContentMarkRemoveTag32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsContentMarkRemoveTag", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsContentMarkRemoveTag64(IntPtr obj, int _index);
      internal static byte PdsContentMarkRemoveTag(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsContentMarkRemoveTag64(obj, _index);
        else return PdsContentMarkRemoveTag32(obj, _index);
      }
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
      public bool SetBBox(PdfRect _bbox)
      {
        CheckBaseObj();
        PdfRectInt _bboxInt = _bbox.GetIntStruct();
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_bboxInt, _bbox_ptr, true);
        byte ret = PdeElementSetBBox(m_obj, _bbox_ptr);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
        return ret != 0;
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
          switch (PdeElement.PdeElementGetType(ret))
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
      public void SetRender(bool _render)
      {
        CheckBaseObj();
        PdeElementSetRender(m_obj, _render);
      }
      public void SetData(IntPtr _data)
      {
        CheckBaseObj();
        PdeElementSetData(m_obj, _data);
      }
      public IntPtr GetData()
      {
        CheckBaseObj();
        IntPtr ret = PdeElementGetData(m_obj);
        return ret;
      }
      public bool SetAlt(string _alt)
      {
        CheckBaseObj();
        byte ret = PdeElementSetAlt(m_obj, _alt);
        return ret != 0;
      }
      public bool SetActualText(string _text)
      {
        CheckBaseObj();
        byte ret = PdeElementSetActualText(m_obj, _text);
        return ret != 0;
      }
      public int GetFlags()
      {
        CheckBaseObj();
        int ret = PdeElementGetFlags(m_obj);
        return ret;
      }
      public bool SetFlags(int _flags)
      {
        CheckBaseObj();
        byte ret = PdeElementSetFlags(m_obj, _flags);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdeElementGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfElementType PdeElementGetType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfElementType PdeElementGetType64(IntPtr obj);
      internal static PdfElementType PdeElementGetType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeElementGetType64(obj);
        else return PdeElementGetType32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementGetBBox32(IntPtr obj, IntPtr _bbox);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementGetBBox64(IntPtr obj, IntPtr _bbox);
      internal static void PdeElementGetBBox(IntPtr obj, IntPtr _bbox)
      {
        if (Util.Is64BitProcess()) PdeElementGetBBox64(obj, _bbox);
        else PdeElementGetBBox32(obj, _bbox);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementSetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetBBox32(IntPtr obj, IntPtr _bbox);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementSetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetBBox64(IntPtr obj, IntPtr _bbox);
      internal static byte PdeElementSetBBox(IntPtr obj, IntPtr _bbox)
      {
        if (Util.Is64BitProcess()) return PdeElementSetBBox64(obj, _bbox);
        else return PdeElementSetBBox32(obj, _bbox);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetId32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetId64(IntPtr obj);
      internal static int PdeElementGetId(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeElementGetId64(obj);
        else return PdeElementGetId32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetGraphicState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementGetGraphicState32(IntPtr obj, IntPtr _g_state);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetGraphicState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementGetGraphicState64(IntPtr obj, IntPtr _g_state);
      internal static void PdeElementGetGraphicState(IntPtr obj, IntPtr _g_state)
      {
        if (Util.Is64BitProcess()) PdeElementGetGraphicState64(obj, _g_state);
        else PdeElementGetGraphicState32(obj, _g_state);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetNumChildren", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetNumChildren32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetNumChildren", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetNumChildren64(IntPtr obj);
      internal static int PdeElementGetNumChildren(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeElementGetNumChildren64(obj);
        else return PdeElementGetNumChildren32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetChild", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeElementGetChild32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetChild", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeElementGetChild64(IntPtr obj, int _index);
      internal static IntPtr PdeElementGetChild(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdeElementGetChild64(obj, _index);
        else return PdeElementGetChild32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetAlignment", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeElementGetAlignment32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetAlignment", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeElementGetAlignment64(IntPtr obj);
      internal static PdfAlignment PdeElementGetAlignment(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeElementGetAlignment64(obj);
        else return PdeElementGetAlignment32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetAngle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeElementGetAngle32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetAngle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeElementGetAngle64(IntPtr obj);
      internal static double PdeElementGetAngle(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeElementGetAngle64(obj);
        else return PdeElementGetAngle32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementSetRender", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementSetRender32(IntPtr obj, bool _render);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementSetRender", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementSetRender64(IntPtr obj, bool _render);
      internal static void PdeElementSetRender(IntPtr obj, bool _render)
      {
        if (Util.Is64BitProcess()) PdeElementSetRender64(obj, _render);
        else PdeElementSetRender32(obj, _render);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementSetData", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementSetData32(IntPtr obj, IntPtr _data);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementSetData", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeElementSetData64(IntPtr obj, IntPtr _data);
      internal static void PdeElementSetData(IntPtr obj, IntPtr _data)
      {
        if (Util.Is64BitProcess()) PdeElementSetData64(obj, _data);
        else PdeElementSetData32(obj, _data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetData", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeElementGetData32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetData", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeElementGetData64(IntPtr obj);
      internal static IntPtr PdeElementGetData(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeElementGetData64(obj);
        else return PdeElementGetData32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementSetAlt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetAlt32(IntPtr obj, string _alt);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementSetAlt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetAlt64(IntPtr obj, string _alt);
      internal static byte PdeElementSetAlt(IntPtr obj, string _alt)
      {
        if (Util.Is64BitProcess()) return PdeElementSetAlt64(obj, _alt);
        else return PdeElementSetAlt32(obj, _alt);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementSetActualText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetActualText32(IntPtr obj, string _text);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementSetActualText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetActualText64(IntPtr obj, string _text);
      internal static byte PdeElementSetActualText(IntPtr obj, string _text)
      {
        if (Util.Is64BitProcess()) return PdeElementSetActualText64(obj, _text);
        else return PdeElementSetActualText32(obj, _text);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementGetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetFlags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementGetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeElementGetFlags64(IntPtr obj);
      internal static int PdeElementGetFlags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeElementGetFlags64(obj);
        else return PdeElementGetFlags32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeElementSetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetFlags32(IntPtr obj, int _flags);
      [DllImport("pdfix64.dll", EntryPoint="PdeElementSetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeElementSetFlags64(IntPtr obj, int _flags);
      internal static byte PdeElementSetFlags(IntPtr obj, int _flags)
      {
        if (Util.Is64BitProcess()) return PdeElementSetFlags64(obj, _flags);
        else return PdeElementSetFlags32(obj, _flags);
      }
    }
    public class PdeContainer : PdeElement    {
      public PdeContainer(IntPtr obj) : base(obj) { }

    }
    public class PdeList : PdeElement    {
      public PdeList(IntPtr obj) : base(obj) { }

    }
    public class PdeToc : PdeContainer    {
      public PdeToc(IntPtr obj) : base(obj) { }

    }
    public class PdeAnnot : PdeElement    {
      public PdeAnnot(IntPtr obj) : base(obj) { }
      public PdfAnnot GetAnnot()
      {
        CheckBaseObj();
        IntPtr ret = PdeAnnotGetAnnot(m_obj);
        if (ret != IntPtr.Zero)
        {
          switch (PdfAnnot.PdfAnnotGetSubtype(ret))
          {
            case PdfAnnotSubtype.kAnnotText: return new PdfTextAnnot(ret);
            case PdfAnnotSubtype.kAnnotLink: return new PdfLinkAnnot(ret);
            case PdfAnnotSubtype.kAnnotFreeText: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquare: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCircle: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolygon: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolyLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotHighlight: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotUnderline: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquiggly: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStrikeOut: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStamp: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCaret: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotInk: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPopup: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotFileAttachment: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSound: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotMovie: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWidget: return new PdfWidgetAnnot(ret);
            case PdfAnnotSubtype.kAnnotScreen: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPrinterMark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotTrapNet: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWatermark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnot3D: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotRedact: return new PdfAnnot(ret);
            default: return new PdfAnnot(ret);
          }
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdeAnnotGetAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeAnnotGetAnnot32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeAnnotGetAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeAnnotGetAnnot64(IntPtr obj);
      internal static IntPtr PdeAnnotGetAnnot(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeAnnotGetAnnot64(obj);
        else return PdeAnnotGetAnnot32(obj);
      }
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
          switch (PdeElement.PdeElementGetType(ret))
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
            case PdfElementType.kPdeToc: return new PdeToc(ret);
            default: return new PdeElement(ret);
          }
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdeImageGetImageType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfImageType PdeImageGetImageType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeImageGetImageType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfImageType PdeImageGetImageType64(IntPtr obj);
      internal static PdfImageType PdeImageGetImageType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeImageGetImageType64(obj);
        else return PdeImageGetImageType32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeImageGetCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeImageGetCaption32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeImageGetCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeImageGetCaption64(IntPtr obj);
      internal static IntPtr PdeImageGetCaption(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeImageGetCaption64(obj);
        else return PdeImageGetCaption32(obj);
      }
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
        byte ret = PdeCellHasBorderGraphicState(m_obj, _index);
        return ret != 0;
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

      [DllImport("pdfix.dll", EntryPoint="PdeCellGetRowSpan", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeCellGetRowSpan32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeCellGetRowSpan", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeCellGetRowSpan64(IntPtr obj);
      internal static int PdeCellGetRowSpan(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeCellGetRowSpan64(obj);
        else return PdeCellGetRowSpan32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeCellGetColSpan", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeCellGetColSpan32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeCellGetColSpan", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeCellGetColSpan64(IntPtr obj);
      internal static int PdeCellGetColSpan(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeCellGetColSpan64(obj);
        else return PdeCellGetColSpan32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeCellHasBorderGraphicState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeCellHasBorderGraphicState32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdeCellHasBorderGraphicState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeCellHasBorderGraphicState64(IntPtr obj, int _index);
      internal static byte PdeCellHasBorderGraphicState(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdeCellHasBorderGraphicState64(obj, _index);
        else return PdeCellHasBorderGraphicState32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeCellGetSpanCell", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeCellGetSpanCell32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeCellGetSpanCell", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeCellGetSpanCell64(IntPtr obj);
      internal static IntPtr PdeCellGetSpanCell(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeCellGetSpanCell64(obj);
        else return PdeCellGetSpanCell32(obj);
      }
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
          switch (PdeElement.PdeElementGetType(ret))
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
            case PdfElementType.kPdeToc: return new PdeToc(ret);
            default: return new PdeElement(ret);
          }
        }
        return null;
      }
      public int GetTableType()
      {
        CheckBaseObj();
        int ret = PdeTableGetTableType(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdeTableGetNumRows", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetNumRows32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTableGetNumRows", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetNumRows64(IntPtr obj);
      internal static int PdeTableGetNumRows(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTableGetNumRows64(obj);
        else return PdeTableGetNumRows32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTableGetNumCols", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetNumCols32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTableGetNumCols", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetNumCols64(IntPtr obj);
      internal static int PdeTableGetNumCols(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTableGetNumCols64(obj);
        else return PdeTableGetNumCols32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTableGetCell", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTableGetCell32(IntPtr obj, int _row, int _col);
      [DllImport("pdfix64.dll", EntryPoint="PdeTableGetCell", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTableGetCell64(IntPtr obj, int _row, int _col);
      internal static IntPtr PdeTableGetCell(IntPtr obj, int _row, int _col)
      {
        if (Util.Is64BitProcess()) return PdeTableGetCell64(obj, _row, _col);
        else return PdeTableGetCell32(obj, _row, _col);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTableGetRowAlignment", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeTableGetRowAlignment32(IntPtr obj, int _row);
      [DllImport("pdfix64.dll", EntryPoint="PdeTableGetRowAlignment", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeTableGetRowAlignment64(IntPtr obj, int _row);
      internal static PdfAlignment PdeTableGetRowAlignment(IntPtr obj, int _row)
      {
        if (Util.Is64BitProcess()) return PdeTableGetRowAlignment64(obj, _row);
        else return PdeTableGetRowAlignment32(obj, _row);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTableGetColAlignment", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeTableGetColAlignment32(IntPtr obj, int _col);
      [DllImport("pdfix64.dll", EntryPoint="PdeTableGetColAlignment", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlignment PdeTableGetColAlignment64(IntPtr obj, int _col);
      internal static PdfAlignment PdeTableGetColAlignment(IntPtr obj, int _col)
      {
        if (Util.Is64BitProcess()) return PdeTableGetColAlignment64(obj, _col);
        else return PdeTableGetColAlignment32(obj, _col);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTableGetCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTableGetCaption32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTableGetCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTableGetCaption64(IntPtr obj);
      internal static IntPtr PdeTableGetCaption(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTableGetCaption64(obj);
        else return PdeTableGetCaption32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTableGetTableType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetTableType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTableGetTableType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTableGetTableType64(IntPtr obj);
      internal static int PdeTableGetTableType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTableGetTableType64(obj);
        else return PdeTableGetTableType32(obj);
      }
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
        byte ret = PdeWordHasTextState(m_obj);
        return ret != 0;
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
      public int GetCharCode(int _index)
      {
        CheckBaseObj();
        int ret = PdeWordGetCharCode(m_obj, _index);
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
      public int GetWordFlags()
      {
        CheckBaseObj();
        int ret = PdeWordGetWordFlags(m_obj);
        return ret;
      }
      public PdeElement GetBackground()
      {
        CheckBaseObj();
        IntPtr ret = PdeWordGetBackground(m_obj);
        if (ret != IntPtr.Zero)
        {
          switch (PdeElement.PdeElementGetType(ret))
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
            case PdfElementType.kPdeToc: return new PdeToc(ret);
            default: return new PdeElement(ret);
          }
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

      [DllImport("pdfix.dll", EntryPoint="PdeWordGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetText64(IntPtr obj, string _buffer, int _len);
      internal static int PdeWordGetText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdeWordGetText64(obj, _buffer, _len);
        else return PdeWordGetText32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordHasTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeWordHasTextState32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordHasTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeWordHasTextState64(IntPtr obj);
      internal static byte PdeWordHasTextState(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeWordHasTextState64(obj);
        else return PdeWordHasTextState32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetTextState32(IntPtr obj, IntPtr _text_state);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetTextState64(IntPtr obj, IntPtr _text_state);
      internal static void PdeWordGetTextState(IntPtr obj, IntPtr _text_state)
      {
        if (Util.Is64BitProcess()) PdeWordGetTextState64(obj, _text_state);
        else PdeWordGetTextState32(obj, _text_state);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetNumChars", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetNumChars32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetNumChars", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetNumChars64(IntPtr obj);
      internal static int PdeWordGetNumChars(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeWordGetNumChars64(obj);
        else return PdeWordGetNumChars32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetCharCode", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetCharCode32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetCharCode", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetCharCode64(IntPtr obj, int _index);
      internal static int PdeWordGetCharCode(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdeWordGetCharCode64(obj, _index);
        else return PdeWordGetCharCode32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetCharText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetCharText32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetCharText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetCharText64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdeWordGetCharText(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdeWordGetCharText64(obj, _index, _buffer, _len);
        else return PdeWordGetCharText32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetCharTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetCharTextState32(IntPtr obj, int _index, IntPtr _text_state);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetCharTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetCharTextState64(IntPtr obj, int _index, IntPtr _text_state);
      internal static void PdeWordGetCharTextState(IntPtr obj, int _index, IntPtr _text_state)
      {
        if (Util.Is64BitProcess()) PdeWordGetCharTextState64(obj, _index, _text_state);
        else PdeWordGetCharTextState32(obj, _index, _text_state);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetCharBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetCharBBox32(IntPtr obj, int _index, IntPtr _bbox);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetCharBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetCharBBox64(IntPtr obj, int _index, IntPtr _bbox);
      internal static void PdeWordGetCharBBox(IntPtr obj, int _index, IntPtr _bbox)
      {
        if (Util.Is64BitProcess()) PdeWordGetCharBBox64(obj, _index, _bbox);
        else PdeWordGetCharBBox32(obj, _index, _bbox);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetWordFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetWordFlags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetWordFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeWordGetWordFlags64(IntPtr obj);
      internal static int PdeWordGetWordFlags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeWordGetWordFlags64(obj);
        else return PdeWordGetWordFlags32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetBackground", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeWordGetBackground32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetBackground", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeWordGetBackground64(IntPtr obj);
      internal static IntPtr PdeWordGetBackground(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeWordGetBackground64(obj);
        else return PdeWordGetBackground32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeWordGetOrigin", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetOrigin32(IntPtr obj, IntPtr _point);
      [DllImport("pdfix64.dll", EntryPoint="PdeWordGetOrigin", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeWordGetOrigin64(IntPtr obj, IntPtr _point);
      internal static void PdeWordGetOrigin(IntPtr obj, IntPtr _point)
      {
        if (Util.Is64BitProcess()) PdeWordGetOrigin64(obj, _point);
        else PdeWordGetOrigin32(obj, _point);
      }
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
        byte ret = PdeTextLineHasTextState(m_obj);
        return ret != 0;
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
      public int GetTextLineFlags()
      {
        CheckBaseObj();
        int ret = PdeTextLineGetTextLineFlags(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdeTextLineGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextLineGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetText64(IntPtr obj, string _buffer, int _len);
      internal static int PdeTextLineGetText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdeTextLineGetText64(obj, _buffer, _len);
        else return PdeTextLineGetText32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextLineHasTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeTextLineHasTextState32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextLineHasTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeTextLineHasTextState64(IntPtr obj);
      internal static byte PdeTextLineHasTextState(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextLineHasTextState64(obj);
        else return PdeTextLineHasTextState32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextLineGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeTextLineGetTextState32(IntPtr obj, IntPtr _text_state);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextLineGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeTextLineGetTextState64(IntPtr obj, IntPtr _text_state);
      internal static void PdeTextLineGetTextState(IntPtr obj, IntPtr _text_state)
      {
        if (Util.Is64BitProcess()) PdeTextLineGetTextState64(obj, _text_state);
        else PdeTextLineGetTextState32(obj, _text_state);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextLineGetNumWords", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetNumWords32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextLineGetNumWords", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetNumWords64(IntPtr obj);
      internal static int PdeTextLineGetNumWords(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextLineGetNumWords64(obj);
        else return PdeTextLineGetNumWords32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextLineGetWord", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextLineGetWord32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextLineGetWord", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextLineGetWord64(IntPtr obj, int _index);
      internal static IntPtr PdeTextLineGetWord(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdeTextLineGetWord64(obj, _index);
        else return PdeTextLineGetWord32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextLineGetTextLineFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetTextLineFlags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextLineGetTextLineFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextLineGetTextLineFlags64(IntPtr obj);
      internal static int PdeTextLineGetTextLineFlags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextLineGetTextLineFlags64(obj);
        else return PdeTextLineGetTextLineFlags32(obj);
      }
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
        byte ret = PdeTextHasTextState(m_obj);
        return ret != 0;
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
      public int GetTextFlags()
      {
        CheckBaseObj();
        int ret = PdeTextGetTextFlags(m_obj);
        return ret;
      }
      public int GetLabelLevel()
      {
        CheckBaseObj();
        int ret = PdeTextGetLabelLevel(m_obj);
        return ret;
      }
      public bool SetLabelLevel(int _level)
      {
        CheckBaseObj();
        byte ret = PdeTextSetLabelLevel(m_obj, _level);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdeTextGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetText64(IntPtr obj, string _buffer, int _len);
      internal static int PdeTextGetText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdeTextGetText64(obj, _buffer, _len);
        else return PdeTextGetText32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextHasTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeTextHasTextState32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextHasTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeTextHasTextState64(IntPtr obj);
      internal static byte PdeTextHasTextState(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextHasTextState64(obj);
        else return PdeTextHasTextState32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeTextGetTextState32(IntPtr obj, IntPtr _text_state);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetTextState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdeTextGetTextState64(IntPtr obj, IntPtr _text_state);
      internal static void PdeTextGetTextState(IntPtr obj, IntPtr _text_state)
      {
        if (Util.Is64BitProcess()) PdeTextGetTextState64(obj, _text_state);
        else PdeTextGetTextState32(obj, _text_state);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetNumTextLines", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetNumTextLines32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetNumTextLines", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetNumTextLines64(IntPtr obj);
      internal static int PdeTextGetNumTextLines(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextGetNumTextLines64(obj);
        else return PdeTextGetNumTextLines32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetTextLine", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextGetTextLine32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetTextLine", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextGetTextLine64(IntPtr obj, int _index);
      internal static IntPtr PdeTextGetTextLine(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdeTextGetTextLine64(obj, _index);
        else return PdeTextGetTextLine32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetNumWords", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetNumWords32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetNumWords", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetNumWords64(IntPtr obj);
      internal static int PdeTextGetNumWords(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextGetNumWords64(obj);
        else return PdeTextGetNumWords32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetWord", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextGetWord32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetWord", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdeTextGetWord64(IntPtr obj, int _index);
      internal static IntPtr PdeTextGetWord(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdeTextGetWord64(obj, _index);
        else return PdeTextGetWord32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetLineSpacing", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeTextGetLineSpacing32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetLineSpacing", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeTextGetLineSpacing64(IntPtr obj);
      internal static double PdeTextGetLineSpacing(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextGetLineSpacing64(obj);
        else return PdeTextGetLineSpacing32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetIndent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeTextGetIndent32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetIndent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdeTextGetIndent64(IntPtr obj);
      internal static double PdeTextGetIndent(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextGetIndent64(obj);
        else return PdeTextGetIndent32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetTextStyle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfTextStyle PdeTextGetTextStyle32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetTextStyle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfTextStyle PdeTextGetTextStyle64(IntPtr obj);
      internal static PdfTextStyle PdeTextGetTextStyle(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextGetTextStyle64(obj);
        else return PdeTextGetTextStyle32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetTextFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetTextFlags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetTextFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetTextFlags64(IntPtr obj);
      internal static int PdeTextGetTextFlags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextGetTextFlags64(obj);
        else return PdeTextGetTextFlags32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextGetLabelLevel", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetLabelLevel32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextGetLabelLevel", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdeTextGetLabelLevel64(IntPtr obj);
      internal static int PdeTextGetLabelLevel(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdeTextGetLabelLevel64(obj);
        else return PdeTextGetLabelLevel32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdeTextSetLabelLevel", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeTextSetLabelLevel32(IntPtr obj, int _level);
      [DllImport("pdfix64.dll", EntryPoint="PdeTextSetLabelLevel", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdeTextSetLabelLevel64(IntPtr obj, int _level);
      internal static byte PdeTextSetLabelLevel(IntPtr obj, int _level)
      {
        if (Util.Is64BitProcess()) return PdeTextSetLabelLevel64(obj, _level);
        else return PdeTextSetLabelLevel32(obj, _level);
      }
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
      public int GetDestPageNum(PdfDoc _doc)
      {
        CheckBaseObj();
        int ret = PdfActionGetDestPageNum(m_obj, _doc == null ? IntPtr.Zero : _doc.m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfActionGetSubtype", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfActionType PdfActionGetSubtype32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfActionGetSubtype", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfActionType PdfActionGetSubtype64(IntPtr obj);
      internal static PdfActionType PdfActionGetSubtype(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfActionGetSubtype64(obj);
        else return PdfActionGetSubtype32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfActionGetJavaScript", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetJavaScript32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfActionGetJavaScript", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetJavaScript64(IntPtr obj, string _buffer, int _len);
      internal static int PdfActionGetJavaScript(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfActionGetJavaScript64(obj, _buffer, _len);
        else return PdfActionGetJavaScript32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfActionGetURI", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetURI32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfActionGetURI", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetURI64(IntPtr obj, string _buffer, int _len);
      internal static int PdfActionGetURI(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfActionGetURI64(obj, _buffer, _len);
        else return PdfActionGetURI32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfActionGetDestPageNum", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetDestPageNum32(IntPtr obj, IntPtr _doc);
      [DllImport("pdfix64.dll", EntryPoint="PdfActionGetDestPageNum", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfActionGetDestPageNum64(IntPtr obj, IntPtr _doc);
      internal static int PdfActionGetDestPageNum(IntPtr obj, IntPtr _doc)
      {
        if (Util.Is64BitProcess()) return PdfActionGetDestPageNum64(obj, _doc);
        else return PdfActionGetDestPageNum32(obj, _doc);
      }
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
        byte ret = PdfAnnotPointInAnnot(m_obj, _point_ptr);
        Marshal.FreeHGlobal(_point_ptr);
        _point_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public bool RectInAnnot(PdfRect _rect)
      {
        CheckBaseObj();
        PdfRectInt _rectInt = _rect.GetIntStruct();
        IntPtr _rect_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_rectInt, _rect_ptr, true);
        byte ret = PdfAnnotRectInAnnot(m_obj, _rect_ptr);
        Marshal.FreeHGlobal(_rect_ptr);
        _rect_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public PdsObject GetStructObject(bool _struct_parent)
      {
        CheckBaseObj();
        IntPtr ret = PdfAnnotGetStructObject(m_obj, _struct_parent);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfAnnotGetSubtype", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAnnotSubtype PdfAnnotGetSubtype32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfAnnotGetSubtype", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAnnotSubtype PdfAnnotGetSubtype64(IntPtr obj);
      internal static PdfAnnotSubtype PdfAnnotGetSubtype(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfAnnotGetSubtype64(obj);
        else return PdfAnnotGetSubtype32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAnnotGetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAnnotGetFlags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfAnnotGetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAnnotGetFlags64(IntPtr obj);
      internal static int PdfAnnotGetFlags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfAnnotGetFlags64(obj);
        else return PdfAnnotGetFlags32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAnnotGetAppearance", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAnnotGetAppearance32(IntPtr obj, IntPtr _appearance);
      [DllImport("pdfix64.dll", EntryPoint="PdfAnnotGetAppearance", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAnnotGetAppearance64(IntPtr obj, IntPtr _appearance);
      internal static void PdfAnnotGetAppearance(IntPtr obj, IntPtr _appearance)
      {
        if (Util.Is64BitProcess()) PdfAnnotGetAppearance64(obj, _appearance);
        else PdfAnnotGetAppearance32(obj, _appearance);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAnnotGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAnnotGetBBox32(IntPtr obj, IntPtr _bbox);
      [DllImport("pdfix64.dll", EntryPoint="PdfAnnotGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAnnotGetBBox64(IntPtr obj, IntPtr _bbox);
      internal static void PdfAnnotGetBBox(IntPtr obj, IntPtr _bbox)
      {
        if (Util.Is64BitProcess()) PdfAnnotGetBBox64(obj, _bbox);
        else PdfAnnotGetBBox32(obj, _bbox);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAnnotPointInAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfAnnotPointInAnnot32(IntPtr obj, IntPtr _point);
      [DllImport("pdfix64.dll", EntryPoint="PdfAnnotPointInAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfAnnotPointInAnnot64(IntPtr obj, IntPtr _point);
      internal static byte PdfAnnotPointInAnnot(IntPtr obj, IntPtr _point)
      {
        if (Util.Is64BitProcess()) return PdfAnnotPointInAnnot64(obj, _point);
        else return PdfAnnotPointInAnnot32(obj, _point);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAnnotRectInAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfAnnotRectInAnnot32(IntPtr obj, IntPtr _rect);
      [DllImport("pdfix64.dll", EntryPoint="PdfAnnotRectInAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfAnnotRectInAnnot64(IntPtr obj, IntPtr _rect);
      internal static byte PdfAnnotRectInAnnot(IntPtr obj, IntPtr _rect)
      {
        if (Util.Is64BitProcess()) return PdfAnnotRectInAnnot64(obj, _rect);
        else return PdfAnnotRectInAnnot32(obj, _rect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAnnotGetStructObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfAnnotGetStructObject32(IntPtr obj, bool _struct_parent);
      [DllImport("pdfix64.dll", EntryPoint="PdfAnnotGetStructObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfAnnotGetStructObject64(IntPtr obj, bool _struct_parent);
      internal static IntPtr PdfAnnotGetStructObject(IntPtr obj, bool _struct_parent)
      {
        if (Util.Is64BitProcess()) return PdfAnnotGetStructObject64(obj, _struct_parent);
        else return PdfAnnotGetStructObject32(obj, _struct_parent);
      }
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
        byte ret = PdfLinkAnnotAddQuad(m_obj, _quad_ptr);
        Marshal.FreeHGlobal(_quad_ptr);
        _quad_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public bool RemoveQuad(int _index)
      {
        CheckBaseObj();
        byte ret = PdfLinkAnnotRemoveQuad(m_obj, _index);
        return ret != 0;
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

      [DllImport("pdfix.dll", EntryPoint="PdfLinkAnnotGetNumQuads", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfLinkAnnotGetNumQuads32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfLinkAnnotGetNumQuads", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfLinkAnnotGetNumQuads64(IntPtr obj);
      internal static int PdfLinkAnnotGetNumQuads(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfLinkAnnotGetNumQuads64(obj);
        else return PdfLinkAnnotGetNumQuads32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfLinkAnnotGetQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfLinkAnnotGetQuad32(IntPtr obj, int _index, IntPtr _quad);
      [DllImport("pdfix64.dll", EntryPoint="PdfLinkAnnotGetQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfLinkAnnotGetQuad64(IntPtr obj, int _index, IntPtr _quad);
      internal static void PdfLinkAnnotGetQuad(IntPtr obj, int _index, IntPtr _quad)
      {
        if (Util.Is64BitProcess()) PdfLinkAnnotGetQuad64(obj, _index, _quad);
        else PdfLinkAnnotGetQuad32(obj, _index, _quad);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfLinkAnnotAddQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfLinkAnnotAddQuad32(IntPtr obj, IntPtr _quad);
      [DllImport("pdfix64.dll", EntryPoint="PdfLinkAnnotAddQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfLinkAnnotAddQuad64(IntPtr obj, IntPtr _quad);
      internal static byte PdfLinkAnnotAddQuad(IntPtr obj, IntPtr _quad)
      {
        if (Util.Is64BitProcess()) return PdfLinkAnnotAddQuad64(obj, _quad);
        else return PdfLinkAnnotAddQuad32(obj, _quad);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfLinkAnnotRemoveQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfLinkAnnotRemoveQuad32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfLinkAnnotRemoveQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfLinkAnnotRemoveQuad64(IntPtr obj, int _index);
      internal static byte PdfLinkAnnotRemoveQuad(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfLinkAnnotRemoveQuad64(obj, _index);
        else return PdfLinkAnnotRemoveQuad32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfLinkAnnotGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfLinkAnnotGetAction32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfLinkAnnotGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfLinkAnnotGetAction64(IntPtr obj);
      internal static IntPtr PdfLinkAnnotGetAction(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfLinkAnnotGetAction64(obj);
        else return PdfLinkAnnotGetAction32(obj);
      }
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
      public bool SetContents(string _contents)
      {
        CheckBaseObj();
        byte ret = PdfMarkupAnnotSetContents(m_obj, _contents);
        return ret != 0;
      }
      public string GetAuthor()
      {
        CheckBaseObj();
        int _buffer_sz = PdfMarkupAnnotGetAuthor(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfMarkupAnnotGetAuthor(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetAuthor(string _author)
      {
        CheckBaseObj();
        byte ret = PdfMarkupAnnotSetAuthor(m_obj, _author);
        return ret != 0;
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
          switch (PdfAnnot.PdfAnnotGetSubtype(ret))
          {
            case PdfAnnotSubtype.kAnnotText: return new PdfTextAnnot(ret);
            case PdfAnnotSubtype.kAnnotLink: return new PdfLinkAnnot(ret);
            case PdfAnnotSubtype.kAnnotFreeText: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquare: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCircle: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolygon: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolyLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotHighlight: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotUnderline: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquiggly: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStrikeOut: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStamp: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCaret: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotInk: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPopup: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotFileAttachment: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSound: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotMovie: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWidget: return new PdfWidgetAnnot(ret);
            case PdfAnnotSubtype.kAnnotScreen: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPrinterMark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotTrapNet: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWatermark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnot3D: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotRedact: return new PdfAnnot(ret);
            default: return new PdfAnnot(ret);
          }
        }
        return null;
      }
      public PdfAnnot AddReply(string _author, string _text)
      {
        CheckBaseObj();
        IntPtr ret = PdfMarkupAnnotAddReply(m_obj, _author, _text);
        if (ret != IntPtr.Zero)
        {
          switch (PdfAnnot.PdfAnnotGetSubtype(ret))
          {
            case PdfAnnotSubtype.kAnnotText: return new PdfTextAnnot(ret);
            case PdfAnnotSubtype.kAnnotLink: return new PdfLinkAnnot(ret);
            case PdfAnnotSubtype.kAnnotFreeText: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquare: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCircle: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolygon: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolyLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotHighlight: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotUnderline: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquiggly: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStrikeOut: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStamp: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCaret: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotInk: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPopup: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotFileAttachment: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSound: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotMovie: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWidget: return new PdfWidgetAnnot(ret);
            case PdfAnnotSubtype.kAnnotScreen: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPrinterMark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotTrapNet: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWatermark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnot3D: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotRedact: return new PdfAnnot(ret);
            default: return new PdfAnnot(ret);
          }
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfMarkupAnnotGetContents", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetContents32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfMarkupAnnotGetContents", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetContents64(IntPtr obj, string _buffer, int _len);
      internal static int PdfMarkupAnnotGetContents(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfMarkupAnnotGetContents64(obj, _buffer, _len);
        else return PdfMarkupAnnotGetContents32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfMarkupAnnotSetContents", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfMarkupAnnotSetContents32(IntPtr obj, string _contents);
      [DllImport("pdfix64.dll", EntryPoint="PdfMarkupAnnotSetContents", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfMarkupAnnotSetContents64(IntPtr obj, string _contents);
      internal static byte PdfMarkupAnnotSetContents(IntPtr obj, string _contents)
      {
        if (Util.Is64BitProcess()) return PdfMarkupAnnotSetContents64(obj, _contents);
        else return PdfMarkupAnnotSetContents32(obj, _contents);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfMarkupAnnotGetAuthor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetAuthor32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfMarkupAnnotGetAuthor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetAuthor64(IntPtr obj, string _buffer, int _len);
      internal static int PdfMarkupAnnotGetAuthor(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfMarkupAnnotGetAuthor64(obj, _buffer, _len);
        else return PdfMarkupAnnotGetAuthor32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfMarkupAnnotSetAuthor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfMarkupAnnotSetAuthor32(IntPtr obj, string _author);
      [DllImport("pdfix64.dll", EntryPoint="PdfMarkupAnnotSetAuthor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfMarkupAnnotSetAuthor64(IntPtr obj, string _author);
      internal static byte PdfMarkupAnnotSetAuthor(IntPtr obj, string _author)
      {
        if (Util.Is64BitProcess()) return PdfMarkupAnnotSetAuthor64(obj, _author);
        else return PdfMarkupAnnotSetAuthor32(obj, _author);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfMarkupAnnotGetNumReplies", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetNumReplies32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfMarkupAnnotGetNumReplies", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfMarkupAnnotGetNumReplies64(IntPtr obj);
      internal static int PdfMarkupAnnotGetNumReplies(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfMarkupAnnotGetNumReplies64(obj);
        else return PdfMarkupAnnotGetNumReplies32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfMarkupAnnotGetReply", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfMarkupAnnotGetReply32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfMarkupAnnotGetReply", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfMarkupAnnotGetReply64(IntPtr obj, int _index);
      internal static IntPtr PdfMarkupAnnotGetReply(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfMarkupAnnotGetReply64(obj, _index);
        else return PdfMarkupAnnotGetReply32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfMarkupAnnotAddReply", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfMarkupAnnotAddReply32(IntPtr obj, string _author, string _text);
      [DllImport("pdfix64.dll", EntryPoint="PdfMarkupAnnotAddReply", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfMarkupAnnotAddReply64(IntPtr obj, string _author, string _text);
      internal static IntPtr PdfMarkupAnnotAddReply(IntPtr obj, string _author, string _text)
      {
        if (Util.Is64BitProcess()) return PdfMarkupAnnotAddReply64(obj, _author, _text);
        else return PdfMarkupAnnotAddReply32(obj, _author, _text);
      }
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
        byte ret = PdfTextMarkupAnnotAddQuad(m_obj, _quad_ptr);
        Marshal.FreeHGlobal(_quad_ptr);
        _quad_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public bool RemoveQuad(int _index)
      {
        CheckBaseObj();
        byte ret = PdfTextMarkupAnnotRemoveQuad(m_obj, _index);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfTextMarkupAnnotGetNumQuads", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfTextMarkupAnnotGetNumQuads32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfTextMarkupAnnotGetNumQuads", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfTextMarkupAnnotGetNumQuads64(IntPtr obj);
      internal static int PdfTextMarkupAnnotGetNumQuads(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfTextMarkupAnnotGetNumQuads64(obj);
        else return PdfTextMarkupAnnotGetNumQuads32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfTextMarkupAnnotGetQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfTextMarkupAnnotGetQuad32(IntPtr obj, int _index, IntPtr _quad);
      [DllImport("pdfix64.dll", EntryPoint="PdfTextMarkupAnnotGetQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfTextMarkupAnnotGetQuad64(IntPtr obj, int _index, IntPtr _quad);
      internal static void PdfTextMarkupAnnotGetQuad(IntPtr obj, int _index, IntPtr _quad)
      {
        if (Util.Is64BitProcess()) PdfTextMarkupAnnotGetQuad64(obj, _index, _quad);
        else PdfTextMarkupAnnotGetQuad32(obj, _index, _quad);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfTextMarkupAnnotAddQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfTextMarkupAnnotAddQuad32(IntPtr obj, IntPtr _quad);
      [DllImport("pdfix64.dll", EntryPoint="PdfTextMarkupAnnotAddQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfTextMarkupAnnotAddQuad64(IntPtr obj, IntPtr _quad);
      internal static byte PdfTextMarkupAnnotAddQuad(IntPtr obj, IntPtr _quad)
      {
        if (Util.Is64BitProcess()) return PdfTextMarkupAnnotAddQuad64(obj, _quad);
        else return PdfTextMarkupAnnotAddQuad32(obj, _quad);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfTextMarkupAnnotRemoveQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfTextMarkupAnnotRemoveQuad32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfTextMarkupAnnotRemoveQuad", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfTextMarkupAnnotRemoveQuad64(IntPtr obj, int _index);
      internal static byte PdfTextMarkupAnnotRemoveQuad(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfTextMarkupAnnotRemoveQuad64(obj, _index);
        else return PdfTextMarkupAnnotRemoveQuad32(obj, _index);
      }
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

      [DllImport("pdfix.dll", EntryPoint="PdfWidgetAnnotGetCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfWidgetAnnotGetCaption32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfWidgetAnnotGetCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfWidgetAnnotGetCaption64(IntPtr obj, string _buffer, int _len);
      internal static int PdfWidgetAnnotGetCaption(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfWidgetAnnotGetCaption64(obj, _buffer, _len);
        else return PdfWidgetAnnotGetCaption32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfWidgetAnnotGetFontName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfWidgetAnnotGetFontName32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfWidgetAnnotGetFontName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfWidgetAnnotGetFontName64(IntPtr obj, string _buffer, int _len);
      internal static int PdfWidgetAnnotGetFontName(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfWidgetAnnotGetFontName64(obj, _buffer, _len);
        else return PdfWidgetAnnotGetFontName32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfWidgetAnnotGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetAction32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfWidgetAnnotGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetAction64(IntPtr obj);
      internal static IntPtr PdfWidgetAnnotGetAction(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfWidgetAnnotGetAction64(obj);
        else return PdfWidgetAnnotGetAction32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfWidgetAnnotGetAAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetAAction32(IntPtr obj, int _event);
      [DllImport("pdfix64.dll", EntryPoint="PdfWidgetAnnotGetAAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetAAction64(IntPtr obj, int _event);
      internal static IntPtr PdfWidgetAnnotGetAAction(IntPtr obj, int _event)
      {
        if (Util.Is64BitProcess()) return PdfWidgetAnnotGetAAction64(obj, _event);
        else return PdfWidgetAnnotGetAAction32(obj, _event);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfWidgetAnnotGetFormField", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetFormField32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfWidgetAnnotGetFormField", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfWidgetAnnotGetFormField64(IntPtr obj);
      internal static IntPtr PdfWidgetAnnotGetFormField(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfWidgetAnnotGetFormField64(obj);
        else return PdfWidgetAnnotGetFormField32(obj);
      }
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
        byte ret = PdfBaseDigSigSetReason(m_obj, _reason);
        return ret != 0;
      }
      public bool SetLocation(string _location)
      {
        CheckBaseObj();
        byte ret = PdfBaseDigSigSetLocation(m_obj, _location);
        return ret != 0;
      }
      public bool SetContactInfo(string _contact)
      {
        CheckBaseObj();
        byte ret = PdfBaseDigSigSetContactInfo(m_obj, _contact);
        return ret != 0;
      }
      public bool SetName(string _name)
      {
        CheckBaseObj();
        byte ret = PdfBaseDigSigSetName(m_obj, _name);
        return ret != 0;
      }
      public bool SetTimeStampServer(string _url, string _user_name, string _password)
      {
        CheckBaseObj();
        byte ret = PdfBaseDigSigSetTimeStampServer(m_obj, _url, _user_name, _password);
        return ret != 0;
      }
      public bool SignDoc(PdfDoc _doc, string _path)
      {
        CheckBaseObj();
        byte ret = PdfBaseDigSigSignDoc(m_obj, _doc == null ? IntPtr.Zero : _doc.m_obj, _path);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfBaseDigSigDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfBaseDigSigDestroy32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfBaseDigSigDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfBaseDigSigDestroy64(IntPtr obj);
      internal static void PdfBaseDigSigDestroy(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfBaseDigSigDestroy64(obj);
        else PdfBaseDigSigDestroy32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBaseDigSigSetReason", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetReason32(IntPtr obj, string _reason);
      [DllImport("pdfix64.dll", EntryPoint="PdfBaseDigSigSetReason", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetReason64(IntPtr obj, string _reason);
      internal static byte PdfBaseDigSigSetReason(IntPtr obj, string _reason)
      {
        if (Util.Is64BitProcess()) return PdfBaseDigSigSetReason64(obj, _reason);
        else return PdfBaseDigSigSetReason32(obj, _reason);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBaseDigSigSetLocation", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetLocation32(IntPtr obj, string _location);
      [DllImport("pdfix64.dll", EntryPoint="PdfBaseDigSigSetLocation", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetLocation64(IntPtr obj, string _location);
      internal static byte PdfBaseDigSigSetLocation(IntPtr obj, string _location)
      {
        if (Util.Is64BitProcess()) return PdfBaseDigSigSetLocation64(obj, _location);
        else return PdfBaseDigSigSetLocation32(obj, _location);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBaseDigSigSetContactInfo", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetContactInfo32(IntPtr obj, string _contact);
      [DllImport("pdfix64.dll", EntryPoint="PdfBaseDigSigSetContactInfo", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetContactInfo64(IntPtr obj, string _contact);
      internal static byte PdfBaseDigSigSetContactInfo(IntPtr obj, string _contact)
      {
        if (Util.Is64BitProcess()) return PdfBaseDigSigSetContactInfo64(obj, _contact);
        else return PdfBaseDigSigSetContactInfo32(obj, _contact);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBaseDigSigSetName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetName32(IntPtr obj, string _name);
      [DllImport("pdfix64.dll", EntryPoint="PdfBaseDigSigSetName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetName64(IntPtr obj, string _name);
      internal static byte PdfBaseDigSigSetName(IntPtr obj, string _name)
      {
        if (Util.Is64BitProcess()) return PdfBaseDigSigSetName64(obj, _name);
        else return PdfBaseDigSigSetName32(obj, _name);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBaseDigSigSetTimeStampServer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetTimeStampServer32(IntPtr obj, string _url, string _user_name, string _password);
      [DllImport("pdfix64.dll", EntryPoint="PdfBaseDigSigSetTimeStampServer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSetTimeStampServer64(IntPtr obj, string _url, string _user_name, string _password);
      internal static byte PdfBaseDigSigSetTimeStampServer(IntPtr obj, string _url, string _user_name, string _password)
      {
        if (Util.Is64BitProcess()) return PdfBaseDigSigSetTimeStampServer64(obj, _url, _user_name, _password);
        else return PdfBaseDigSigSetTimeStampServer32(obj, _url, _user_name, _password);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBaseDigSigSignDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSignDoc32(IntPtr obj, IntPtr _doc, string _path);
      [DllImport("pdfix64.dll", EntryPoint="PdfBaseDigSigSignDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfBaseDigSigSignDoc64(IntPtr obj, IntPtr _doc, string _path);
      internal static byte PdfBaseDigSigSignDoc(IntPtr obj, IntPtr _doc, string _path)
      {
        if (Util.Is64BitProcess()) return PdfBaseDigSigSignDoc64(obj, _doc, _path);
        else return PdfBaseDigSigSignDoc32(obj, _doc, _path);
      }
    }
    public class PdfDigSig : PdfBaseDigSig    {
      public PdfDigSig(IntPtr obj) : base(obj) { }
      public bool SetPfxFile(string _pfx_file, string _pfx_password)
      {
        CheckBaseObj();
        byte ret = PdfDigSigSetPfxFile(m_obj, _pfx_file, _pfx_password);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfDigSigSetPfxFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDigSigSetPfxFile32(IntPtr obj, string _pfx_file, string _pfx_password);
      [DllImport("pdfix64.dll", EntryPoint="PdfDigSigSetPfxFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDigSigSetPfxFile64(IntPtr obj, string _pfx_file, string _pfx_password);
      internal static byte PdfDigSigSetPfxFile(IntPtr obj, string _pfx_file, string _pfx_password)
      {
        if (Util.Is64BitProcess()) return PdfDigSigSetPfxFile64(obj, _pfx_file, _pfx_password);
        else return PdfDigSigSetPfxFile32(obj, _pfx_file, _pfx_password);
      }
    }
    public class PdfCertDigSig : PdfBaseDigSig    {
      public PdfCertDigSig(IntPtr obj) : base(obj) { }
      public bool SetPfxFile(string _pfx_file, string _pfx_password)
      {
        CheckBaseObj();
        byte ret = PdfCertDigSigSetPfxFile(m_obj, _pfx_file, _pfx_password);
        return ret != 0;
      }
      public bool SetCertContext(IntPtr _cert_context)
      {
        CheckBaseObj();
        byte ret = PdfCertDigSigSetCertContext(m_obj, _cert_context);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfCertDigSigSetPfxFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfCertDigSigSetPfxFile32(IntPtr obj, string _pfx_file, string _pfx_password);
      [DllImport("pdfix64.dll", EntryPoint="PdfCertDigSigSetPfxFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfCertDigSigSetPfxFile64(IntPtr obj, string _pfx_file, string _pfx_password);
      internal static byte PdfCertDigSigSetPfxFile(IntPtr obj, string _pfx_file, string _pfx_password)
      {
        if (Util.Is64BitProcess()) return PdfCertDigSigSetPfxFile64(obj, _pfx_file, _pfx_password);
        else return PdfCertDigSigSetPfxFile32(obj, _pfx_file, _pfx_password);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfCertDigSigSetCertContext", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfCertDigSigSetCertContext32(IntPtr obj, IntPtr _cert_context);
      [DllImport("pdfix64.dll", EntryPoint="PdfCertDigSigSetCertContext", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfCertDigSigSetCertContext64(IntPtr obj, IntPtr _cert_context);
      internal static byte PdfCertDigSigSetCertContext(IntPtr obj, IntPtr _cert_context)
      {
        if (Util.Is64BitProcess()) return PdfCertDigSigSetCertContext64(obj, _cert_context);
        else return PdfCertDigSigSetCertContext32(obj, _cert_context);
      }
    }
    public class PdfDoc : PdfixBase
    {
      public PdfDoc(IntPtr obj) : base(obj) { }
      public bool Save(string _path, PdfSaveFlags _flags)
      {
        CheckBaseObj();
        byte ret = PdfDocSave(m_obj, _path, (int)_flags);
        return ret != 0;
      }
      public bool SaveToStream(PsStream _stream, PdfSaveFlags _flags)
      {
        CheckBaseObj();
        byte ret = PdfDocSaveToStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj, (int)_flags);
        return ret != 0;
      }
      public bool Close()
      {
        CheckBaseObj();
        byte ret = PdfDocClose(m_obj);
        return ret != 0;
      }
      public bool AddWatermarkFromImage(PdfWatermarkParams _params, string _path)
      {
        CheckBaseObj();
        PdfWatermarkParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfWatermarkParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        byte ret = PdfDocAddWatermarkFromImage(m_obj, _params_ptr, _path);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret != 0;
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
      public bool SetInfo(string _key, string _info)
      {
        CheckBaseObj();
        byte ret = PdfDocSetInfo(m_obj, _key, _info);
        return ret != 0;
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
        byte ret = PdfDocFlattenAnnots(m_obj, _params_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret != 0;
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
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public bool AddTags(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdfDocAddTags(m_obj, _cancel_proc, _cancel_data);
        return ret != 0;
      }
      public bool RemoveTags(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdfDocRemoveTags(m_obj, _cancel_proc, _cancel_data);
        return ret != 0;
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
      public bool SetLang(string _lang)
      {
        CheckBaseObj();
        byte ret = PdfDocSetLang(m_obj, _lang);
        return ret != 0;
      }
      public bool EmbedFonts(bool _subset, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdfDocEmbedFonts(m_obj, _subset, _cancel_proc, _cancel_data);
        return ret != 0;
      }
      public bool MakeAccessible(PdfAccessibleParams _params, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfAccessibleParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfAccessibleParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        byte ret = PdfDocMakeAccessible(m_obj, _params_ptr, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public PdsDictionary GetRootObject()
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetRootObject(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public PdsDictionary GetInfoObject()
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetInfoObject(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public PdsDictionary CreateDictObject(bool _indirect)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreateDictObject(m_obj, _indirect);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public PdsArray CreateArrayObject(bool _indirect)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreateArrayObject(m_obj, _indirect);
        if (ret != IntPtr.Zero)
        {
          return new PdsArray(ret);
        }
        return null;
      }
      public PdsName CreateNameObject(bool _indirect, string _value)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreateNameObject(m_obj, _indirect, _value);
        if (ret != IntPtr.Zero)
        {
          return new PdsName(ret);
        }
        return null;
      }
      public PdsString CreateStringObject(bool _indirect, string _value, bool _hex)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreateStringObject(m_obj, _indirect, _value, _hex);
        if (ret != IntPtr.Zero)
        {
          return new PdsString(ret);
        }
        return null;
      }
      public PdsNumber CreateIntObject(bool _indirect, int _value)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreateIntObject(m_obj, _indirect, _value);
        if (ret != IntPtr.Zero)
        {
          return new PdsNumber(ret);
        }
        return null;
      }
      public PdsNumber CreateNumberObject(bool _indirect, double _value)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreateNumberObject(m_obj, _indirect, _value);
        if (ret != IntPtr.Zero)
        {
          return new PdsNumber(ret);
        }
        return null;
      }
      public PdsStream CreateStreamObject(bool _indirect, PdsDictionary _dict, byte[] _buffer)
      {
        CheckBaseObj();
        IntPtr _buffer_ptr = Marshal.AllocHGlobal(_buffer.Length);
        Marshal.Copy(_buffer, 0, _buffer_ptr, _buffer.Length);
        IntPtr ret = PdfDocCreateStreamObject(m_obj, _indirect, _dict == null ? IntPtr.Zero : _dict.m_obj, _buffer_ptr, _buffer.Length);
        Marshal.FreeHGlobal(_buffer_ptr);
        _buffer_ptr = IntPtr.Zero;
        if (ret != IntPtr.Zero)
        {
          return new PdsStream(ret);
        }
        return null;
      }
      public PdsObject GetObjectById(int _obj_id)
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetObjectById(m_obj, _obj_id);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public PdsStructTree CreateStructTree()
      {
        CheckBaseObj();
        IntPtr ret = PdfDocCreateStructTree(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsStructTree(ret);
        }
        return null;
      }
      public PdsStructTree GetStructTree()
      {
        CheckBaseObj();
        IntPtr ret = PdfDocGetStructTree(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsStructTree(ret);
        }
        return null;
      }
      public void RemoveStructTree()
      {
        CheckBaseObj();
        PdfDocRemoveStructTree(m_obj);
      }
      public void RemoveBookmarks()
      {
        CheckBaseObj();
        PdfDocRemoveBookmarks(m_obj);
      }
      public bool CreateBookmarks(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdfDocCreateBookmarks(m_obj, _cancel_proc, _cancel_data);
        return ret != 0;
      }
      public bool AddFontMissingUnicode(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdfDocAddFontMissingUnicode(m_obj, _cancel_proc, _cancel_data);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfDocSave", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSave32(IntPtr obj, string _path, int _flags);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocSave", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSave64(IntPtr obj, string _path, int _flags);
      internal static byte PdfDocSave(IntPtr obj, string _path, int _flags)
      {
        if (Util.Is64BitProcess()) return PdfDocSave64(obj, _path, _flags);
        else return PdfDocSave32(obj, _path, _flags);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSaveToStream32(IntPtr obj, IntPtr _stream, int _flags);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSaveToStream64(IntPtr obj, IntPtr _stream, int _flags);
      internal static byte PdfDocSaveToStream(IntPtr obj, IntPtr _stream, int _flags)
      {
        if (Util.Is64BitProcess()) return PdfDocSaveToStream64(obj, _stream, _flags);
        else return PdfDocSaveToStream32(obj, _stream, _flags);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocClose", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocClose32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocClose", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocClose64(IntPtr obj);
      internal static byte PdfDocClose(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocClose64(obj);
        else return PdfDocClose32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocAddWatermarkFromImage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocAddWatermarkFromImage32(IntPtr obj, IntPtr _params, string _path);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocAddWatermarkFromImage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocAddWatermarkFromImage64(IntPtr obj, IntPtr _params, string _path);
      internal static byte PdfDocAddWatermarkFromImage(IntPtr obj, IntPtr _params, string _path)
      {
        if (Util.Is64BitProcess()) return PdfDocAddWatermarkFromImage64(obj, _params, _path);
        else return PdfDocAddWatermarkFromImage32(obj, _params, _path);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetNumPages", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumPages32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetNumPages", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumPages64(IntPtr obj);
      internal static int PdfDocGetNumPages(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetNumPages64(obj);
        else return PdfDocGetNumPages32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocAcquirePage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocAcquirePage32(IntPtr obj, int _page_num);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocAcquirePage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocAcquirePage64(IntPtr obj, int _page_num);
      internal static IntPtr PdfDocAcquirePage(IntPtr obj, int _page_num)
      {
        if (Util.Is64BitProcess()) return PdfDocAcquirePage64(obj, _page_num);
        else return PdfDocAcquirePage32(obj, _page_num);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetNumDocumentJavaScripts", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumDocumentJavaScripts32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetNumDocumentJavaScripts", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumDocumentJavaScripts64(IntPtr obj);
      internal static int PdfDocGetNumDocumentJavaScripts(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetNumDocumentJavaScripts64(obj);
        else return PdfDocGetNumDocumentJavaScripts32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetDocumentJavaScript", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetDocumentJavaScript32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetDocumentJavaScript", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetDocumentJavaScript64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdfDocGetDocumentJavaScript(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfDocGetDocumentJavaScript64(obj, _index, _buffer, _len);
        else return PdfDocGetDocumentJavaScript32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetDocumentJavaScriptName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetDocumentJavaScriptName32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetDocumentJavaScriptName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetDocumentJavaScriptName64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdfDocGetDocumentJavaScriptName(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfDocGetDocumentJavaScriptName64(obj, _index, _buffer, _len);
        else return PdfDocGetDocumentJavaScriptName32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetNumCalculatedFormFields", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumCalculatedFormFields32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetNumCalculatedFormFields", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumCalculatedFormFields64(IntPtr obj);
      internal static int PdfDocGetNumCalculatedFormFields(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetNumCalculatedFormFields64(obj);
        else return PdfDocGetNumCalculatedFormFields32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetCalculatedFormField", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetCalculatedFormField32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetCalculatedFormField", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetCalculatedFormField64(IntPtr obj, int _index);
      internal static IntPtr PdfDocGetCalculatedFormField(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfDocGetCalculatedFormField64(obj, _index);
        else return PdfDocGetCalculatedFormField32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetNumFormFields", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumFormFields32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetNumFormFields", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumFormFields64(IntPtr obj);
      internal static int PdfDocGetNumFormFields(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetNumFormFields64(obj);
        else return PdfDocGetNumFormFields32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetFormField", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetFormField32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetFormField", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetFormField64(IntPtr obj, int _index);
      internal static IntPtr PdfDocGetFormField(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfDocGetFormField64(obj, _index);
        else return PdfDocGetFormField32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetFormFieldByName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetFormFieldByName32(IntPtr obj, string _buffer);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetFormFieldByName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetFormFieldByName64(IntPtr obj, string _buffer);
      internal static IntPtr PdfDocGetFormFieldByName(IntPtr obj, string _buffer)
      {
        if (Util.Is64BitProcess()) return PdfDocGetFormFieldByName64(obj, _buffer);
        else return PdfDocGetFormFieldByName32(obj, _buffer);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetInfo", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetInfo32(IntPtr obj, string _key, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetInfo", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetInfo64(IntPtr obj, string _key, string _buffer, int _len);
      internal static int PdfDocGetInfo(IntPtr obj, string _key, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfDocGetInfo64(obj, _key, _buffer, _len);
        else return PdfDocGetInfo32(obj, _key, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocSetInfo", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSetInfo32(IntPtr obj, string _key, string _info);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocSetInfo", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSetInfo64(IntPtr obj, string _key, string _info);
      internal static byte PdfDocSetInfo(IntPtr obj, string _key, string _info)
      {
        if (Util.Is64BitProcess()) return PdfDocSetInfo64(obj, _key, _info);
        else return PdfDocSetInfo32(obj, _key, _info);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetBookmarkRoot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetBookmarkRoot32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetBookmarkRoot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetBookmarkRoot64(IntPtr obj);
      internal static IntPtr PdfDocGetBookmarkRoot(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetBookmarkRoot64(obj);
        else return PdfDocGetBookmarkRoot32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocFlattenAnnots", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocFlattenAnnots32(IntPtr obj, IntPtr _params);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocFlattenAnnots", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocFlattenAnnots64(IntPtr obj, IntPtr _params);
      internal static byte PdfDocFlattenAnnots(IntPtr obj, IntPtr _params)
      {
        if (Util.Is64BitProcess()) return PdfDocFlattenAnnots64(obj, _params);
        else return PdfDocFlattenAnnots32(obj, _params);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetNumAlternates", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumAlternates32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetNumAlternates", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetNumAlternates64(IntPtr obj);
      internal static int PdfDocGetNumAlternates(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetNumAlternates64(obj);
        else return PdfDocGetNumAlternates32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocAcquireAlternate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocAcquireAlternate32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocAcquireAlternate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocAcquireAlternate64(IntPtr obj, int _index);
      internal static IntPtr PdfDocAcquireAlternate(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfDocAcquireAlternate64(obj, _index);
        else return PdfDocAcquireAlternate32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreatePdsObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreatePdsObject32(IntPtr obj, int _type, bool _indirect);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreatePdsObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreatePdsObject64(IntPtr obj, int _type, bool _indirect);
      internal static IntPtr PdfDocCreatePdsObject(IntPtr obj, int _type, bool _indirect)
      {
        if (Util.Is64BitProcess()) return PdfDocCreatePdsObject64(obj, _type, _indirect);
        else return PdfDocCreatePdsObject32(obj, _type, _indirect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocAddTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocAddTags32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocAddTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocAddTags64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfDocAddTags(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfDocAddTags64(obj, _cancel_proc, _cancel_data);
        else return PdfDocAddTags32(obj, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocRemoveTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocRemoveTags32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocRemoveTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocRemoveTags64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfDocRemoveTags(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfDocRemoveTags64(obj, _cancel_proc, _cancel_data);
        else return PdfDocRemoveTags32(obj, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetDocTemplate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetDocTemplate32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetDocTemplate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetDocTemplate64(IntPtr obj);
      internal static IntPtr PdfDocGetDocTemplate(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetDocTemplate64(obj);
        else return PdfDocGetDocTemplate32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetMetadata", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetMetadata32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetMetadata", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetMetadata64(IntPtr obj);
      internal static IntPtr PdfDocGetMetadata(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetMetadata64(obj);
        else return PdfDocGetMetadata32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetLang", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetLang32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetLang", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocGetLang64(IntPtr obj, string _buffer, int _len);
      internal static int PdfDocGetLang(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfDocGetLang64(obj, _buffer, _len);
        else return PdfDocGetLang32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocSetLang", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSetLang32(IntPtr obj, string _lang);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocSetLang", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocSetLang64(IntPtr obj, string _lang);
      internal static byte PdfDocSetLang(IntPtr obj, string _lang)
      {
        if (Util.Is64BitProcess()) return PdfDocSetLang64(obj, _lang);
        else return PdfDocSetLang32(obj, _lang);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocEmbedFonts", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocEmbedFonts32(IntPtr obj, bool _subset, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocEmbedFonts", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocEmbedFonts64(IntPtr obj, bool _subset, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfDocEmbedFonts(IntPtr obj, bool _subset, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfDocEmbedFonts64(obj, _subset, _cancel_proc, _cancel_data);
        else return PdfDocEmbedFonts32(obj, _subset, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocMakeAccessible", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocMakeAccessible32(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocMakeAccessible", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocMakeAccessible64(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfDocMakeAccessible(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfDocMakeAccessible64(obj, _params, _cancel_proc, _cancel_data);
        else return PdfDocMakeAccessible32(obj, _params, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetRootObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetRootObject32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetRootObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetRootObject64(IntPtr obj);
      internal static IntPtr PdfDocGetRootObject(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetRootObject64(obj);
        else return PdfDocGetRootObject32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetInfoObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetInfoObject32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetInfoObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetInfoObject64(IntPtr obj);
      internal static IntPtr PdfDocGetInfoObject(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetInfoObject64(obj);
        else return PdfDocGetInfoObject32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateDictObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateDictObject32(IntPtr obj, bool _indirect);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateDictObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateDictObject64(IntPtr obj, bool _indirect);
      internal static IntPtr PdfDocCreateDictObject(IntPtr obj, bool _indirect)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateDictObject64(obj, _indirect);
        else return PdfDocCreateDictObject32(obj, _indirect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateArrayObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateArrayObject32(IntPtr obj, bool _indirect);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateArrayObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateArrayObject64(IntPtr obj, bool _indirect);
      internal static IntPtr PdfDocCreateArrayObject(IntPtr obj, bool _indirect)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateArrayObject64(obj, _indirect);
        else return PdfDocCreateArrayObject32(obj, _indirect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateNameObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateNameObject32(IntPtr obj, bool _indirect, string _value);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateNameObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateNameObject64(IntPtr obj, bool _indirect, string _value);
      internal static IntPtr PdfDocCreateNameObject(IntPtr obj, bool _indirect, string _value)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateNameObject64(obj, _indirect, _value);
        else return PdfDocCreateNameObject32(obj, _indirect, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateStringObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateStringObject32(IntPtr obj, bool _indirect, string _value, bool _hex);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateStringObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateStringObject64(IntPtr obj, bool _indirect, string _value, bool _hex);
      internal static IntPtr PdfDocCreateStringObject(IntPtr obj, bool _indirect, string _value, bool _hex)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateStringObject64(obj, _indirect, _value, _hex);
        else return PdfDocCreateStringObject32(obj, _indirect, _value, _hex);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateIntObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateIntObject32(IntPtr obj, bool _indirect, int _value);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateIntObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateIntObject64(IntPtr obj, bool _indirect, int _value);
      internal static IntPtr PdfDocCreateIntObject(IntPtr obj, bool _indirect, int _value)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateIntObject64(obj, _indirect, _value);
        else return PdfDocCreateIntObject32(obj, _indirect, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateNumberObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateNumberObject32(IntPtr obj, bool _indirect, double _value);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateNumberObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateNumberObject64(IntPtr obj, bool _indirect, double _value);
      internal static IntPtr PdfDocCreateNumberObject(IntPtr obj, bool _indirect, double _value)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateNumberObject64(obj, _indirect, _value);
        else return PdfDocCreateNumberObject32(obj, _indirect, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateStreamObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateStreamObject32(IntPtr obj, bool _indirect, IntPtr _dict, IntPtr _buffer, int _size);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateStreamObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateStreamObject64(IntPtr obj, bool _indirect, IntPtr _dict, IntPtr _buffer, int _size);
      internal static IntPtr PdfDocCreateStreamObject(IntPtr obj, bool _indirect, IntPtr _dict, IntPtr _buffer, int _size)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateStreamObject64(obj, _indirect, _dict, _buffer, _size);
        else return PdfDocCreateStreamObject32(obj, _indirect, _dict, _buffer, _size);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetObjectById", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetObjectById32(IntPtr obj, int _obj_id);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetObjectById", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetObjectById64(IntPtr obj, int _obj_id);
      internal static IntPtr PdfDocGetObjectById(IntPtr obj, int _obj_id)
      {
        if (Util.Is64BitProcess()) return PdfDocGetObjectById64(obj, _obj_id);
        else return PdfDocGetObjectById32(obj, _obj_id);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateStructTree32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocCreateStructTree64(IntPtr obj);
      internal static IntPtr PdfDocCreateStructTree(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateStructTree64(obj);
        else return PdfDocCreateStructTree32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocGetStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetStructTree32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocGetStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfDocGetStructTree64(IntPtr obj);
      internal static IntPtr PdfDocGetStructTree(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocGetStructTree64(obj);
        else return PdfDocGetStructTree32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocRemoveStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfDocRemoveStructTree32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocRemoveStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfDocRemoveStructTree64(IntPtr obj);
      internal static void PdfDocRemoveStructTree(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfDocRemoveStructTree64(obj);
        else PdfDocRemoveStructTree32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocRemoveBookmarks", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfDocRemoveBookmarks32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocRemoveBookmarks", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfDocRemoveBookmarks64(IntPtr obj);
      internal static void PdfDocRemoveBookmarks(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfDocRemoveBookmarks64(obj);
        else PdfDocRemoveBookmarks32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocCreateBookmarks", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocCreateBookmarks32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocCreateBookmarks", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocCreateBookmarks64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfDocCreateBookmarks(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfDocCreateBookmarks64(obj, _cancel_proc, _cancel_data);
        else return PdfDocCreateBookmarks32(obj, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocAddFontMissingUnicode", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocAddFontMissingUnicode32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocAddFontMissingUnicode", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocAddFontMissingUnicode64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfDocAddFontMissingUnicode(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfDocAddFontMissingUnicode64(obj, _cancel_proc, _cancel_data);
        else return PdfDocAddFontMissingUnicode32(obj, _cancel_proc, _cancel_data);
      }
    }
    public class PdfDocTemplate : PdfixBase
    {
      public PdfDocTemplate(IntPtr obj) : base(obj) { }
      public bool PreflightDoc(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdfDocTemplatePreflightDoc(m_obj, _cancel_proc, _cancel_data);
        return ret != 0;
      }
      public bool LoadFromStream(PsStream _stream, PsDataFormat _format)
      {
        CheckBaseObj();
        byte ret = PdfDocTemplateLoadFromStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj, (int)_format);
        return ret != 0;
      }
      public bool SaveToStream(PsStream _stream, PsDataFormat _format)
      {
        CheckBaseObj();
        byte ret = PdfDocTemplateSaveToStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj, (int)_format);
        return ret != 0;
      }
      public bool SetDefaults()
      {
        CheckBaseObj();
        byte ret = PdfDocTemplateSetDefaults(m_obj);
        return ret != 0;
      }
      public double GetProperty(string _name)
      {
        CheckBaseObj();
        double ret = PdfDocTemplateGetProperty(m_obj, _name);
        return ret;
      }
      public bool SetProperty(string _name, double _value)
      {
        CheckBaseObj();
        byte ret = PdfDocTemplateSetProperty(m_obj, _name, _value);
        return ret != 0;
      }
      public string GetRegex(string _name)
      {
        CheckBaseObj();
        int _buffer_sz = PdfDocTemplateGetRegex(m_obj, _name, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfDocTemplateGetRegex(m_obj, _name, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetRegex(string _name, string _pattern)
      {
        CheckBaseObj();
        byte ret = PdfDocTemplateSetRegex(m_obj, _name, _pattern);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplatePreflightDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplatePreflightDoc32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplatePreflightDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplatePreflightDoc64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfDocTemplatePreflightDoc(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplatePreflightDoc64(obj, _cancel_proc, _cancel_data);
        else return PdfDocTemplatePreflightDoc32(obj, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplateLoadFromStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateLoadFromStream32(IntPtr obj, IntPtr _stream, int _format);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplateLoadFromStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateLoadFromStream64(IntPtr obj, IntPtr _stream, int _format);
      internal static byte PdfDocTemplateLoadFromStream(IntPtr obj, IntPtr _stream, int _format)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplateLoadFromStream64(obj, _stream, _format);
        else return PdfDocTemplateLoadFromStream32(obj, _stream, _format);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplateSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSaveToStream32(IntPtr obj, IntPtr _stream, int _format);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplateSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSaveToStream64(IntPtr obj, IntPtr _stream, int _format);
      internal static byte PdfDocTemplateSaveToStream(IntPtr obj, IntPtr _stream, int _format)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplateSaveToStream64(obj, _stream, _format);
        else return PdfDocTemplateSaveToStream32(obj, _stream, _format);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplateSetDefaults", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSetDefaults32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplateSetDefaults", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSetDefaults64(IntPtr obj);
      internal static byte PdfDocTemplateSetDefaults(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplateSetDefaults64(obj);
        else return PdfDocTemplateSetDefaults32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplateGetProperty", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdfDocTemplateGetProperty32(IntPtr obj, string _name);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplateGetProperty", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern double PdfDocTemplateGetProperty64(IntPtr obj, string _name);
      internal static double PdfDocTemplateGetProperty(IntPtr obj, string _name)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplateGetProperty64(obj, _name);
        else return PdfDocTemplateGetProperty32(obj, _name);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplateSetProperty", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSetProperty32(IntPtr obj, string _name, double _value);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplateSetProperty", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSetProperty64(IntPtr obj, string _name, double _value);
      internal static byte PdfDocTemplateSetProperty(IntPtr obj, string _name, double _value)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplateSetProperty64(obj, _name, _value);
        else return PdfDocTemplateSetProperty32(obj, _name, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplateGetRegex", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocTemplateGetRegex32(IntPtr obj, string _name, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplateGetRegex", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfDocTemplateGetRegex64(IntPtr obj, string _name, string _buffer, int _len);
      internal static int PdfDocTemplateGetRegex(IntPtr obj, string _name, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplateGetRegex64(obj, _name, _buffer, _len);
        else return PdfDocTemplateGetRegex32(obj, _name, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfDocTemplateSetRegex", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSetRegex32(IntPtr obj, string _name, string _pattern);
      [DllImport("pdfix64.dll", EntryPoint="PdfDocTemplateSetRegex", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfDocTemplateSetRegex64(IntPtr obj, string _name, string _pattern);
      internal static byte PdfDocTemplateSetRegex(IntPtr obj, string _name, string _pattern)
      {
        if (Util.Is64BitProcess()) return PdfDocTemplateSetRegex64(obj, _name, _pattern);
        else return PdfDocTemplateSetRegex32(obj, _name, _pattern);
      }
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
        byte ret = PdfAlternateSaveContent(m_obj, _path);
        return ret != 0;
      }
      public void Release()
      {
        CheckBaseObj();
        PdfAlternateRelease(m_obj);
      }

      [DllImport("pdfix.dll", EntryPoint="PdfAlternateGetSubtype", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlternateType PdfAlternateGetSubtype32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfAlternateGetSubtype", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfAlternateType PdfAlternateGetSubtype64(IntPtr obj);
      internal static PdfAlternateType PdfAlternateGetSubtype(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfAlternateGetSubtype64(obj);
        else return PdfAlternateGetSubtype32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAlternateGetName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetName32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfAlternateGetName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetName64(IntPtr obj, string _buffer, int _len);
      internal static int PdfAlternateGetName(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfAlternateGetName64(obj, _buffer, _len);
        else return PdfAlternateGetName32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAlternateGetDescription", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetDescription32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfAlternateGetDescription", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetDescription64(IntPtr obj, string _buffer, int _len);
      internal static int PdfAlternateGetDescription(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfAlternateGetDescription64(obj, _buffer, _len);
        else return PdfAlternateGetDescription32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAlternateGetFileName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetFileName32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfAlternateGetFileName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfAlternateGetFileName64(IntPtr obj, string _buffer, int _len);
      internal static int PdfAlternateGetFileName(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfAlternateGetFileName64(obj, _buffer, _len);
        else return PdfAlternateGetFileName32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAlternateSaveContent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfAlternateSaveContent32(IntPtr obj, string _path);
      [DllImport("pdfix64.dll", EntryPoint="PdfAlternateSaveContent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfAlternateSaveContent64(IntPtr obj, string _path);
      internal static byte PdfAlternateSaveContent(IntPtr obj, string _path)
      {
        if (Util.Is64BitProcess()) return PdfAlternateSaveContent64(obj, _path);
        else return PdfAlternateSaveContent32(obj, _path);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfAlternateRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAlternateRelease32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfAlternateRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfAlternateRelease64(IntPtr obj);
      internal static void PdfAlternateRelease(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfAlternateRelease64(obj);
        else PdfAlternateRelease32(obj);
      }
    }
    public class PdfHtmlAlternate : PdfAlternate    {
      public PdfHtmlAlternate(IntPtr obj) : base(obj) { }
      public bool SaveResource(string _resource_name, string _path)
      {
        CheckBaseObj();
        byte ret = PdfHtmlAlternateSaveResource(m_obj, _resource_name, _path);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfHtmlAlternateSaveResource", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfHtmlAlternateSaveResource32(IntPtr obj, string _resource_name, string _path);
      [DllImport("pdfix64.dll", EntryPoint="PdfHtmlAlternateSaveResource", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfHtmlAlternateSaveResource64(IntPtr obj, string _resource_name, string _path);
      internal static byte PdfHtmlAlternateSaveResource(IntPtr obj, string _resource_name, string _path)
      {
        if (Util.Is64BitProcess()) return PdfHtmlAlternateSaveResource64(obj, _resource_name, _path);
        else return PdfHtmlAlternateSaveResource32(obj, _resource_name, _path);
      }
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
        byte ret = PdfFontGetSystemFontBold(m_obj);
        return ret != 0;
      }
      public bool GetSystemFontItalic()
      {
        CheckBaseObj();
        byte ret = PdfFontGetSystemFontItalic(m_obj);
        return ret != 0;
      }
      public bool SaveToStream(PsStream _stream, PdfFontFormat _format)
      {
        CheckBaseObj();
        byte ret = PdfFontSaveToStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj, (int)_format);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfFontGetFontName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetFontName32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontGetFontName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetFontName64(IntPtr obj, string _buffer, int _len);
      internal static int PdfFontGetFontName(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFontGetFontName64(obj, _buffer, _len);
        else return PdfFontGetFontName32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFontGetFaceName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetFaceName32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontGetFaceName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetFaceName64(IntPtr obj, string _buffer, int _len);
      internal static int PdfFontGetFaceName(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFontGetFaceName64(obj, _buffer, _len);
        else return PdfFontGetFaceName32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFontGetFontState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfFontGetFontState32(IntPtr obj, IntPtr _font_state);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontGetFontState", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfFontGetFontState64(IntPtr obj, IntPtr _font_state);
      internal static void PdfFontGetFontState(IntPtr obj, IntPtr _font_state)
      {
        if (Util.Is64BitProcess()) PdfFontGetFontState64(obj, _font_state);
        else PdfFontGetFontState32(obj, _font_state);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFontGetSystemFontName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetSystemFontName32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontGetSystemFontName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFontGetSystemFontName64(IntPtr obj, string _buffer, int _len);
      internal static int PdfFontGetSystemFontName(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFontGetSystemFontName64(obj, _buffer, _len);
        else return PdfFontGetSystemFontName32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFontGetSystemFontCharset", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfFontCharset PdfFontGetSystemFontCharset32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontGetSystemFontCharset", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfFontCharset PdfFontGetSystemFontCharset64(IntPtr obj);
      internal static PdfFontCharset PdfFontGetSystemFontCharset(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFontGetSystemFontCharset64(obj);
        else return PdfFontGetSystemFontCharset32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFontGetSystemFontBold", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFontGetSystemFontBold32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontGetSystemFontBold", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFontGetSystemFontBold64(IntPtr obj);
      internal static byte PdfFontGetSystemFontBold(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFontGetSystemFontBold64(obj);
        else return PdfFontGetSystemFontBold32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFontGetSystemFontItalic", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFontGetSystemFontItalic32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontGetSystemFontItalic", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFontGetSystemFontItalic64(IntPtr obj);
      internal static byte PdfFontGetSystemFontItalic(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFontGetSystemFontItalic64(obj);
        else return PdfFontGetSystemFontItalic32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFontSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFontSaveToStream32(IntPtr obj, IntPtr _stream, int _format);
      [DllImport("pdfix64.dll", EntryPoint="PdfFontSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFontSaveToStream64(IntPtr obj, IntPtr _stream, int _format);
      internal static byte PdfFontSaveToStream(IntPtr obj, IntPtr _stream, int _format)
      {
        if (Util.Is64BitProcess()) return PdfFontSaveToStream64(obj, _stream, _format);
        else return PdfFontSaveToStream32(obj, _stream, _format);
      }
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
        byte ret = PdfFormFieldSetFlags(m_obj, _flags);
        return ret != 0;
      }
      public string GetValue()
      {
        CheckBaseObj();
        int _buffer_sz = PdfFormFieldGetValue(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetValue(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetValue(string _value)
      {
        CheckBaseObj();
        byte ret = PdfFormFieldSetValue(m_obj, _value);
        return ret != 0;
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
        int _buffer_sz = PdfFormFieldGetWidgetExportValue(m_obj, _annot == null ? IntPtr.Zero : _annot.m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdfFormFieldGetWidgetExportValue(m_obj, _annot == null ? IntPtr.Zero : _annot.m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfFieldType PdfFormFieldGetType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfFieldType PdfFormFieldGetType64(IntPtr obj);
      internal static PdfFieldType PdfFormFieldGetType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetType64(obj);
        else return PdfFormFieldGetType32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetFlags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetFlags64(IntPtr obj);
      internal static int PdfFormFieldGetFlags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetFlags64(obj);
        else return PdfFormFieldGetFlags32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldSetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFormFieldSetFlags32(IntPtr obj, int _flags);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldSetFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFormFieldSetFlags64(IntPtr obj, int _flags);
      internal static byte PdfFormFieldSetFlags(IntPtr obj, int _flags)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldSetFlags64(obj, _flags);
        else return PdfFormFieldSetFlags32(obj, _flags);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetValue32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetValue64(IntPtr obj, string _buffer, int _len);
      internal static int PdfFormFieldGetValue(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetValue64(obj, _buffer, _len);
        else return PdfFormFieldGetValue32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldSetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFormFieldSetValue32(IntPtr obj, string _value);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldSetValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfFormFieldSetValue64(IntPtr obj, string _value);
      internal static byte PdfFormFieldSetValue(IntPtr obj, string _value)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldSetValue64(obj, _value);
        else return PdfFormFieldSetValue32(obj, _value);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetDefaultValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetDefaultValue32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetDefaultValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetDefaultValue64(IntPtr obj, string _buffer, int _len);
      internal static int PdfFormFieldGetDefaultValue(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetDefaultValue64(obj, _buffer, _len);
        else return PdfFormFieldGetDefaultValue32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetFullName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetFullName32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetFullName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetFullName64(IntPtr obj, string _buffer, int _len);
      internal static int PdfFormFieldGetFullName(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetFullName64(obj, _buffer, _len);
        else return PdfFormFieldGetFullName32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetTooltip", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetTooltip32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetTooltip", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetTooltip64(IntPtr obj, string _buffer, int _len);
      internal static int PdfFormFieldGetTooltip(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetTooltip64(obj, _buffer, _len);
        else return PdfFormFieldGetTooltip32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetOptionCount", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionCount32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetOptionCount", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionCount64(IntPtr obj);
      internal static int PdfFormFieldGetOptionCount(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetOptionCount64(obj);
        else return PdfFormFieldGetOptionCount32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetOptionValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionValue32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetOptionValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionValue64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdfFormFieldGetOptionValue(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetOptionValue64(obj, _index, _buffer, _len);
        else return PdfFormFieldGetOptionValue32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetOptionCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionCaption32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetOptionCaption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetOptionCaption64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PdfFormFieldGetOptionCaption(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetOptionCaption64(obj, _index, _buffer, _len);
        else return PdfFormFieldGetOptionCaption32(obj, _index, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfFormFieldGetAction32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfFormFieldGetAction64(IntPtr obj);
      internal static IntPtr PdfFormFieldGetAction(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetAction64(obj);
        else return PdfFormFieldGetAction32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetAAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfFormFieldGetAAction32(IntPtr obj, int _event);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetAAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfFormFieldGetAAction64(IntPtr obj, int _event);
      internal static IntPtr PdfFormFieldGetAAction(IntPtr obj, int _event)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetAAction64(obj, _event);
        else return PdfFormFieldGetAAction32(obj, _event);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetMaxLength", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetMaxLength32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetMaxLength", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetMaxLength64(IntPtr obj);
      internal static int PdfFormFieldGetMaxLength(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetMaxLength64(obj);
        else return PdfFormFieldGetMaxLength32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfFormFieldGetWidgetExportValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetWidgetExportValue32(IntPtr obj, IntPtr _annot, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfFormFieldGetWidgetExportValue", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfFormFieldGetWidgetExportValue64(IntPtr obj, IntPtr _annot, string _buffer, int _len);
      internal static int PdfFormFieldGetWidgetExportValue(IntPtr obj, IntPtr _annot, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfFormFieldGetWidgetExportValue64(obj, _annot, _buffer, _len);
        else return PdfFormFieldGetWidgetExportValue32(obj, _annot, _buffer, _len);
      }
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
        byte ret = PsImageSave(m_obj, _path, _params_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret != 0;
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
        byte ret = PsImageSaveRect(m_obj, _path, _params_ptr, _dev_rect_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        Marshal.FreeHGlobal(_dev_rect_ptr);
        _dev_rect_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public bool SaveToStream(PsStream _stream, PdfImageParams _params)
      {
        CheckBaseObj();
        PdfImageParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfImageParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        byte ret = PsImageSaveToStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj, _params_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret != 0;
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
        byte ret = PsImageSaveRectToStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj, _params_ptr, _dev_rect_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        Marshal.FreeHGlobal(_dev_rect_ptr);
        _dev_rect_ptr = IntPtr.Zero;
        return ret != 0;
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

      [DllImport("pdfix.dll", EntryPoint="PsImageDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsImageDestroy32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsImageDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsImageDestroy64(IntPtr obj);
      internal static void PsImageDestroy(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PsImageDestroy64(obj);
        else PsImageDestroy32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsImageSave", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSave32(IntPtr obj, string _path, IntPtr _params);
      [DllImport("pdfix64.dll", EntryPoint="PsImageSave", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSave64(IntPtr obj, string _path, IntPtr _params);
      internal static byte PsImageSave(IntPtr obj, string _path, IntPtr _params)
      {
        if (Util.Is64BitProcess()) return PsImageSave64(obj, _path, _params);
        else return PsImageSave32(obj, _path, _params);
      }
      [DllImport("pdfix.dll", EntryPoint="PsImageSaveRect", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSaveRect32(IntPtr obj, string _path, IntPtr _params, IntPtr _dev_rect);
      [DllImport("pdfix64.dll", EntryPoint="PsImageSaveRect", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSaveRect64(IntPtr obj, string _path, IntPtr _params, IntPtr _dev_rect);
      internal static byte PsImageSaveRect(IntPtr obj, string _path, IntPtr _params, IntPtr _dev_rect)
      {
        if (Util.Is64BitProcess()) return PsImageSaveRect64(obj, _path, _params, _dev_rect);
        else return PsImageSaveRect32(obj, _path, _params, _dev_rect);
      }
      [DllImport("pdfix.dll", EntryPoint="PsImageSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSaveToStream32(IntPtr obj, IntPtr _stream, IntPtr _params);
      [DllImport("pdfix64.dll", EntryPoint="PsImageSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSaveToStream64(IntPtr obj, IntPtr _stream, IntPtr _params);
      internal static byte PsImageSaveToStream(IntPtr obj, IntPtr _stream, IntPtr _params)
      {
        if (Util.Is64BitProcess()) return PsImageSaveToStream64(obj, _stream, _params);
        else return PsImageSaveToStream32(obj, _stream, _params);
      }
      [DllImport("pdfix.dll", EntryPoint="PsImageSaveRectToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSaveRectToStream32(IntPtr obj, IntPtr _stream, IntPtr _params, IntPtr _dev_rect);
      [DllImport("pdfix64.dll", EntryPoint="PsImageSaveRectToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsImageSaveRectToStream64(IntPtr obj, IntPtr _stream, IntPtr _params, IntPtr _dev_rect);
      internal static byte PsImageSaveRectToStream(IntPtr obj, IntPtr _stream, IntPtr _params, IntPtr _dev_rect)
      {
        if (Util.Is64BitProcess()) return PsImageSaveRectToStream64(obj, _stream, _params, _dev_rect);
        else return PsImageSaveRectToStream32(obj, _stream, _params, _dev_rect);
      }
      [DllImport("pdfix.dll", EntryPoint="PsImageGetPointColor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsImageGetPointColor32(IntPtr obj, IntPtr _point, IntPtr _color);
      [DllImport("pdfix64.dll", EntryPoint="PsImageGetPointColor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsImageGetPointColor64(IntPtr obj, IntPtr _point, IntPtr _color);
      internal static void PsImageGetPointColor(IntPtr obj, IntPtr _point, IntPtr _color)
      {
        if (Util.Is64BitProcess()) PsImageGetPointColor64(obj, _point, _color);
        else PsImageGetPointColor32(obj, _point, _color);
      }
    }
    public class PdfPage : PdfixBase
    {
      public PdfPage(IntPtr obj) : base(obj) { }
      public void Release()
      {
        CheckBaseObj();
        PdfPageRelease(m_obj);
      }
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
      public PdfRotate GetLogicalRotate()
      {
        CheckBaseObj();
        PdfRotate ret = PdfPageGetLogicalRotate(m_obj);
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
      public PdePageMap CreatePageMap()
      {
        CheckBaseObj();
        IntPtr ret = PdfPageCreatePageMap(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdePageMap(ret);
        }
        return null;
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
          switch (PdfAnnot.PdfAnnotGetSubtype(ret))
          {
            case PdfAnnotSubtype.kAnnotText: return new PdfTextAnnot(ret);
            case PdfAnnotSubtype.kAnnotLink: return new PdfLinkAnnot(ret);
            case PdfAnnotSubtype.kAnnotFreeText: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquare: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCircle: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolygon: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolyLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotHighlight: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotUnderline: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquiggly: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStrikeOut: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStamp: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCaret: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotInk: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPopup: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotFileAttachment: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSound: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotMovie: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWidget: return new PdfWidgetAnnot(ret);
            case PdfAnnotSubtype.kAnnotScreen: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPrinterMark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotTrapNet: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWatermark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnot3D: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotRedact: return new PdfAnnot(ret);
            default: return new PdfAnnot(ret);
          }
        }
        return null;
      }
      public bool RemoveAnnot(int _index, int _flags)
      {
        CheckBaseObj();
        byte ret = PdfPageRemoveAnnot(m_obj, _index, _flags);
        return ret != 0;
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
          switch (PdfAnnot.PdfAnnotGetSubtype(ret))
          {
            case PdfAnnotSubtype.kAnnotText: return new PdfTextAnnot(ret);
            case PdfAnnotSubtype.kAnnotLink: return new PdfLinkAnnot(ret);
            case PdfAnnotSubtype.kAnnotFreeText: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquare: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCircle: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolygon: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolyLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotHighlight: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotUnderline: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquiggly: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStrikeOut: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStamp: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCaret: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotInk: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPopup: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotFileAttachment: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSound: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotMovie: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWidget: return new PdfWidgetAnnot(ret);
            case PdfAnnotSubtype.kAnnotScreen: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPrinterMark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotTrapNet: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWatermark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnot3D: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotRedact: return new PdfAnnot(ret);
            default: return new PdfAnnot(ret);
          }
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
          switch (PdfAnnot.PdfAnnotGetSubtype(ret))
          {
            case PdfAnnotSubtype.kAnnotText: return new PdfTextAnnot(ret);
            case PdfAnnotSubtype.kAnnotLink: return new PdfLinkAnnot(ret);
            case PdfAnnotSubtype.kAnnotFreeText: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquare: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCircle: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolygon: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolyLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotHighlight: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotUnderline: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquiggly: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStrikeOut: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStamp: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCaret: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotInk: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPopup: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotFileAttachment: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSound: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotMovie: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWidget: return new PdfWidgetAnnot(ret);
            case PdfAnnotSubtype.kAnnotScreen: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPrinterMark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotTrapNet: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWatermark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnot3D: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotRedact: return new PdfAnnot(ret);
            default: return new PdfAnnot(ret);
          }
        }
        return null;
      }
      public bool DrawContent(PdfPageRenderParams _params, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfPageRenderParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfPageRenderParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        byte ret = PdfPageDrawContent(m_obj, _params_ptr, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public int GetNumPageObjects()
      {
        CheckBaseObj();
        int ret = PdfPageGetNumPageObjects(m_obj);
        return ret;
      }
      public PdsPageObject GetPageObject(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdfPageGetPageObject(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdsPageObject.PdsPageObjectGetObjectType(ret))
          {
            case PdfPageObjectType.kPdsPageText: return new PdsText(ret);
            case PdfPageObjectType.kPdsPagePath: return new PdsPath(ret);
            case PdfPageObjectType.kPdsPageImage: return new PdsImage(ret);
            case PdfPageObjectType.kPdsPageShading: return new PdsShading(ret);
            case PdfPageObjectType.kPdsPageForm: return new PdsForm(ret);
            default: return new PdsPageObject(ret);
          }
        }
        return null;
      }
      public PdsDictionary GetResources(string _res_type, bool _create)
      {
        CheckBaseObj();
        IntPtr ret = PdfPageGetResources(m_obj, _res_type, _create);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public PdsDictionary GetObject()
      {
        CheckBaseObj();
        IntPtr ret = PdfPageGetObject(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public bool FlattenFormXObjects()
      {
        CheckBaseObj();
        byte ret = PdfPageFlattenFormXObjects(m_obj);
        return ret != 0;
      }
      public int GetContentFlags()
      {
        CheckBaseObj();
        int ret = PdfPageGetContentFlags(m_obj);
        return ret;
      }
      public bool SetContent()
      {
        CheckBaseObj();
        byte ret = PdfPageSetContent(m_obj);
        return ret != 0;
      }
      public PdfDoc GetDoc()
      {
        CheckBaseObj();
        IntPtr ret = PdfPageGetDoc(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfDoc(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfPageRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageRelease32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageRelease64(IntPtr obj);
      internal static void PdfPageRelease(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfPageRelease64(obj);
        else PdfPageRelease32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetCropBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetCropBox32(IntPtr obj, IntPtr _crop_box);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetCropBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetCropBox64(IntPtr obj, IntPtr _crop_box);
      internal static void PdfPageGetCropBox(IntPtr obj, IntPtr _crop_box)
      {
        if (Util.Is64BitProcess()) PdfPageGetCropBox64(obj, _crop_box);
        else PdfPageGetCropBox32(obj, _crop_box);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetMediaBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetMediaBox32(IntPtr obj, IntPtr _media_box);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetMediaBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetMediaBox64(IntPtr obj, IntPtr _media_box);
      internal static void PdfPageGetMediaBox(IntPtr obj, IntPtr _media_box)
      {
        if (Util.Is64BitProcess()) PdfPageGetMediaBox64(obj, _media_box);
        else PdfPageGetMediaBox32(obj, _media_box);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetRotate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfRotate PdfPageGetRotate32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetRotate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfRotate PdfPageGetRotate64(IntPtr obj);
      internal static PdfRotate PdfPageGetRotate(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetRotate64(obj);
        else return PdfPageGetRotate32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetLogicalRotate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfRotate PdfPageGetLogicalRotate32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetLogicalRotate", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfRotate PdfPageGetLogicalRotate64(IntPtr obj);
      internal static PdfRotate PdfPageGetLogicalRotate(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetLogicalRotate64(obj);
        else return PdfPageGetLogicalRotate32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetDefaultMatrix", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetDefaultMatrix32(IntPtr obj, IntPtr _matrix);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetDefaultMatrix", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageGetDefaultMatrix64(IntPtr obj, IntPtr _matrix);
      internal static void PdfPageGetDefaultMatrix(IntPtr obj, IntPtr _matrix)
      {
        if (Util.Is64BitProcess()) PdfPageGetDefaultMatrix64(obj, _matrix);
        else PdfPageGetDefaultMatrix32(obj, _matrix);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumber32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumber64(IntPtr obj);
      internal static int PdfPageGetNumber(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetNumber64(obj);
        else return PdfPageGetNumber32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageCreatePageMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageCreatePageMap32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageCreatePageMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageCreatePageMap64(IntPtr obj);
      internal static IntPtr PdfPageCreatePageMap(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageCreatePageMap64(obj);
        else return PdfPageCreatePageMap32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageAcquirePageMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAcquirePageMap32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageAcquirePageMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAcquirePageMap64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static IntPtr PdfPageAcquirePageMap(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfPageAcquirePageMap64(obj, _cancel_proc, _cancel_data);
        else return PdfPageAcquirePageMap32(obj, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageAcquirePageView", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAcquirePageView32(IntPtr obj, double _zoom, int _rotate);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageAcquirePageView", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAcquirePageView64(IntPtr obj, double _zoom, int _rotate);
      internal static IntPtr PdfPageAcquirePageView(IntPtr obj, double _zoom, int _rotate)
      {
        if (Util.Is64BitProcess()) return PdfPageAcquirePageView64(obj, _zoom, _rotate);
        else return PdfPageAcquirePageView32(obj, _zoom, _rotate);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetNumAnnots", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnots32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetNumAnnots", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnots64(IntPtr obj);
      internal static int PdfPageGetNumAnnots(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetNumAnnots64(obj);
        else return PdfPageGetNumAnnots32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnot32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnot64(IntPtr obj, int _index);
      internal static IntPtr PdfPageGetAnnot(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfPageGetAnnot64(obj, _index);
        else return PdfPageGetAnnot32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageRemoveAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageRemoveAnnot32(IntPtr obj, int _index, int _flags);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageRemoveAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageRemoveAnnot64(IntPtr obj, int _index, int _flags);
      internal static byte PdfPageRemoveAnnot(IntPtr obj, int _index, int _flags)
      {
        if (Util.Is64BitProcess()) return PdfPageRemoveAnnot64(obj, _index, _flags);
        else return PdfPageRemoveAnnot32(obj, _index, _flags);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageAddTextAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddTextAnnot32(IntPtr obj, int _index, IntPtr _rect);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageAddTextAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddTextAnnot64(IntPtr obj, int _index, IntPtr _rect);
      internal static IntPtr PdfPageAddTextAnnot(IntPtr obj, int _index, IntPtr _rect)
      {
        if (Util.Is64BitProcess()) return PdfPageAddTextAnnot64(obj, _index, _rect);
        else return PdfPageAddTextAnnot32(obj, _index, _rect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageAddLinkAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddLinkAnnot32(IntPtr obj, int _index, IntPtr _rect);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageAddLinkAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddLinkAnnot64(IntPtr obj, int _index, IntPtr _rect);
      internal static IntPtr PdfPageAddLinkAnnot(IntPtr obj, int _index, IntPtr _rect)
      {
        if (Util.Is64BitProcess()) return PdfPageAddLinkAnnot64(obj, _index, _rect);
        else return PdfPageAddLinkAnnot32(obj, _index, _rect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageAddTextMarkupAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddTextMarkupAnnot32(IntPtr obj, int _index, IntPtr _rect, int _subtype);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageAddTextMarkupAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageAddTextMarkupAnnot64(IntPtr obj, int _index, IntPtr _rect, int _subtype);
      internal static IntPtr PdfPageAddTextMarkupAnnot(IntPtr obj, int _index, IntPtr _rect, int _subtype)
      {
        if (Util.Is64BitProcess()) return PdfPageAddTextMarkupAnnot64(obj, _index, _rect, _subtype);
        else return PdfPageAddTextMarkupAnnot32(obj, _index, _rect, _subtype);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetNumAnnotsAtPoint", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnotsAtPoint32(IntPtr obj, IntPtr _point);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetNumAnnotsAtPoint", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnotsAtPoint64(IntPtr obj, IntPtr _point);
      internal static int PdfPageGetNumAnnotsAtPoint(IntPtr obj, IntPtr _point)
      {
        if (Util.Is64BitProcess()) return PdfPageGetNumAnnotsAtPoint64(obj, _point);
        else return PdfPageGetNumAnnotsAtPoint32(obj, _point);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetAnnotAtPoint", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnotAtPoint32(IntPtr obj, IntPtr _point, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetAnnotAtPoint", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnotAtPoint64(IntPtr obj, IntPtr _point, int _index);
      internal static IntPtr PdfPageGetAnnotAtPoint(IntPtr obj, IntPtr _point, int _index)
      {
        if (Util.Is64BitProcess()) return PdfPageGetAnnotAtPoint64(obj, _point, _index);
        else return PdfPageGetAnnotAtPoint32(obj, _point, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetNumAnnotsAtRect", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnotsAtRect32(IntPtr obj, IntPtr _rect);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetNumAnnotsAtRect", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumAnnotsAtRect64(IntPtr obj, IntPtr _rect);
      internal static int PdfPageGetNumAnnotsAtRect(IntPtr obj, IntPtr _rect)
      {
        if (Util.Is64BitProcess()) return PdfPageGetNumAnnotsAtRect64(obj, _rect);
        else return PdfPageGetNumAnnotsAtRect32(obj, _rect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetAnnotAtRect", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnotAtRect32(IntPtr obj, IntPtr _rect, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetAnnotAtRect", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetAnnotAtRect64(IntPtr obj, IntPtr _rect, int _index);
      internal static IntPtr PdfPageGetAnnotAtRect(IntPtr obj, IntPtr _rect, int _index)
      {
        if (Util.Is64BitProcess()) return PdfPageGetAnnotAtRect64(obj, _rect, _index);
        else return PdfPageGetAnnotAtRect32(obj, _rect, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageDrawContent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageDrawContent32(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageDrawContent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageDrawContent64(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdfPageDrawContent(IntPtr obj, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdfPageDrawContent64(obj, _params, _cancel_proc, _cancel_data);
        else return PdfPageDrawContent32(obj, _params, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetNumPageObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumPageObjects32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetNumPageObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetNumPageObjects64(IntPtr obj);
      internal static int PdfPageGetNumPageObjects(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetNumPageObjects64(obj);
        else return PdfPageGetNumPageObjects32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetPageObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetPageObject32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetPageObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetPageObject64(IntPtr obj, int _index);
      internal static IntPtr PdfPageGetPageObject(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfPageGetPageObject64(obj, _index);
        else return PdfPageGetPageObject32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetResources", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetResources32(IntPtr obj, string _res_type, bool _create);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetResources", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetResources64(IntPtr obj, string _res_type, bool _create);
      internal static IntPtr PdfPageGetResources(IntPtr obj, string _res_type, bool _create)
      {
        if (Util.Is64BitProcess()) return PdfPageGetResources64(obj, _res_type, _create);
        else return PdfPageGetResources32(obj, _res_type, _create);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetObject32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetObject64(IntPtr obj);
      internal static IntPtr PdfPageGetObject(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetObject64(obj);
        else return PdfPageGetObject32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageFlattenFormXObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageFlattenFormXObjects32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageFlattenFormXObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageFlattenFormXObjects64(IntPtr obj);
      internal static byte PdfPageFlattenFormXObjects(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageFlattenFormXObjects64(obj);
        else return PdfPageFlattenFormXObjects32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetContentFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetContentFlags32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetContentFlags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageGetContentFlags64(IntPtr obj);
      internal static int PdfPageGetContentFlags(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetContentFlags64(obj);
        else return PdfPageGetContentFlags32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageSetContent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageSetContent32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageSetContent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfPageSetContent64(IntPtr obj);
      internal static byte PdfPageSetContent(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageSetContent64(obj);
        else return PdfPageSetContent32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageGetDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetDoc32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageGetDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfPageGetDoc64(IntPtr obj);
      internal static IntPtr PdfPageGetDoc(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageGetDoc64(obj);
        else return PdfPageGetDoc32(obj);
      }
    }
    public class PdePageMap : PdfixBase
    {
      public PdePageMap(IntPtr obj) : base(obj) { }
      public void Release()
      {
        CheckBaseObj();
        PdePageMapRelease(m_obj);
      }
      public PdeElement GetElement()
      {
        CheckBaseObj();
        IntPtr ret = PdePageMapGetElement(m_obj);
        if (ret != IntPtr.Zero)
        {
          switch (PdeElement.PdeElementGetType(ret))
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
            case PdfElementType.kPdeToc: return new PdeToc(ret);
            default: return new PdeElement(ret);
          }
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
        byte ret = PdePageMapGetWhitespace(m_obj, _params_ptr, _index, _bbox_ptr);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        PdfRectInt _bboxInt = (PdfRectInt)Marshal.PtrToStructure(_bbox_ptr, typeof(PdfRectInt));
        PdfRect _bbox = new PdfRect();
        _bbox.SetIntStruct(_bboxInt);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
        return _bbox;
      }
      public void GetBBox(PdfRect _bbox)
      {
        CheckBaseObj();
        PdfRectInt _bboxInt = _bbox.GetIntStruct();
        IntPtr _bbox_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfRectInt)));
        Marshal.StructureToPtr(_bboxInt, _bbox_ptr, true);
        PdePageMapGetBBox(m_obj, _bbox_ptr);
        Marshal.FreeHGlobal(_bbox_ptr);
        _bbox_ptr = IntPtr.Zero;
      }
      public bool AcquireElements(PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdePageMapAcquireElements(m_obj, _cancel_proc, _cancel_data);
        return ret != 0;
      }
      public PdeElement CreateElement(PdfElementType _type, PdeElement _parent)
      {
        CheckBaseObj();
        IntPtr ret = PdePageMapCreateElement(m_obj, (int)_type, _parent == null ? IntPtr.Zero : _parent.m_obj);
        if (ret != IntPtr.Zero)
        {
          switch (PdeElement.PdeElementGetType(ret))
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
            case PdfElementType.kPdeToc: return new PdeToc(ret);
            default: return new PdeElement(ret);
          }
        }
        return null;
      }
      public bool AddTags(PdsStructElement _element, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        byte ret = PdePageMapAddTags(m_obj, _element == null ? IntPtr.Zero : _element.m_obj, _cancel_proc, _cancel_data);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdePageMapRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdePageMapRelease32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdePageMapRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdePageMapRelease64(IntPtr obj);
      internal static void PdePageMapRelease(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdePageMapRelease64(obj);
        else PdePageMapRelease32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdePageMapGetElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdePageMapGetElement32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdePageMapGetElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdePageMapGetElement64(IntPtr obj);
      internal static IntPtr PdePageMapGetElement(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdePageMapGetElement64(obj);
        else return PdePageMapGetElement32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdePageMapGetWhitespace", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdePageMapGetWhitespace32(IntPtr obj, IntPtr _params, int _index, IntPtr _bbox);
      [DllImport("pdfix64.dll", EntryPoint="PdePageMapGetWhitespace", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdePageMapGetWhitespace64(IntPtr obj, IntPtr _params, int _index, IntPtr _bbox);
      internal static byte PdePageMapGetWhitespace(IntPtr obj, IntPtr _params, int _index, IntPtr _bbox)
      {
        if (Util.Is64BitProcess()) return PdePageMapGetWhitespace64(obj, _params, _index, _bbox);
        else return PdePageMapGetWhitespace32(obj, _params, _index, _bbox);
      }
      [DllImport("pdfix.dll", EntryPoint="PdePageMapGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdePageMapGetBBox32(IntPtr obj, IntPtr _bbox);
      [DllImport("pdfix64.dll", EntryPoint="PdePageMapGetBBox", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdePageMapGetBBox64(IntPtr obj, IntPtr _bbox);
      internal static void PdePageMapGetBBox(IntPtr obj, IntPtr _bbox)
      {
        if (Util.Is64BitProcess()) PdePageMapGetBBox64(obj, _bbox);
        else PdePageMapGetBBox32(obj, _bbox);
      }
      [DllImport("pdfix.dll", EntryPoint="PdePageMapAcquireElements", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdePageMapAcquireElements32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdePageMapAcquireElements", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdePageMapAcquireElements64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdePageMapAcquireElements(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdePageMapAcquireElements64(obj, _cancel_proc, _cancel_data);
        else return PdePageMapAcquireElements32(obj, _cancel_proc, _cancel_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdePageMapCreateElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdePageMapCreateElement32(IntPtr obj, int _type, IntPtr _parent);
      [DllImport("pdfix64.dll", EntryPoint="PdePageMapCreateElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdePageMapCreateElement64(IntPtr obj, int _type, IntPtr _parent);
      internal static IntPtr PdePageMapCreateElement(IntPtr obj, int _type, IntPtr _parent)
      {
        if (Util.Is64BitProcess()) return PdePageMapCreateElement64(obj, _type, _parent);
        else return PdePageMapCreateElement32(obj, _type, _parent);
      }
      [DllImport("pdfix.dll", EntryPoint="PdePageMapAddTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdePageMapAddTags32(IntPtr obj, IntPtr _element, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdfix64.dll", EntryPoint="PdePageMapAddTags", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdePageMapAddTags64(IntPtr obj, IntPtr _element, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte PdePageMapAddTags(IntPtr obj, IntPtr _element, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return PdePageMapAddTags64(obj, _element, _cancel_proc, _cancel_data);
        else return PdePageMapAddTags32(obj, _element, _cancel_proc, _cancel_data);
      }
    }
    public class PdfPageView : PdfixBase
    {
      public PdfPageView(IntPtr obj) : base(obj) { }
      public void Release()
      {
        CheckBaseObj();
        PdfPageViewRelease(m_obj);
      }
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

      [DllImport("pdfix.dll", EntryPoint="PdfPageViewRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewRelease32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageViewRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewRelease64(IntPtr obj);
      internal static void PdfPageViewRelease(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfPageViewRelease64(obj);
        else PdfPageViewRelease32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageViewGetDeviceWidth", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageViewGetDeviceWidth32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageViewGetDeviceWidth", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageViewGetDeviceWidth64(IntPtr obj);
      internal static int PdfPageViewGetDeviceWidth(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageViewGetDeviceWidth64(obj);
        else return PdfPageViewGetDeviceWidth32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageViewGetDeviceHeight", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageViewGetDeviceHeight32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageViewGetDeviceHeight", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfPageViewGetDeviceHeight64(IntPtr obj);
      internal static int PdfPageViewGetDeviceHeight(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfPageViewGetDeviceHeight64(obj);
        else return PdfPageViewGetDeviceHeight32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageViewGetDeviceMatrix", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewGetDeviceMatrix32(IntPtr obj, IntPtr _matrix);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageViewGetDeviceMatrix", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewGetDeviceMatrix64(IntPtr obj, IntPtr _matrix);
      internal static void PdfPageViewGetDeviceMatrix(IntPtr obj, IntPtr _matrix)
      {
        if (Util.Is64BitProcess()) PdfPageViewGetDeviceMatrix64(obj, _matrix);
        else PdfPageViewGetDeviceMatrix32(obj, _matrix);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageViewRectToDevice", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewRectToDevice32(IntPtr obj, IntPtr _rect, IntPtr _dev_rect);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageViewRectToDevice", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewRectToDevice64(IntPtr obj, IntPtr _rect, IntPtr _dev_rect);
      internal static void PdfPageViewRectToDevice(IntPtr obj, IntPtr _rect, IntPtr _dev_rect)
      {
        if (Util.Is64BitProcess()) PdfPageViewRectToDevice64(obj, _rect, _dev_rect);
        else PdfPageViewRectToDevice32(obj, _rect, _dev_rect);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfPageViewPointToDevice", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewPointToDevice32(IntPtr obj, IntPtr _point, IntPtr _dev_point);
      [DllImport("pdfix64.dll", EntryPoint="PdfPageViewPointToDevice", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfPageViewPointToDevice64(IntPtr obj, IntPtr _point, IntPtr _dev_point);
      internal static void PdfPageViewPointToDevice(IntPtr obj, IntPtr _point, IntPtr _dev_point)
      {
        if (Util.Is64BitProcess()) PdfPageViewPointToDevice64(obj, _point, _dev_point);
        else PdfPageViewPointToDevice32(obj, _point, _dev_point);
      }
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

      [DllImport("pdfix.dll", EntryPoint="PdfBookmarkGetTitle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfBookmarkGetTitle32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdfBookmarkGetTitle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfBookmarkGetTitle64(IntPtr obj, string _buffer, int _len);
      internal static int PdfBookmarkGetTitle(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdfBookmarkGetTitle64(obj, _buffer, _len);
        else return PdfBookmarkGetTitle32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBookmarkGetAppearance", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfBookmarkGetAppearance32(IntPtr obj, IntPtr _appearance);
      [DllImport("pdfix64.dll", EntryPoint="PdfBookmarkGetAppearance", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfBookmarkGetAppearance64(IntPtr obj, IntPtr _appearance);
      internal static void PdfBookmarkGetAppearance(IntPtr obj, IntPtr _appearance)
      {
        if (Util.Is64BitProcess()) PdfBookmarkGetAppearance64(obj, _appearance);
        else PdfBookmarkGetAppearance32(obj, _appearance);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBookmarkGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetAction32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfBookmarkGetAction", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetAction64(IntPtr obj);
      internal static IntPtr PdfBookmarkGetAction(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfBookmarkGetAction64(obj);
        else return PdfBookmarkGetAction32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBookmarkGetNumChildren", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfBookmarkGetNumChildren32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfBookmarkGetNumChildren", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfBookmarkGetNumChildren64(IntPtr obj);
      internal static int PdfBookmarkGetNumChildren(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfBookmarkGetNumChildren64(obj);
        else return PdfBookmarkGetNumChildren32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBookmarkGetChild", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetChild32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdfBookmarkGetChild", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetChild64(IntPtr obj, int _index);
      internal static IntPtr PdfBookmarkGetChild(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdfBookmarkGetChild64(obj, _index);
        else return PdfBookmarkGetChild32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfBookmarkGetParent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetParent32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfBookmarkGetParent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfBookmarkGetParent64(IntPtr obj);
      internal static IntPtr PdfBookmarkGetParent(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfBookmarkGetParent64(obj);
        else return PdfBookmarkGetParent32(obj);
      }
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
        byte ret = PsRegexSetPattern(m_obj, _pattern);
        return ret != 0;
      }
      public bool Search(string _text, int _position)
      {
        CheckBaseObj();
        byte ret = PsRegexSearch(m_obj, _text, _position);
        return ret != 0;
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

      [DllImport("pdfix.dll", EntryPoint="PsRegexDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsRegexDestroy32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsRegexDestroy64(IntPtr obj);
      internal static void PsRegexDestroy(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PsRegexDestroy64(obj);
        else PsRegexDestroy32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsRegexSetPattern", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsRegexSetPattern32(IntPtr obj, string _pattern);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexSetPattern", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsRegexSetPattern64(IntPtr obj, string _pattern);
      internal static byte PsRegexSetPattern(IntPtr obj, string _pattern)
      {
        if (Util.Is64BitProcess()) return PsRegexSetPattern64(obj, _pattern);
        else return PsRegexSetPattern32(obj, _pattern);
      }
      [DllImport("pdfix.dll", EntryPoint="PsRegexSearch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsRegexSearch32(IntPtr obj, string _text, int _position);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexSearch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsRegexSearch64(IntPtr obj, string _text, int _position);
      internal static byte PsRegexSearch(IntPtr obj, string _text, int _position)
      {
        if (Util.Is64BitProcess()) return PsRegexSearch64(obj, _text, _position);
        else return PsRegexSearch32(obj, _text, _position);
      }
      [DllImport("pdfix.dll", EntryPoint="PsRegexGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexGetText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetText64(IntPtr obj, string _buffer, int _len);
      internal static int PsRegexGetText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PsRegexGetText64(obj, _buffer, _len);
        else return PsRegexGetText32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PsRegexGetPosition", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetPosition32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexGetPosition", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetPosition64(IntPtr obj);
      internal static int PsRegexGetPosition(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsRegexGetPosition64(obj);
        else return PsRegexGetPosition32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsRegexGetLength", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetLength32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexGetLength", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetLength64(IntPtr obj);
      internal static int PsRegexGetLength(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsRegexGetLength64(obj);
        else return PsRegexGetLength32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsRegexGetNumMatches", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetNumMatches32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexGetNumMatches", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetNumMatches64(IntPtr obj);
      internal static int PsRegexGetNumMatches(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsRegexGetNumMatches64(obj);
        else return PsRegexGetNumMatches32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsRegexGetMatchText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetMatchText32(IntPtr obj, int _index, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PsRegexGetMatchText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsRegexGetMatchText64(IntPtr obj, int _index, string _buffer, int _len);
      internal static int PsRegexGetMatchText(IntPtr obj, int _index, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PsRegexGetMatchText64(obj, _index, _buffer, _len);
        else return PsRegexGetMatchText32(obj, _index, _buffer, _len);
      }
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
        byte ret = PsStreamIsEof(m_obj);
        return ret != 0;
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
        byte ret = PsStreamRead(m_obj, _offset, _buffer_ptr, _buffer.Length);
        if (ret != 0) Marshal.Copy(_buffer_ptr, _buffer, 0, _buffer.Length);
        Marshal.FreeHGlobal(_buffer_ptr);
        _buffer_ptr = IntPtr.Zero;
        return ret != 0;
      }
      public bool Write(int _offset, byte[] _buffer)
      {
        CheckBaseObj();
        IntPtr _buffer_ptr = Marshal.AllocHGlobal(_buffer.Length);
        Marshal.Copy(_buffer, 0, _buffer_ptr, _buffer.Length);
        byte ret = PsStreamWrite(m_obj, _offset, _buffer_ptr, _buffer.Length);
        Marshal.FreeHGlobal(_buffer_ptr);
        _buffer_ptr = IntPtr.Zero;
        return ret != 0;
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
        byte ret = PsStreamFlush(m_obj);
        return ret != 0;
      }
      public PdfStreamType GetType_()
      {
        CheckBaseObj();
        PdfStreamType ret = PsStreamGetType(m_obj);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PsStreamDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsStreamDestroy32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PsStreamDestroy64(IntPtr obj);
      internal static void PsStreamDestroy(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PsStreamDestroy64(obj);
        else PsStreamDestroy32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsStreamIsEof", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamIsEof32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamIsEof", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamIsEof64(IntPtr obj);
      internal static byte PsStreamIsEof(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsStreamIsEof64(obj);
        else return PsStreamIsEof32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsStreamGetSize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsStreamGetSize32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamGetSize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsStreamGetSize64(IntPtr obj);
      internal static int PsStreamGetSize(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsStreamGetSize64(obj);
        else return PsStreamGetSize32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsStreamRead", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamRead32(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamRead", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamRead64(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      internal static byte PsStreamRead(IntPtr obj, int _offset, IntPtr _buffer, int _size)
      {
        if (Util.Is64BitProcess()) return PsStreamRead64(obj, _offset, _buffer, _size);
        else return PsStreamRead32(obj, _offset, _buffer, _size);
      }
      [DllImport("pdfix.dll", EntryPoint="PsStreamWrite", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamWrite32(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamWrite", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamWrite64(IntPtr obj, int _offset, IntPtr _buffer, int _size);
      internal static byte PsStreamWrite(IntPtr obj, int _offset, IntPtr _buffer, int _size)
      {
        if (Util.Is64BitProcess()) return PsStreamWrite64(obj, _offset, _buffer, _size);
        else return PsStreamWrite32(obj, _offset, _buffer, _size);
      }
      [DllImport("pdfix.dll", EntryPoint="PsStreamGetPos", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsStreamGetPos32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamGetPos", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PsStreamGetPos64(IntPtr obj);
      internal static int PsStreamGetPos(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsStreamGetPos64(obj);
        else return PsStreamGetPos32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsStreamFlush", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamFlush32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamFlush", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsStreamFlush64(IntPtr obj);
      internal static byte PsStreamFlush(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsStreamFlush64(obj);
        else return PsStreamFlush32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsStreamGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfStreamType PsStreamGetType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsStreamGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfStreamType PsStreamGetType64(IntPtr obj);
      internal static PdfStreamType PsStreamGetType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsStreamGetType64(obj);
        else return PsStreamGetType32(obj);
      }
    }
    public class PsFileStream : PsStream    {
      public PsFileStream(IntPtr obj) : base(obj) { }

    }
    public class PsMemoryStream : PsStream    {
      public PsMemoryStream(IntPtr obj) : base(obj) { }
      public bool Resize(int _size)
      {
        CheckBaseObj();
        byte ret = PsMemoryStreamResize(m_obj, _size);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PsMemoryStreamResize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsMemoryStreamResize32(IntPtr obj, int _size);
      [DllImport("pdfix64.dll", EntryPoint="PsMemoryStreamResize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsMemoryStreamResize64(IntPtr obj, int _size);
      internal static byte PsMemoryStreamResize(IntPtr obj, int _size)
      {
        if (Util.Is64BitProcess()) return PsMemoryStreamResize64(obj, _size);
        else return PsMemoryStreamResize32(obj, _size);
      }
    }
    public class PsProcStream : PsStream    {
      public PsProcStream(IntPtr obj) : base(obj) { }

    }
    public class PdsStructElement : PdfixBase
    {
      public PdsStructElement(IntPtr obj) : base(obj) { }
      public void Release()
      {
        CheckBaseObj();
        PdsStructElementRelease(m_obj);
      }
      public string GetType_(bool _mapped)
      {
        CheckBaseObj();
        int _buffer_sz = PdsStructElementGetType(m_obj, _mapped, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStructElementGetType(m_obj, _mapped, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetActualText()
      {
        CheckBaseObj();
        int _buffer_sz = PdsStructElementGetActualText(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStructElementGetActualText(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetAlt()
      {
        CheckBaseObj();
        int _buffer_sz = PdsStructElementGetAlt(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStructElementGetAlt(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool SetAlt(string _alt)
      {
        CheckBaseObj();
        byte ret = PdsStructElementSetAlt(m_obj, _alt);
        return ret != 0;
      }
      public string GetAbbreviation()
      {
        CheckBaseObj();
        int _buffer_sz = PdsStructElementGetAbbreviation(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStructElementGetAbbreviation(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public int GetPageNumber()
      {
        CheckBaseObj();
        int ret = PdsStructElementGetPageNumber(m_obj);
        return ret;
      }
      public PdsObject GetAttrObject(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsStructElementGetAttrObject(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public bool AddAttrObj(PdsObject _object)
      {
        CheckBaseObj();
        byte ret = PdsStructElementAddAttrObj(m_obj, _object == null ? IntPtr.Zero : _object.m_obj);
        return ret != 0;
      }
      public void RemoveAttrObj()
      {
        CheckBaseObj();
        PdsStructElementRemoveAttrObj(m_obj);
      }
      public PdsObject GetElementObject()
      {
        CheckBaseObj();
        IntPtr ret = PdsStructElementGetElementObject(m_obj);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public PdsObject GetKidObject(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsStructElementGetKidObject(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public PdfStructElementType GetKidType(int _index)
      {
        CheckBaseObj();
        PdfStructElementType ret = PdsStructElementGetKidType(m_obj, _index);
        return ret;
      }
      public int GetKidPageNumber(int _index)
      {
        CheckBaseObj();
        int ret = PdsStructElementGetKidPageNumber(m_obj, _index);
        return ret;
      }
      public int GetKidMcid(int _index)
      {
        CheckBaseObj();
        int ret = PdsStructElementGetKidMcid(m_obj, _index);
        return ret;
      }
      public int GetNumAttrObjects()
      {
        CheckBaseObj();
        int ret = PdsStructElementGetNumAttrObjects(m_obj);
        return ret;
      }
      public int GetNumKids()
      {
        CheckBaseObj();
        int ret = PdsStructElementGetNumKids(m_obj);
        return ret;
      }
      public PdsObject GetParentObject()
      {
        CheckBaseObj();
        IntPtr ret = PdsStructElementGetParentObject(m_obj);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public string GetTitle()
      {
        CheckBaseObj();
        int _buffer_sz = PdsStructElementGetTitle(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStructElementGetTitle(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public string GetId()
      {
        CheckBaseObj();
        int _buffer_sz = PdsStructElementGetId(m_obj, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsStructElementGetId(m_obj, _buffer_str, _buffer_sz);
        return _buffer_str;
      }
      public bool RemoveKid(int _index)
      {
        CheckBaseObj();
        byte ret = PdsStructElementRemoveKid(m_obj, _index);
        return ret != 0;
      }
      public PdsStructElement CreateStructElement(string _type, PdsStructElement _parent, int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsStructElementCreateStructElement(m_obj, _type, _parent == null ? IntPtr.Zero : _parent.m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdsStructElement(ret);
        }
        return null;
      }
      public bool SetParent(PdsStructElement _parent, int _index)
      {
        CheckBaseObj();
        byte ret = PdsStructElementSetParent(m_obj, _parent == null ? IntPtr.Zero : _parent.m_obj, _index);
        return ret != 0;
      }
      public void AddPageObject(PdsPageObject _object, int _index)
      {
        CheckBaseObj();
        PdsStructElementAddPageObject(m_obj, _object == null ? IntPtr.Zero : _object.m_obj, _index);
      }
      public void AddAnnot(PdfAnnot _annot, int _index)
      {
        CheckBaseObj();
        PdsStructElementAddAnnot(m_obj, _annot == null ? IntPtr.Zero : _annot.m_obj, _index);
      }
      public PdsStructTree GetStructTree()
      {
        CheckBaseObj();
        IntPtr ret = PdsStructElementGetStructTree(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsStructTree(ret);
        }
        return null;
      }
      public bool SetType(string _type)
      {
        CheckBaseObj();
        byte ret = PdsStructElementSetType(m_obj, _type);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsStructElementRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementRelease32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementRelease", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementRelease64(IntPtr obj);
      internal static void PdsStructElementRelease(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdsStructElementRelease64(obj);
        else PdsStructElementRelease32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetType32(IntPtr obj, bool _mapped, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetType64(IntPtr obj, bool _mapped, string _buffer, int _len);
      internal static int PdsStructElementGetType(IntPtr obj, bool _mapped, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetType64(obj, _mapped, _buffer, _len);
        else return PdsStructElementGetType32(obj, _mapped, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetActualText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetActualText32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetActualText", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetActualText64(IntPtr obj, string _buffer, int _len);
      internal static int PdsStructElementGetActualText(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetActualText64(obj, _buffer, _len);
        else return PdsStructElementGetActualText32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetAlt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetAlt32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetAlt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetAlt64(IntPtr obj, string _buffer, int _len);
      internal static int PdsStructElementGetAlt(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetAlt64(obj, _buffer, _len);
        else return PdsStructElementGetAlt32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementSetAlt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementSetAlt32(IntPtr obj, string _alt);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementSetAlt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementSetAlt64(IntPtr obj, string _alt);
      internal static byte PdsStructElementSetAlt(IntPtr obj, string _alt)
      {
        if (Util.Is64BitProcess()) return PdsStructElementSetAlt64(obj, _alt);
        else return PdsStructElementSetAlt32(obj, _alt);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetAbbreviation", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetAbbreviation32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetAbbreviation", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetAbbreviation64(IntPtr obj, string _buffer, int _len);
      internal static int PdsStructElementGetAbbreviation(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetAbbreviation64(obj, _buffer, _len);
        else return PdsStructElementGetAbbreviation32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetPageNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetPageNumber32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetPageNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetPageNumber64(IntPtr obj);
      internal static int PdsStructElementGetPageNumber(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetPageNumber64(obj);
        else return PdsStructElementGetPageNumber32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetAttrObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetAttrObject32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetAttrObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetAttrObject64(IntPtr obj, int _index);
      internal static IntPtr PdsStructElementGetAttrObject(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetAttrObject64(obj, _index);
        else return PdsStructElementGetAttrObject32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementAddAttrObj", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementAddAttrObj32(IntPtr obj, IntPtr _object);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementAddAttrObj", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementAddAttrObj64(IntPtr obj, IntPtr _object);
      internal static byte PdsStructElementAddAttrObj(IntPtr obj, IntPtr _object)
      {
        if (Util.Is64BitProcess()) return PdsStructElementAddAttrObj64(obj, _object);
        else return PdsStructElementAddAttrObj32(obj, _object);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementRemoveAttrObj", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementRemoveAttrObj32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementRemoveAttrObj", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementRemoveAttrObj64(IntPtr obj);
      internal static void PdsStructElementRemoveAttrObj(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdsStructElementRemoveAttrObj64(obj);
        else PdsStructElementRemoveAttrObj32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetElementObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetElementObject32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetElementObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetElementObject64(IntPtr obj);
      internal static IntPtr PdsStructElementGetElementObject(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetElementObject64(obj);
        else return PdsStructElementGetElementObject32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetKidObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetKidObject32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetKidObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetKidObject64(IntPtr obj, int _index);
      internal static IntPtr PdsStructElementGetKidObject(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetKidObject64(obj, _index);
        else return PdsStructElementGetKidObject32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetKidType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfStructElementType PdsStructElementGetKidType32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetKidType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfStructElementType PdsStructElementGetKidType64(IntPtr obj, int _index);
      internal static PdfStructElementType PdsStructElementGetKidType(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetKidType64(obj, _index);
        else return PdsStructElementGetKidType32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetKidPageNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetKidPageNumber32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetKidPageNumber", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetKidPageNumber64(IntPtr obj, int _index);
      internal static int PdsStructElementGetKidPageNumber(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetKidPageNumber64(obj, _index);
        else return PdsStructElementGetKidPageNumber32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetKidMcid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetKidMcid32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetKidMcid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetKidMcid64(IntPtr obj, int _index);
      internal static int PdsStructElementGetKidMcid(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetKidMcid64(obj, _index);
        else return PdsStructElementGetKidMcid32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetNumAttrObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetNumAttrObjects32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetNumAttrObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetNumAttrObjects64(IntPtr obj);
      internal static int PdsStructElementGetNumAttrObjects(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetNumAttrObjects64(obj);
        else return PdsStructElementGetNumAttrObjects32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetNumKids", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetNumKids32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetNumKids", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetNumKids64(IntPtr obj);
      internal static int PdsStructElementGetNumKids(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetNumKids64(obj);
        else return PdsStructElementGetNumKids32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetParentObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetParentObject32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetParentObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetParentObject64(IntPtr obj);
      internal static IntPtr PdsStructElementGetParentObject(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetParentObject64(obj);
        else return PdsStructElementGetParentObject32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetTitle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetTitle32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetTitle", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetTitle64(IntPtr obj, string _buffer, int _len);
      internal static int PdsStructElementGetTitle(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetTitle64(obj, _buffer, _len);
        else return PdsStructElementGetTitle32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetId32(IntPtr obj, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetId", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructElementGetId64(IntPtr obj, string _buffer, int _len);
      internal static int PdsStructElementGetId(IntPtr obj, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetId64(obj, _buffer, _len);
        else return PdsStructElementGetId32(obj, _buffer, _len);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementRemoveKid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementRemoveKid32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementRemoveKid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementRemoveKid64(IntPtr obj, int _index);
      internal static byte PdsStructElementRemoveKid(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementRemoveKid64(obj, _index);
        else return PdsStructElementRemoveKid32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementCreateStructElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementCreateStructElement32(IntPtr obj, string _type, IntPtr _parent, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementCreateStructElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementCreateStructElement64(IntPtr obj, string _type, IntPtr _parent, int _index);
      internal static IntPtr PdsStructElementCreateStructElement(IntPtr obj, string _type, IntPtr _parent, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementCreateStructElement64(obj, _type, _parent, _index);
        else return PdsStructElementCreateStructElement32(obj, _type, _parent, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementSetParent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementSetParent32(IntPtr obj, IntPtr _parent, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementSetParent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementSetParent64(IntPtr obj, IntPtr _parent, int _index);
      internal static byte PdsStructElementSetParent(IntPtr obj, IntPtr _parent, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructElementSetParent64(obj, _parent, _index);
        else return PdsStructElementSetParent32(obj, _parent, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementAddPageObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementAddPageObject32(IntPtr obj, IntPtr _object, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementAddPageObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementAddPageObject64(IntPtr obj, IntPtr _object, int _index);
      internal static void PdsStructElementAddPageObject(IntPtr obj, IntPtr _object, int _index)
      {
        if (Util.Is64BitProcess()) PdsStructElementAddPageObject64(obj, _object, _index);
        else PdsStructElementAddPageObject32(obj, _object, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementAddAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementAddAnnot32(IntPtr obj, IntPtr _annot, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementAddAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdsStructElementAddAnnot64(IntPtr obj, IntPtr _annot, int _index);
      internal static void PdsStructElementAddAnnot(IntPtr obj, IntPtr _annot, int _index)
      {
        if (Util.Is64BitProcess()) PdsStructElementAddAnnot64(obj, _annot, _index);
        else PdsStructElementAddAnnot32(obj, _annot, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementGetStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetStructTree32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementGetStructTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructElementGetStructTree64(IntPtr obj);
      internal static IntPtr PdsStructElementGetStructTree(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructElementGetStructTree64(obj);
        else return PdsStructElementGetStructTree32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructElementSetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementSetType32(IntPtr obj, string _type);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructElementSetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructElementSetType64(IntPtr obj, string _type);
      internal static byte PdsStructElementSetType(IntPtr obj, string _type)
      {
        if (Util.Is64BitProcess()) return PdsStructElementSetType64(obj, _type);
        else return PdsStructElementSetType32(obj, _type);
      }
    }
    public class PdsClassMap : PdfixBase
    {
      public PdsClassMap(IntPtr obj) : base(obj) { }
      public PdsObject GetAttrObject(string _class_name, int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsClassMapGetAttrObject(m_obj, _class_name, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public int GetNumAttrObjects(string _class_name)
      {
        CheckBaseObj();
        int ret = PdsClassMapGetNumAttrObjects(m_obj, _class_name);
        return ret;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsClassMapGetAttrObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsClassMapGetAttrObject32(IntPtr obj, string _class_name, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsClassMapGetAttrObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsClassMapGetAttrObject64(IntPtr obj, string _class_name, int _index);
      internal static IntPtr PdsClassMapGetAttrObject(IntPtr obj, string _class_name, int _index)
      {
        if (Util.Is64BitProcess()) return PdsClassMapGetAttrObject64(obj, _class_name, _index);
        else return PdsClassMapGetAttrObject32(obj, _class_name, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsClassMapGetNumAttrObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsClassMapGetNumAttrObjects32(IntPtr obj, string _class_name);
      [DllImport("pdfix64.dll", EntryPoint="PdsClassMapGetNumAttrObjects", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsClassMapGetNumAttrObjects64(IntPtr obj, string _class_name);
      internal static int PdsClassMapGetNumAttrObjects(IntPtr obj, string _class_name)
      {
        if (Util.Is64BitProcess()) return PdsClassMapGetNumAttrObjects64(obj, _class_name);
        else return PdsClassMapGetNumAttrObjects32(obj, _class_name);
      }
    }
    public class PdsRoleMap : PdfixBase
    {
      public PdsRoleMap(IntPtr obj) : base(obj) { }
      public bool DoesMap(string _src, string _dst)
      {
        CheckBaseObj();
        byte ret = PdsRoleMapDoesMap(m_obj, _src, _dst);
        return ret != 0;
      }
      public string GetDirectMap(string _type)
      {
        CheckBaseObj();
        int _buffer_sz = PdsRoleMapGetDirectMap(m_obj, _type, null, 0);
        string _buffer_str = new string(new char[_buffer_sz]);
        int ret = PdsRoleMapGetDirectMap(m_obj, _type, _buffer_str, _buffer_sz);
        return _buffer_str;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsRoleMapDoesMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsRoleMapDoesMap32(IntPtr obj, string _src, string _dst);
      [DllImport("pdfix64.dll", EntryPoint="PdsRoleMapDoesMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsRoleMapDoesMap64(IntPtr obj, string _src, string _dst);
      internal static byte PdsRoleMapDoesMap(IntPtr obj, string _src, string _dst)
      {
        if (Util.Is64BitProcess()) return PdsRoleMapDoesMap64(obj, _src, _dst);
        else return PdsRoleMapDoesMap32(obj, _src, _dst);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsRoleMapGetDirectMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsRoleMapGetDirectMap32(IntPtr obj, string _type, string _buffer, int _len);
      [DllImport("pdfix64.dll", EntryPoint="PdsRoleMapGetDirectMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsRoleMapGetDirectMap64(IntPtr obj, string _type, string _buffer, int _len);
      internal static int PdsRoleMapGetDirectMap(IntPtr obj, string _type, string _buffer, int _len)
      {
        if (Util.Is64BitProcess()) return PdsRoleMapGetDirectMap64(obj, _type, _buffer, _len);
        else return PdsRoleMapGetDirectMap32(obj, _type, _buffer, _len);
      }
    }
    public class PdsStructTree : PdfixBase
    {
      public PdsStructTree(IntPtr obj) : base(obj) { }
      public PdsDictionary GetObject()
      {
        CheckBaseObj();
        IntPtr ret = PdsStructTreeGetObject(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsDictionary(ret);
        }
        return null;
      }
      public PdsClassMap GetClassMap()
      {
        CheckBaseObj();
        IntPtr ret = PdsStructTreeGetClassMap(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsClassMap(ret);
        }
        return null;
      }
      public PdsObject GetKidObject(int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsStructTreeGetKidObject(m_obj, _index);
        if (ret != IntPtr.Zero)
        {
          switch (PdsObject.PdsObjectGetObjectType(ret))
          {
            case PdfObjectType.kPdsBoolean: return new PdsBoolean(ret);
            case PdfObjectType.kPdsNumber: return new PdsNumber(ret);
            case PdfObjectType.kPdsString: return new PdsString(ret);
            case PdfObjectType.kPdsName: return new PdsName(ret);
            case PdfObjectType.kPdsArray: return new PdsArray(ret);
            case PdfObjectType.kPdsDictionary: return new PdsDictionary(ret);
            case PdfObjectType.kPdsStream: return new PdsStream(ret);
            default: return new PdsObject(ret);
          }
        }
        return null;
      }
      public int GetNumKids()
      {
        CheckBaseObj();
        int ret = PdsStructTreeGetNumKids(m_obj);
        return ret;
      }
      public PdsRoleMap GetRoleMap()
      {
        CheckBaseObj();
        IntPtr ret = PdsStructTreeGetRoleMap(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsRoleMap(ret);
        }
        return null;
      }
      public PdsStructElement AcquireStructElement(PdsObject _object)
      {
        CheckBaseObj();
        IntPtr ret = PdsStructTreeAcquireStructElement(m_obj, _object == null ? IntPtr.Zero : _object.m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdsStructElement(ret);
        }
        return null;
      }
      public bool RemoveKid(int _index)
      {
        CheckBaseObj();
        byte ret = PdsStructTreeRemoveKid(m_obj, _index);
        return ret != 0;
      }
      public PdsStructElement CreateStructElement(string _type, int _index)
      {
        CheckBaseObj();
        IntPtr ret = PdsStructTreeCreateStructElement(m_obj, _type, _index);
        if (ret != IntPtr.Zero)
        {
          return new PdsStructElement(ret);
        }
        return null;
      }
      public PdfDoc GetDoc()
      {
        CheckBaseObj();
        IntPtr ret = PdsStructTreeGetDoc(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfDoc(ret);
        }
        return null;
      }
      public bool UpdateParentTree()
      {
        CheckBaseObj();
        byte ret = PdsStructTreeUpdateParentTree(m_obj);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeGetObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetObject32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeGetObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetObject64(IntPtr obj);
      internal static IntPtr PdsStructTreeGetObject(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeGetObject64(obj);
        else return PdsStructTreeGetObject32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeGetClassMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetClassMap32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeGetClassMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetClassMap64(IntPtr obj);
      internal static IntPtr PdsStructTreeGetClassMap(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeGetClassMap64(obj);
        else return PdsStructTreeGetClassMap32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeGetKidObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetKidObject32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeGetKidObject", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetKidObject64(IntPtr obj, int _index);
      internal static IntPtr PdsStructTreeGetKidObject(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeGetKidObject64(obj, _index);
        else return PdsStructTreeGetKidObject32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeGetNumKids", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructTreeGetNumKids32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeGetNumKids", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdsStructTreeGetNumKids64(IntPtr obj);
      internal static int PdsStructTreeGetNumKids(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeGetNumKids64(obj);
        else return PdsStructTreeGetNumKids32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeGetRoleMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetRoleMap32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeGetRoleMap", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetRoleMap64(IntPtr obj);
      internal static IntPtr PdsStructTreeGetRoleMap(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeGetRoleMap64(obj);
        else return PdsStructTreeGetRoleMap32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeAcquireStructElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeAcquireStructElement32(IntPtr obj, IntPtr _object);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeAcquireStructElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeAcquireStructElement64(IntPtr obj, IntPtr _object);
      internal static IntPtr PdsStructTreeAcquireStructElement(IntPtr obj, IntPtr _object)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeAcquireStructElement64(obj, _object);
        else return PdsStructTreeAcquireStructElement32(obj, _object);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeRemoveKid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructTreeRemoveKid32(IntPtr obj, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeRemoveKid", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructTreeRemoveKid64(IntPtr obj, int _index);
      internal static byte PdsStructTreeRemoveKid(IntPtr obj, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeRemoveKid64(obj, _index);
        else return PdsStructTreeRemoveKid32(obj, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeCreateStructElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeCreateStructElement32(IntPtr obj, string _type, int _index);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeCreateStructElement", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeCreateStructElement64(IntPtr obj, string _type, int _index);
      internal static IntPtr PdsStructTreeCreateStructElement(IntPtr obj, string _type, int _index)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeCreateStructElement64(obj, _type, _index);
        else return PdsStructTreeCreateStructElement32(obj, _type, _index);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeGetDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetDoc32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeGetDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdsStructTreeGetDoc64(IntPtr obj);
      internal static IntPtr PdsStructTreeGetDoc(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeGetDoc64(obj);
        else return PdsStructTreeGetDoc32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdsStructTreeUpdateParentTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructTreeUpdateParentTree32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdsStructTreeUpdateParentTree", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdsStructTreeUpdateParentTree64(IntPtr obj);
      internal static byte PdsStructTreeUpdateParentTree(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdsStructTreeUpdateParentTree64(obj);
        else return PdsStructTreeUpdateParentTree32(obj);
      }
    }
    public class PsMetadata : PdfixBase
    {
      public PsMetadata(IntPtr obj) : base(obj) { }
      public bool SaveToStream(PsStream _stream)
      {
        CheckBaseObj();
        byte ret = PsMetadataSaveToStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj);
        return ret != 0;
      }
      public bool LoadFromStream(PsStream _stream)
      {
        CheckBaseObj();
        byte ret = PsMetadataLoadFromStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj);
        return ret != 0;
      }

      [DllImport("pdfix.dll", EntryPoint="PsMetadataSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsMetadataSaveToStream32(IntPtr obj, IntPtr _stream);
      [DllImport("pdfix64.dll", EntryPoint="PsMetadataSaveToStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsMetadataSaveToStream64(IntPtr obj, IntPtr _stream);
      internal static byte PsMetadataSaveToStream(IntPtr obj, IntPtr _stream)
      {
        if (Util.Is64BitProcess()) return PsMetadataSaveToStream64(obj, _stream);
        else return PsMetadataSaveToStream32(obj, _stream);
      }
      [DllImport("pdfix.dll", EntryPoint="PsMetadataLoadFromStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsMetadataLoadFromStream32(IntPtr obj, IntPtr _stream);
      [DllImport("pdfix64.dll", EntryPoint="PsMetadataLoadFromStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PsMetadataLoadFromStream64(IntPtr obj, IntPtr _stream);
      internal static byte PsMetadataLoadFromStream(IntPtr obj, IntPtr _stream)
      {
        if (Util.Is64BitProcess()) return PsMetadataLoadFromStream64(obj, _stream);
        else return PsMetadataLoadFromStream32(obj, _stream);
      }
    }
    public class PsEvent : PdfixBase
    {
      public PsEvent(IntPtr obj) : base(obj) { }
      public PdfEventType GetType_()
      {
        CheckBaseObj();
        PdfEventType ret = PsEventGetType(m_obj);
        return ret;
      }
      public PdfDoc GetDoc()
      {
        CheckBaseObj();
        IntPtr ret = PsEventGetDoc(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfDoc(ret);
        }
        return null;
      }
      public PdfPage GetPage()
      {
        CheckBaseObj();
        IntPtr ret = PsEventGetPage(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfPage(ret);
        }
        return null;
      }
      public PdfAnnot GetAnnot()
      {
        CheckBaseObj();
        IntPtr ret = PsEventGetAnnot(m_obj);
        if (ret != IntPtr.Zero)
        {
          switch (PdfAnnot.PdfAnnotGetSubtype(ret))
          {
            case PdfAnnotSubtype.kAnnotText: return new PdfTextAnnot(ret);
            case PdfAnnotSubtype.kAnnotLink: return new PdfLinkAnnot(ret);
            case PdfAnnotSubtype.kAnnotFreeText: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquare: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCircle: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolygon: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPolyLine: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotHighlight: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotUnderline: return new PdfTextMarkupAnnot(ret);
            case PdfAnnotSubtype.kAnnotSquiggly: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStrikeOut: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotStamp: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotCaret: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotInk: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPopup: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotFileAttachment: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotSound: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotMovie: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWidget: return new PdfWidgetAnnot(ret);
            case PdfAnnotSubtype.kAnnotScreen: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotPrinterMark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotTrapNet: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotWatermark: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnot3D: return new PdfAnnot(ret);
            case PdfAnnotSubtype.kAnnotRedact: return new PdfAnnot(ret);
            default: return new PdfAnnot(ret);
          }
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PsEventGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfEventType PsEventGetType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsEventGetType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern PdfEventType PsEventGetType64(IntPtr obj);
      internal static PdfEventType PsEventGetType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsEventGetType64(obj);
        else return PsEventGetType32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsEventGetDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PsEventGetDoc32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsEventGetDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PsEventGetDoc64(IntPtr obj);
      internal static IntPtr PsEventGetDoc(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsEventGetDoc64(obj);
        else return PsEventGetDoc32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsEventGetPage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PsEventGetPage32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsEventGetPage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PsEventGetPage64(IntPtr obj);
      internal static IntPtr PsEventGetPage(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsEventGetPage64(obj);
        else return PsEventGetPage32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PsEventGetAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PsEventGetAnnot32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PsEventGetAnnot", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PsEventGetAnnot64(IntPtr obj);
      internal static IntPtr PsEventGetAnnot(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PsEventGetAnnot64(obj);
        else return PsEventGetAnnot32(obj);
      }
    }
    public class Pdfix : PdfixBase
    {
      public const int kNoError = 0;
      public const int kErrorUnknown = 1;
      public const int kErrorOutOfMemory = 2;
      public const int kErrorMalformedInput = 3;
      public const int kErrorMethodNotImplemented = 4;
      public const int kErrorPathNotFound = 5;
      public const int kErrorOperationCancelled = 6;
      public const int kErrorParsingDataFile = 7;
      public const int kErrorInit = 8;
      public const int kErrorIndexOutOfRange = 9;
      public const int kErrorIncompatiblePluginVersion = 10;
      public const int kErrorPdfDocInvalid = 30;
      public const int kErrorPdfDocOpen = 31;
      public const int kErrorPdfDocCreate = 32;
      public const int kErrorPdfDocSave = 33;
      public const int kErrorPdfDocXFA = 34;
      public const int kErrorPdfDocClose = 35;
      public const int kErrorDocTemplateInvalid = 60;
      public const int kErrorDocTemplateInvalidValue = 61;
      public const int kErrorPdfDigSigOpenPfxFile = 90;
      public const int kErrorPdfDigSigSaveFile = 91;
      public const int kErrorPdfDigSigReadFile = 92;
      public const int kErrorPdfDigSigCertOpenSystemStore = 93;
      public const int kErrorPdfDigSigPFXImportCertStore = 94;
      public const int kErrorPdfDigSigCertFindInStore = 95;
      public const int kErrorPdfDigSigPFXImportOpenSSL = 96;
      public const int kErrorPdfDigSigPFXParseOpenSSL = 97;
      public const int kErrorPdfDigSigByteRange = 98;
      public const int kErrorPdfDigSigCryptMemAlloc = 99;
      public const int kErrorPdfDigSigCryptSignMessage = 100;
      public const int kErrorPdfDigSigTimeStampMessage = 101;
      public const int kErrorPdfDigSigTimeStampRequest = 102;
      public const int kErrorPdfDigSigCryptHash = 103;
      public const int kErrorPdfDigSigVerifyDetachedMessage = 104;
      public const int kErrorPdfDigSigUnknownType = 105;
      public const int kErrorPdfDigSigCallback = 106;
      public const int kErrorPdsObjectInvalid = 120;
      public const int kErrorPdfPageInvalidObj = 150;
      public const int kErrorPdfPageInvalidColorSpace = 151;
      public const int kErrorPdfPageMapAddElement = 180;
      public const int kErrorPdfPageMapInvalidTextObj = 181;
      public const int kErrorPdfPageMapAddTags = 182;
      public const int kErrorPdfPageMapTagAttributes = 183;
      public const int kErrorPdfPageMapTagParentTree = 184;
      public const int kErrorPdeElementMalformed = 210;
      public const int kErrorPdeTextRunMalformed = 211;
      public const int kErrorPdeWordMalformed = 212;
      public const int kErrorPdeLineMalformed = 213;
      public const int kErrorPdeListMalformed = 214;
      public const int kErrorPdeTextMalformed = 215;
      public const int kErrorPdeTextSelectRange = 216;
      public const int kErrorPdeTableMalformed = 217;
      public const int kErrorPdeElementCreate = 218;
      public const int kErrorPdfFontSubstFontMissing = 240;
      public const int kErrorPdfFontNotEmbedded = 241;
      public const int kErrorPdfFontSave = 242;
      public const int kErrorPsImageOpenFile = 270;
      public const int kErrorPsImageUnsupportedFormat = 271;
      public const int kErrorPsImageWriteBMP = 272;
      public const int kErrorPsImageWritePNG = 273;
      public const int kErrorPsImageWriteJPG = 274;
      public const int kErrorPsImageInvalidBitmap = 275;
      public const int kErrorPsImageFormat = 276;
      public const int kErrorPdfAnnotMalformed = 300;
      public const int kErrorPdfAnnotInvalidType = 301;
      public const int kErrorPsRegexDestroy = 330;
      public const int kErrorPsRegexSearchFail = 331;
      public const int kErrorPsEventMalformed = 360;
      public const int kErrorPsEventExists = 361;
      public const int kErrorPsNoEvent = 362;
      public const int kErrorPdfBookmarkMalformed = 390;
      public const int kErrorPdfBookmarkRoot = 391;
      public const int kErrorPsAuthorizationFailed = 420;
      public const int kErrorPsAuthorizationNeeded = 421;
      public const int kErrorPsAuthorizationEmail = 422;
      public const int kErrorPsAuthorizationPlatform = 423;
      public const int kErrorPsAuthorizationDate = 424;
      public const int kErrorPsAuthorizationVersion = 425;
      public const int kErrorPsAuthorizationNumber = 426;
      public const int kErrorPsAuthorizationOsCheck = 427;
      public const int kErrorPsStreamReadProcMissing = 450;
      public const int kErrorPsStreamWriteProcMissing = 451;
      public const int kErrorPsStreamGetSizeProcMissing = 452;
      public const int kErrorPdfAlternateNotFound = 480;
      public const int kErrorPdfAlternateInvalid = 481;
      public const int kErrorPdfAlternateResourceNotFound = 482;
      public const int kErrorPdsStructTreeInvalid = 510;
      public const int kErrorPdsStructElementNotFound = 511;
      public const int kErrorPdsStructTreeMissing = 512;
      public const int kErrorPdfActionInvalid = 540;
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
      public const int kTextFlagWhiteSpace = 0x100;
      public const int kTextFlagUnicode = 0x200;
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
      public const int kContentImage = 0x00001;
      public const int kContentText = 0x00002;
      public const int kContentPath = 0x00004;
      public const int kContentForm = 0x00008;
      public const int kContentShading = 0x00020;
      public const int kContentTextTransparent = 0x00040;
      public const int kContentTextFill = 0x00080;
      public const int kContentTextStroke = 0x00100;
      public const int kTableUnknown = 0x00;
      public const int kTableGraphic = 0x01;
      public const int kTableIsolated = 0x02;
      public const int kTableIsolatedCol = 0x04;
      public const int kTableIsolatedRow = 0x08;
      public const int kTableForm = 0x10;
      public const int kTableElement = 0x20;
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
      public const int kTextFlagTableCaption = 0x0001;
      public const int kTextFlagImageCaption = 0x0002;
      public const int kTextFlagChartCaption = 0x0004;
      public const int kTextFlagFilling = 0x008;
      public const int kTextFlagLabel = 0x0010;
      public const int kElemNoJoin = 0x01;
      public const int kElemNoSplit = 0x02;
      public const int kElemArtifact = 0x04;

      public Pdfix() : base(IntPtr.Zero)
      {
        m_obj = GetPdfix();
      }
      [DllImport("pdfix.dll", EntryPoint="GetPdfix", CharSet = CharSet.Unicode)]
      internal static extern IntPtr GetPdfix32();
      [DllImport("pdfix64.dll", EntryPoint="GetPdfix", CharSet = CharSet.Unicode)]
      internal static extern IntPtr GetPdfix64();
      internal static IntPtr GetPdfix()
      {
        if (Util.Is64BitProcess()) return GetPdfix64();
        else return GetPdfix32();
      }
      public Pdfix(IntPtr obj) : base(obj) { }
      public void Destroy()
      {
        CheckBaseObj();
        PdfixDestroy(m_obj);
      }
      public bool Authorize(string _email, string _serial_number)
      {
        CheckBaseObj();
        byte ret = PdfixAuthorize(m_obj, _email, _serial_number);
        return ret != 0;
      }
      public bool IsAuthorized()
      {
        CheckBaseObj();
        byte ret = PdfixIsAuthorized(m_obj);
        return ret != 0;
      }
      public bool IsAuthorizedPlatform(PdfAuthPlatform _platform)
      {
        CheckBaseObj();
        byte ret = PdfixIsAuthorizedPlatform(m_obj, (int)_platform);
        return ret != 0;
      }
      public bool IsAuthorizedOption(PdfAuthOption _option)
      {
        CheckBaseObj();
        byte ret = PdfixIsAuthorizedOption(m_obj, (int)_option);
        return ret != 0;
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
        IntPtr ret = PdfixOpenDocFromStream(m_obj, _stream == null ? IntPtr.Zero : _stream.m_obj, _password);
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
        byte ret = PdfixRegisterEvent(m_obj, (int)_type, _proc, _data);
        return ret != 0;
      }
      public bool UnregisterEvent(PdfEventType _type, PdfEventProc _proc, IntPtr _data)
      {
        CheckBaseObj();
        byte ret = PdfixUnregisterEvent(m_obj, (int)_type, _proc, _data);
        return ret != 0;
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
      public void RegisterPlugin(PdfixPlugin _plugin, string _name)
      {
        CheckBaseObj();
        PdfixRegisterPlugin(m_obj, _plugin == null ? IntPtr.Zero : _plugin.m_obj, _name);
      }
      public PdfixPlugin GetPluginByName(string _name)
      {
        CheckBaseObj();
        IntPtr ret = PdfixGetPluginByName(m_obj, _name);
        if (ret != IntPtr.Zero)
        {
          return new PdfixPlugin(ret);
        }
        return null;
      }
      public PsEvent GetEvent()
      {
        CheckBaseObj();
        IntPtr ret = PdfixGetEvent(m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PsEvent(ret);
        }
        return null;
      }

      [DllImport("pdfix.dll", EntryPoint="PdfixDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixDestroy32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixDestroy64(IntPtr obj);
      internal static void PdfixDestroy(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfixDestroy64(obj);
        else PdfixDestroy32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixAuthorize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixAuthorize32(IntPtr obj, string _email, string _serial_number);
      [DllImport("pdfix64.dll", EntryPoint="PdfixAuthorize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixAuthorize64(IntPtr obj, string _email, string _serial_number);
      internal static byte PdfixAuthorize(IntPtr obj, string _email, string _serial_number)
      {
        if (Util.Is64BitProcess()) return PdfixAuthorize64(obj, _email, _serial_number);
        else return PdfixAuthorize32(obj, _email, _serial_number);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixIsAuthorized", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixIsAuthorized32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixIsAuthorized", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixIsAuthorized64(IntPtr obj);
      internal static byte PdfixIsAuthorized(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixIsAuthorized64(obj);
        else return PdfixIsAuthorized32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixIsAuthorizedPlatform", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixIsAuthorizedPlatform32(IntPtr obj, int _platform);
      [DllImport("pdfix64.dll", EntryPoint="PdfixIsAuthorizedPlatform", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixIsAuthorizedPlatform64(IntPtr obj, int _platform);
      internal static byte PdfixIsAuthorizedPlatform(IntPtr obj, int _platform)
      {
        if (Util.Is64BitProcess()) return PdfixIsAuthorizedPlatform64(obj, _platform);
        else return PdfixIsAuthorizedPlatform32(obj, _platform);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixIsAuthorizedOption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixIsAuthorizedOption32(IntPtr obj, int _option);
      [DllImport("pdfix64.dll", EntryPoint="PdfixIsAuthorizedOption", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixIsAuthorizedOption64(IntPtr obj, int _option);
      internal static byte PdfixIsAuthorizedOption(IntPtr obj, int _option)
      {
        if (Util.Is64BitProcess()) return PdfixIsAuthorizedOption64(obj, _option);
        else return PdfixIsAuthorizedOption32(obj, _option);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixGetErrorType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetErrorType32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixGetErrorType", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetErrorType64(IntPtr obj);
      internal static int PdfixGetErrorType(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixGetErrorType64(obj);
        else return PdfixGetErrorType32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixGetError", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern string PdfixGetError32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixGetError", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern string PdfixGetError64(IntPtr obj);
      internal static string PdfixGetError(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixGetError64(obj);
        else return PdfixGetError32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixSetError", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixSetError32(IntPtr obj, int _type, string _error);
      [DllImport("pdfix64.dll", EntryPoint="PdfixSetError", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixSetError64(IntPtr obj, int _type, string _error);
      internal static void PdfixSetError(IntPtr obj, int _type, string _error)
      {
        if (Util.Is64BitProcess()) PdfixSetError64(obj, _type, _error);
        else PdfixSetError32(obj, _type, _error);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixGetVersionMajor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionMajor32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixGetVersionMajor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionMajor64(IntPtr obj);
      internal static int PdfixGetVersionMajor(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixGetVersionMajor64(obj);
        else return PdfixGetVersionMajor32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixGetVersionMinor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionMinor32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixGetVersionMinor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionMinor64(IntPtr obj);
      internal static int PdfixGetVersionMinor(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixGetVersionMinor64(obj);
        else return PdfixGetVersionMinor32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixGetVersionPatch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionPatch32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixGetVersionPatch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixGetVersionPatch64(IntPtr obj);
      internal static int PdfixGetVersionPatch(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixGetVersionPatch64(obj);
        else return PdfixGetVersionPatch32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixOpenDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixOpenDoc32(IntPtr obj, string _path, string _password);
      [DllImport("pdfix64.dll", EntryPoint="PdfixOpenDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixOpenDoc64(IntPtr obj, string _path, string _password);
      internal static IntPtr PdfixOpenDoc(IntPtr obj, string _path, string _password)
      {
        if (Util.Is64BitProcess()) return PdfixOpenDoc64(obj, _path, _password);
        else return PdfixOpenDoc32(obj, _path, _password);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixOpenDocFromStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixOpenDocFromStream32(IntPtr obj, IntPtr _stream, string _password);
      [DllImport("pdfix64.dll", EntryPoint="PdfixOpenDocFromStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixOpenDocFromStream64(IntPtr obj, IntPtr _stream, string _password);
      internal static IntPtr PdfixOpenDocFromStream(IntPtr obj, IntPtr _stream, string _password)
      {
        if (Util.Is64BitProcess()) return PdfixOpenDocFromStream64(obj, _stream, _password);
        else return PdfixOpenDocFromStream32(obj, _stream, _password);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixCreateDigSig", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateDigSig32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixCreateDigSig", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateDigSig64(IntPtr obj);
      internal static IntPtr PdfixCreateDigSig(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixCreateDigSig64(obj);
        else return PdfixCreateDigSig32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixCreateCertDigSig", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateCertDigSig32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixCreateCertDigSig", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateCertDigSig64(IntPtr obj);
      internal static IntPtr PdfixCreateCertDigSig(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixCreateCertDigSig64(obj);
        else return PdfixCreateCertDigSig32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixCreateRegex", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateRegex32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixCreateRegex", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateRegex64(IntPtr obj);
      internal static IntPtr PdfixCreateRegex(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixCreateRegex64(obj);
        else return PdfixCreateRegex32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixCreateFileStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateFileStream32(IntPtr obj, string _path, int _mode);
      [DllImport("pdfix64.dll", EntryPoint="PdfixCreateFileStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateFileStream64(IntPtr obj, string _path, int _mode);
      internal static IntPtr PdfixCreateFileStream(IntPtr obj, string _path, int _mode)
      {
        if (Util.Is64BitProcess()) return PdfixCreateFileStream64(obj, _path, _mode);
        else return PdfixCreateFileStream32(obj, _path, _mode);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixCreateMemStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateMemStream32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixCreateMemStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateMemStream64(IntPtr obj);
      internal static IntPtr PdfixCreateMemStream(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixCreateMemStream64(obj);
        else return PdfixCreateMemStream32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixCreateCustomStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateCustomStream32(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PsStreamProc _read_proc, IntPtr _client_data);
      [DllImport("pdfix64.dll", EntryPoint="PdfixCreateCustomStream", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateCustomStream64(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PsStreamProc _read_proc, IntPtr _client_data);
      internal static IntPtr PdfixCreateCustomStream(IntPtr obj, [MarshalAs(UnmanagedType.FunctionPtr)]PsStreamProc _read_proc, IntPtr _client_data)
      {
        if (Util.Is64BitProcess()) return PdfixCreateCustomStream64(obj, _read_proc, _client_data);
        else return PdfixCreateCustomStream32(obj, _read_proc, _client_data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixRegisterEvent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixRegisterEvent32(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data);
      [DllImport("pdfix64.dll", EntryPoint="PdfixRegisterEvent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixRegisterEvent64(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data);
      internal static byte PdfixRegisterEvent(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data)
      {
        if (Util.Is64BitProcess()) return PdfixRegisterEvent64(obj, _type, _proc, _data);
        else return PdfixRegisterEvent32(obj, _type, _proc, _data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixUnregisterEvent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixUnregisterEvent32(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data);
      [DllImport("pdfix64.dll", EntryPoint="PdfixUnregisterEvent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixUnregisterEvent64(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data);
      internal static byte PdfixUnregisterEvent(IntPtr obj, int _type, [MarshalAs(UnmanagedType.FunctionPtr)]PdfEventProc _proc, IntPtr _data)
      {
        if (Util.Is64BitProcess()) return PdfixUnregisterEvent64(obj, _type, _proc, _data);
        else return PdfixUnregisterEvent32(obj, _type, _proc, _data);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixCreateImage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateImage32(IntPtr obj, int _width, int _height, int _format);
      [DllImport("pdfix64.dll", EntryPoint="PdfixCreateImage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixCreateImage64(IntPtr obj, int _width, int _height, int _format);
      internal static IntPtr PdfixCreateImage(IntPtr obj, int _width, int _height, int _format)
      {
        if (Util.Is64BitProcess()) return PdfixCreateImage64(obj, _width, _height, _format);
        else return PdfixCreateImage32(obj, _width, _height, _format);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixRegisterPlugin", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixRegisterPlugin32(IntPtr obj, IntPtr _plugin, string _name);
      [DllImport("pdfix64.dll", EntryPoint="PdfixRegisterPlugin", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixRegisterPlugin64(IntPtr obj, IntPtr _plugin, string _name);
      internal static void PdfixRegisterPlugin(IntPtr obj, IntPtr _plugin, string _name)
      {
        if (Util.Is64BitProcess()) PdfixRegisterPlugin64(obj, _plugin, _name);
        else PdfixRegisterPlugin32(obj, _plugin, _name);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixGetPluginByName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixGetPluginByName32(IntPtr obj, string _name);
      [DllImport("pdfix64.dll", EntryPoint="PdfixGetPluginByName", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixGetPluginByName64(IntPtr obj, string _name);
      internal static IntPtr PdfixGetPluginByName(IntPtr obj, string _name)
      {
        if (Util.Is64BitProcess()) return PdfixGetPluginByName64(obj, _name);
        else return PdfixGetPluginByName32(obj, _name);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixGetEvent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixGetEvent32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixGetEvent", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixGetEvent64(IntPtr obj);
      internal static IntPtr PdfixGetEvent(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixGetEvent64(obj);
        else return PdfixGetEvent32(obj);
      }
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
        byte ret = PdfixPluginInitialize(m_obj, _pdfix == null ? IntPtr.Zero : _pdfix.m_obj);
        return ret != 0;
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
      public int GetPdfixVersionMajor()
      {
        CheckBaseObj();
        int ret = PdfixPluginGetPdfixVersionMajor(m_obj);
        return ret;
      }
      public int GetPdfixVersionMinor()
      {
        CheckBaseObj();
        int ret = PdfixPluginGetPdfixVersionMinor(m_obj);
        return ret;
      }
      public int GetPdfixVersionPatch()
      {
        CheckBaseObj();
        int ret = PdfixPluginGetPdfixVersionPatch(m_obj);
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

      [DllImport("pdfix.dll", EntryPoint="PdfixPluginDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixPluginDestroy32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginDestroy", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern void PdfixPluginDestroy64(IntPtr obj);
      internal static void PdfixPluginDestroy(IntPtr obj)
      {
        if (Util.Is64BitProcess()) PdfixPluginDestroy64(obj);
        else PdfixPluginDestroy32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginInitialize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixPluginInitialize32(IntPtr obj, IntPtr _pdfix);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginInitialize", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte PdfixPluginInitialize64(IntPtr obj, IntPtr _pdfix);
      internal static byte PdfixPluginInitialize(IntPtr obj, IntPtr _pdfix)
      {
        if (Util.Is64BitProcess()) return PdfixPluginInitialize64(obj, _pdfix);
        else return PdfixPluginInitialize32(obj, _pdfix);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginGetVersionMajor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionMajor32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginGetVersionMajor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionMajor64(IntPtr obj);
      internal static int PdfixPluginGetVersionMajor(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixPluginGetVersionMajor64(obj);
        else return PdfixPluginGetVersionMajor32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginGetVersionMinor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionMinor32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginGetVersionMinor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionMinor64(IntPtr obj);
      internal static int PdfixPluginGetVersionMinor(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixPluginGetVersionMinor64(obj);
        else return PdfixPluginGetVersionMinor32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginGetVersionPatch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionPatch32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginGetVersionPatch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetVersionPatch64(IntPtr obj);
      internal static int PdfixPluginGetVersionPatch(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixPluginGetVersionPatch64(obj);
        else return PdfixPluginGetVersionPatch32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginGetPdfixVersionMajor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetPdfixVersionMajor32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginGetPdfixVersionMajor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetPdfixVersionMajor64(IntPtr obj);
      internal static int PdfixPluginGetPdfixVersionMajor(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixPluginGetPdfixVersionMajor64(obj);
        else return PdfixPluginGetPdfixVersionMajor32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginGetPdfixVersionMinor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetPdfixVersionMinor32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginGetPdfixVersionMinor", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetPdfixVersionMinor64(IntPtr obj);
      internal static int PdfixPluginGetPdfixVersionMinor(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixPluginGetPdfixVersionMinor64(obj);
        else return PdfixPluginGetPdfixVersionMinor32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginGetPdfixVersionPatch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetPdfixVersionPatch32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginGetPdfixVersionPatch", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int PdfixPluginGetPdfixVersionPatch64(IntPtr obj);
      internal static int PdfixPluginGetPdfixVersionPatch(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixPluginGetPdfixVersionPatch64(obj);
        else return PdfixPluginGetPdfixVersionPatch32(obj);
      }
      [DllImport("pdfix.dll", EntryPoint="PdfixPluginGetPdfix", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixPluginGetPdfix32(IntPtr obj);
      [DllImport("pdfix64.dll", EntryPoint="PdfixPluginGetPdfix", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfixPluginGetPdfix64(IntPtr obj);
      internal static IntPtr PdfixPluginGetPdfix(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return PdfixPluginGetPdfix64(obj);
        else return PdfixPluginGetPdfix32(obj);
      }
    }
  }
}
