using System;

namespace PDFix.App.Module
{
    class Utils
    {
        public static String GetAbsolutePath(String name)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory;
            return path + name;
        }
    }
}