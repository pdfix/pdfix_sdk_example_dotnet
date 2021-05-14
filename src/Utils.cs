using PDFixSDK.Pdfix;
using System;

namespace PDFix.App.Module
{
    class Utils
    {

        public const float kPi = 3.1415926535897932384626433832795f;

        public static String GetAbsolutePath(String name)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory;
            return path + name;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // PdfMatrix utils
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static PdfMatrix PdfMatrixConcat(PdfMatrix m, PdfMatrix m1, bool prepend)
        {
            var ret = new PdfMatrix();
            if (prepend)
            {
                var swap = m;
                m = m1;
                m1 = swap;
            }
            ret.a = m.a * m1.a + m.b * m1.c;
            ret.b = m.a * m1.b + m.b * m1.d;
            ret.c = m.c * m1.a + m.d * m1.c;
            ret.d = m.c * m1.b + m.d * m1.d;
            ret.e = m.e * m1.a + m.f * m1.c + m1.e;
            ret.f = m.e * m1.b + m.f * m1.d + m1.f;
            return ret;
        }

        public static PdfMatrix PdfMatrixRotate(PdfMatrix m, float radian, bool prepend)
        {
            var cosValue = (float)Math.Cos(radian);
            var sinValue = (float)Math.Sin(radian);
            var m1 = new PdfMatrix();
            m1.a = cosValue;
            m1.b = sinValue;
            m1.c = -sinValue;
            m1.d = cosValue;
            return PdfMatrixConcat(m, m1, prepend);
        }

        public static PdfMatrix PdfMatrixScale(PdfMatrix m, float sx, float sy, bool prepend)
        {
            var ret = new PdfMatrix();
            ret.a = m.a * sx;
            ret.d = m.d * sy;
            if (prepend)
            {
                ret.b = m.b * sx;
                ret.c = m.c * sy;
            }
            ret.b = m.b * sy;
            ret.c = m.c * sx;
            ret.e = m.e * sx;
            ret.f = m.f * sy;
            return ret;
        }

        public static PdfMatrix PdfMatrixTranslate(PdfMatrix m, float x, float y, bool prepend)
        {
            var ret = m;
            if (prepend)
            {
                ret.e = m.e + x * m.a + y + m.c;
                ret.f = m.f + y * m.d + x * m.b;
            }
            ret.e = m.e + x;
            ret.f = m.f + y;
            return ret;
        }

        public static PdfMatrix PdfMatrixInverse(PdfMatrix orig)
        {
            var inverse = new PdfMatrix();
            var i = orig.a * orig.d - orig.b * orig.c;
            if (Math.Abs(i) == 0)
                return inverse;

            var j = -i;
            inverse.a = orig.d / i;
            inverse.b = orig.b / j;
            inverse.c = orig.c / j;
            inverse.d = orig.a / i;
            inverse.e = (orig.c * orig.f - orig.d * orig.e) / i;
            inverse.f = (orig.a * orig.f - orig.b * orig.e) / j;
            return inverse;
        }

    }
}