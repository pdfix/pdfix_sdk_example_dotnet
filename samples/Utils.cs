//\cond INTERNAL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
//\endcond
