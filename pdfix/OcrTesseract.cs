////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2016 PDFix. All Rights Reserved.
// This file was generated automatically
////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Runtime.InteropServices;
using PDFixSDK.Pdfix;

namespace PDFixSDK {
  namespace OcrTesseract {
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
    public class OcrTesseractBase
    {
      public IntPtr m_obj = IntPtr.Zero;
      public OcrTesseractBase(IntPtr obj)
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

    public enum OcrTesseractPageSegType
    {
      kOcrSegOSDOnly = 0,
      kOcrSegAutoOSD = 1,
      kOcrSegAutoOnly = 2,
      kOcrSegAuto = 3,
      kOcrSegSingleColumn = 4,
      kOcrSegSingleBlockVertText = 5,
      kOcrSegSingleBlock = 6,
      kOcrSegSingleLine = 7,
      kOcrSegSingleWord = 8,
      kOcrSegCircleWord = 9,
      kOcrSegSingleChar = 10,
      kOcrSegSparseText = 11,
      kOcrSegSparseTextOSD = 12,
      kOcrSegRawLine = 13,
    }
    public enum OcrTesseractEngineType
    {
      kOcrTesseractOnly = 0,
      kOcrTesseractLSTMOnlly = 1,
      kOcrTesseractLSTMCombined = 2,
      kOcrTesseractDefault = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct OcrTesseractParamsInt
    {
      public int flags;
      public PdfDevRectInt clip_rect;
      public int page_seg;
      public int engine;
      public double zoom;
      public int rotate;
    }
    public struct OcrTesseractParams
    {
      public int flags;
      public PdfDevRect clip_rect;
      public OcrTesseractPageSegType page_seg;
      public OcrTesseractEngineType engine;
      public double zoom;
      public PdfRotate rotate;
      public OcrTesseractParams(int _flags, PdfDevRect _clip_rect, OcrTesseractPageSegType _page_seg, OcrTesseractEngineType _engine, double _zoom, PdfRotate _rotate)
      {
        flags = _flags;
        clip_rect = _clip_rect;
        page_seg = _page_seg;
        engine = _engine;
        zoom = _zoom;
        rotate = _rotate;
      }
      internal OcrTesseractParamsInt GetIntStruct()
      {
        OcrTesseractParamsInt result = new OcrTesseractParamsInt();
        result.flags = flags;
        result.clip_rect = (PdfDevRectInt)clip_rect.GetIntStruct();
        result.page_seg = (int)page_seg;
        result.engine = (int)engine;
        result.zoom = zoom;
        result.rotate = (int)rotate;
        return result;
      }
      internal void SetIntStruct(OcrTesseractParamsInt inStruct)
      {
        flags = inStruct.flags;
        clip_rect = new PdfDevRect();
        clip_rect.SetIntStruct(inStruct.clip_rect);
        page_seg = (OcrTesseractPageSegType)inStruct.page_seg;
        engine = (OcrTesseractEngineType)inStruct.engine;
        zoom = inStruct.zoom;
        rotate = (PdfRotate)inStruct.rotate;
      }
    }


    public class OcrTesseract : PdfixPlugin    {
      public const int kErrorOcrTesseract = 2000;
      public const int kErrorOcrTesseractInitialization = 2001;
      public const int kErrorOcrTesseractMissingData = 2002;
      public const int kErrorOcrTesseractMissingLanguage = 2003;
      public const int kErrorOcrTesseractMissingPageImage = 2004;
      public const int kErrorOcrTesseractProcessDoc = 2005;
      public const int kErrorOcrTesseractProcessPage = 2006;
      public const int kOcrNone = 0x00;
      public const int kOcrImages = 0x0001;

      public OcrTesseract() : base(IntPtr.Zero)
      {
        m_obj = GetOcrTesseract();
      }
      [DllImport("ocr_tesseract.dll", CharSet = CharSet.Unicode)]
      internal static extern IntPtr GetOcrTesseract();
      public OcrTesseract(IntPtr obj) : base(obj) { }
      public bool SetLanguage(string _lang)
      {
        CheckBaseObj();
        bool ret = OcrTesseractSetLanguage(m_obj, _lang);
        return ret;
      }
      public bool SetData(string _path)
      {
        CheckBaseObj();
        bool ret = OcrTesseractSetData(m_obj, _path);
        return ret;
      }
      public TesseractDoc OpenOcrDoc(PdfDoc _pdDoc)
      {
        CheckBaseObj();
        IntPtr ret = OcrTesseractOpenOcrDoc(m_obj, _pdDoc.m_obj);
        if (ret != IntPtr.Zero)
        {
          return new TesseractDoc(ret);
        }
        return null;
      }

      [DllImport("ocr_tesseract.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool OcrTesseractSetLanguage(IntPtr obj, string _lang);
      [DllImport("ocr_tesseract.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool OcrTesseractSetData(IntPtr obj, string _path);
      [DllImport("ocr_tesseract.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr OcrTesseractOpenOcrDoc(IntPtr obj, IntPtr _pdDoc);
    }
    public class TesseractDoc : OcrTesseractBase
    {
      public TesseractDoc(IntPtr obj) : base(obj) { }
      public bool Close()
      {
        CheckBaseObj();
        bool ret = TesseractDocClose(m_obj);
        return ret;
      }
      public bool Save(string _path, OcrTesseractParams _params, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        OcrTesseractParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(OcrTesseractParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = TesseractDocSave(m_obj, _path, _params_ptr, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }

      [DllImport("ocr_tesseract.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool TesseractDocClose(IntPtr obj);
      [DllImport("ocr_tesseract.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool TesseractDocSave(IntPtr obj, string _path, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
    }
  }
}
