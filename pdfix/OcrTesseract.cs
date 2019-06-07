////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2019 PDFix (http://pdfix.net). All Rights Reserved.
// This file was generated automatically
////////////////////////////////////////////////////////////////////////////////
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
      static internal bool Is64BitProcess()
      {
        return IntPtr.Size == 8;
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



    public class OcrTesseract : PdfixPlugin    {
      public const int kErrorOcrTesseract = 2000;
      public const int kErrorOcrTesseractInitialization = 2001;
      public const int kErrorOcrTesseractMissingData = 2002;
      public const int kErrorOcrTesseractMissingLanguage = 2003;
      public const int kErrorOcrTesseractMissingPageImage = 2004;
      public const int kErrorOcrTesseractProcessDoc = 2005;
      public const int kErrorOcrTesseractProcessPage = 2006;
      public const int kErrorOcrTesseractIteratePage = 2007;
      public const int kErrorOcrTesseractMissingFont = 2008;

      public OcrTesseract() : base(IntPtr.Zero)
      {
        m_obj = GetOcrTesseract();
      }
      [DllImport("ocr_tesseract.dll", EntryPoint="GetOcrTesseract", CharSet = CharSet.Unicode)]
      internal static extern IntPtr GetOcrTesseract32();
      [DllImport("ocr_tesseract64.dll", EntryPoint="GetOcrTesseract", CharSet = CharSet.Unicode)]
      internal static extern IntPtr GetOcrTesseract64();
      internal static IntPtr GetOcrTesseract()
      {
        if (Util.Is64BitProcess()) return GetOcrTesseract64();
        else return GetOcrTesseract32();
      }
      public OcrTesseract(IntPtr obj) : base(obj) { }
      public bool SetLanguage(string _lang)
      {
        CheckBaseObj();
        byte ret = OcrTesseractSetLanguage(m_obj, _lang);
        return ret != 0;
      }
      public bool SetDataPath(string _path)
      {
        CheckBaseObj();
        byte ret = OcrTesseractSetDataPath(m_obj, _path);
        return ret != 0;
      }
      public bool SetEngine(OcrTesseractEngineType _engine)
      {
        CheckBaseObj();
        byte ret = OcrTesseractSetEngine(m_obj, (int)_engine);
        return ret != 0;
      }
      public TesseractDoc OpenOcrDoc(PdfDoc _pdDoc)
      {
        CheckBaseObj();
        IntPtr ret = OcrTesseractOpenOcrDoc(m_obj, _pdDoc == null ? IntPtr.Zero : _pdDoc.m_obj);
        if (ret != IntPtr.Zero)
        {
          return new TesseractDoc(ret);
        }
        return null;
      }

      [DllImport("ocr_tesseract.dll", EntryPoint="OcrTesseractSetLanguage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte OcrTesseractSetLanguage32(IntPtr obj, string _lang);
      [DllImport("ocr_tesseract64.dll", EntryPoint="OcrTesseractSetLanguage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte OcrTesseractSetLanguage64(IntPtr obj, string _lang);
      internal static byte OcrTesseractSetLanguage(IntPtr obj, string _lang)
      {
        if (Util.Is64BitProcess()) return OcrTesseractSetLanguage64(obj, _lang);
        else return OcrTesseractSetLanguage32(obj, _lang);
      }
      [DllImport("ocr_tesseract.dll", EntryPoint="OcrTesseractSetDataPath", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte OcrTesseractSetDataPath32(IntPtr obj, string _path);
      [DllImport("ocr_tesseract64.dll", EntryPoint="OcrTesseractSetDataPath", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte OcrTesseractSetDataPath64(IntPtr obj, string _path);
      internal static byte OcrTesseractSetDataPath(IntPtr obj, string _path)
      {
        if (Util.Is64BitProcess()) return OcrTesseractSetDataPath64(obj, _path);
        else return OcrTesseractSetDataPath32(obj, _path);
      }
      [DllImport("ocr_tesseract.dll", EntryPoint="OcrTesseractSetEngine", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte OcrTesseractSetEngine32(IntPtr obj, int _engine);
      [DllImport("ocr_tesseract64.dll", EntryPoint="OcrTesseractSetEngine", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte OcrTesseractSetEngine64(IntPtr obj, int _engine);
      internal static byte OcrTesseractSetEngine(IntPtr obj, int _engine)
      {
        if (Util.Is64BitProcess()) return OcrTesseractSetEngine64(obj, _engine);
        else return OcrTesseractSetEngine32(obj, _engine);
      }
      [DllImport("ocr_tesseract.dll", EntryPoint="OcrTesseractOpenOcrDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr OcrTesseractOpenOcrDoc32(IntPtr obj, IntPtr _pdDoc);
      [DllImport("ocr_tesseract64.dll", EntryPoint="OcrTesseractOpenOcrDoc", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr OcrTesseractOpenOcrDoc64(IntPtr obj, IntPtr _pdDoc);
      internal static IntPtr OcrTesseractOpenOcrDoc(IntPtr obj, IntPtr _pdDoc)
      {
        if (Util.Is64BitProcess()) return OcrTesseractOpenOcrDoc64(obj, _pdDoc);
        else return OcrTesseractOpenOcrDoc32(obj, _pdDoc);
      }
    }
    public class TesseractDoc : OcrTesseractBase
    {
      public TesseractDoc(IntPtr obj) : base(obj) { }
      public bool Close()
      {
        CheckBaseObj();
        byte ret = TesseractDocClose(m_obj);
        return ret != 0;
      }
      public bool OcrImageToPage(PsImage _image, PdfMatrix _matrix, PdfPage _page, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfMatrixInt _matrixInt = _matrix.GetIntStruct();
        IntPtr _matrix_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfMatrixInt)));
        Marshal.StructureToPtr(_matrixInt, _matrix_ptr, true);
        byte ret = TesseractDocOcrImageToPage(m_obj, _image == null ? IntPtr.Zero : _image.m_obj, _matrix_ptr, _page == null ? IntPtr.Zero : _page.m_obj, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_matrix_ptr);
        _matrix_ptr = IntPtr.Zero;
        return ret != 0;
      }

      [DllImport("ocr_tesseract.dll", EntryPoint="TesseractDocClose", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte TesseractDocClose32(IntPtr obj);
      [DllImport("ocr_tesseract64.dll", EntryPoint="TesseractDocClose", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte TesseractDocClose64(IntPtr obj);
      internal static byte TesseractDocClose(IntPtr obj)
      {
        if (Util.Is64BitProcess()) return TesseractDocClose64(obj);
        else return TesseractDocClose32(obj);
      }
      [DllImport("ocr_tesseract.dll", EntryPoint="TesseractDocOcrImageToPage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte TesseractDocOcrImageToPage32(IntPtr obj, IntPtr _image, IntPtr _matrix, IntPtr _page, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("ocr_tesseract64.dll", EntryPoint="TesseractDocOcrImageToPage", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern byte TesseractDocOcrImageToPage64(IntPtr obj, IntPtr _image, IntPtr _matrix, IntPtr _page, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      internal static byte TesseractDocOcrImageToPage(IntPtr obj, IntPtr _image, IntPtr _matrix, IntPtr _page, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        if (Util.Is64BitProcess()) return TesseractDocOcrImageToPage64(obj, _image, _matrix, _page, _cancel_proc, _cancel_data);
        else return TesseractDocOcrImageToPage32(obj, _image, _matrix, _page, _cancel_proc, _cancel_data);
      }
    }
  }
}
