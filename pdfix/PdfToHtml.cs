////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2016 PDFix. All Rights Reserved.
// This file was generated automatically
////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Runtime.InteropServices;
using PDFixSDK.Pdfix;

namespace PDFixSDK {
  namespace PdfToHtml {
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
    public class PdfToHtmlBase
    {
      public IntPtr m_obj = IntPtr.Zero;
      public PdfToHtmlBase(IntPtr obj)
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

    public enum PdfHtmlType
    {
      kPdfHtmlFixed = 0,
      kPdfHtmlResponsive = 1,
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct PdfHtmlParamsInt
    {
      public int flags;
      public int width;
      public int type;
      public PdfImageParamsInt image_params;
    }
    public struct PdfHtmlParams
    {
      public int flags;
      public int width;
      public PdfHtmlType type;
      public PdfImageParams image_params;
      public PdfHtmlParams(int _flags, int _width, PdfHtmlType _type, PdfImageParams _image_params)
      {
        flags = _flags;
        width = _width;
        type = _type;
        image_params = _image_params;
      }
      internal PdfHtmlParamsInt GetIntStruct()
      {
        PdfHtmlParamsInt result = new PdfHtmlParamsInt();
        result.flags = flags;
        result.width = width;
        result.type = (int)type;
        result.image_params = (PdfImageParamsInt)image_params.GetIntStruct();
        return result;
      }
      internal void SetIntStruct(PdfHtmlParamsInt inStruct)
      {
        flags = inStruct.flags;
        width = inStruct.width;
        type = (PdfHtmlType)inStruct.type;
        image_params = new PdfImageParams();
        image_params.SetIntStruct(inStruct.image_params);
      }
    }


    public class PdfToHtml : PdfixPlugin    {
      public const int kErrorHtmlPdfDocInvalid = 1000;
      public const int kErrorHtmlPageOutOfRange = 1001;
      public const int kHtmlNone = 0x00;
      public const int kHtmlExportJavaScripts = 0x0001;
      public const int kHtmlExportFonts = 0x0002;
      public const int kHtmlRetainFontSize = 0x0004;
      public const int kHtmlRetainTextColor = 0x0008;
      public const int kHtml41Support = 0x0010;
      public const int kHtmlNoExternalCSS = 0x0020;
      public const int kHtmlNoExternalJS = 0x0040;
      public const int kHtmlNoExternalIMG = 0x0080;
      public const int kHtmlNoExternalFONT = 0x0100;
      public const int kHtmlGrayBackground = 0x0200;

      public PdfToHtml() : base(IntPtr.Zero)
      {
        m_obj = GetPdfToHtml();
      }
      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode)]
      internal static extern IntPtr GetPdfToHtml();
      public PdfToHtml(IntPtr obj) : base(obj) { }
      public PdfHtmlDoc OpenHtmlDoc(PdfDoc _doc)
      {
        CheckBaseObj();
        IntPtr ret = PdfToHtmlOpenHtmlDoc(m_obj, _doc.m_obj);
        if (ret != IntPtr.Zero)
        {
          return new PdfHtmlDoc(ret);
        }
        return null;
      }
      public bool SaveCSS(PsStream _stream)
      {
        CheckBaseObj();
        bool ret = PdfToHtmlSaveCSS(m_obj, _stream.m_obj);
        return ret;
      }
      public bool SaveJavaScript(PsStream _stream)
      {
        CheckBaseObj();
        bool ret = PdfToHtmlSaveJavaScript(m_obj, _stream.m_obj);
        return ret;
      }

      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern IntPtr PdfToHtmlOpenHtmlDoc(IntPtr obj, IntPtr _doc);
      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfToHtmlSaveCSS(IntPtr obj, IntPtr _stream);
      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfToHtmlSaveJavaScript(IntPtr obj, IntPtr _stream);
    }
    public class PdfHtmlDoc : PdfToHtmlBase
    {
      public PdfHtmlDoc(IntPtr obj) : base(obj) { }
      public bool Close()
      {
        CheckBaseObj();
        bool ret = PdfHtmlDocClose(m_obj);
        return ret;
      }
      public bool Save(string _path, PdfHtmlParams _params, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfHtmlParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfHtmlParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PdfHtmlDocSave(m_obj, _path, _params_ptr, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }
      public bool SaveDocHtml(PsStream _stream, PdfHtmlParams _params, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfHtmlParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfHtmlParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PdfHtmlDocSaveDocHtml(m_obj, _stream.m_obj, _params_ptr, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }
      public bool SavePageHtml(PsStream _stream, PdfHtmlParams _params, int _page_num, PdfCancelProc _cancel_proc, IntPtr _cancel_data)
      {
        CheckBaseObj();
        PdfHtmlParamsInt _paramsInt = _params.GetIntStruct();
        IntPtr _params_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PdfHtmlParamsInt)));
        Marshal.StructureToPtr(_paramsInt, _params_ptr, true);
        bool ret = PdfHtmlDocSavePageHtml(m_obj, _stream.m_obj, _params_ptr, _page_num, _cancel_proc, _cancel_data);
        Marshal.FreeHGlobal(_params_ptr);
        _params_ptr = IntPtr.Zero;
        return ret;
      }

      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfHtmlDocClose(IntPtr obj);
      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfHtmlDocSave(IntPtr obj, string _path, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfHtmlDocSaveDocHtml(IntPtr obj, IntPtr _stream, IntPtr _params, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
      [DllImport("pdf_to_html.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool PdfHtmlDocSavePageHtml(IntPtr obj, IntPtr _stream, IntPtr _params, int _page_num, [MarshalAs(UnmanagedType.FunctionPtr)]PdfCancelProc _cancel_proc, IntPtr _cancel_data);
    }
  }
}
