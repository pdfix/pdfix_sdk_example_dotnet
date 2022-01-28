using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
	class PdfixEngine
	{
        public static Pdfix Instance { get; private set; }

        public static void Init()
        {
            if (Instance == null)
                Instance = new Pdfix();
            if (Instance == null)
                throw new Exception("Pdfix initialization fail");
        }

        public static void ThrowException()
		{
            throw new Exception(Instance.GetError());
        }

        public static void Terminate()
        {
            if (Instance._obj != IntPtr.Zero)
                Instance.Destroy();
            Instance = null;
        }
    }
}
