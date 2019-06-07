////////////////////////////////////////////////////////////////////////////////////////////////////
// ParsePdsObjects.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////
/*!
\page CS_Samples C# Samples
- \subpage ParsePdsObjects_cs
*/
/*!
\page ParsePdsObjects_cs Parse PdsObjects Sample
Example how to parse low level PDF objects.
\snippet /ParsePdsObjects.cs ParsePdsObjects_cs
*/

//\cond INTERNAL
//! [ParsePdsObjects_cs]
using System;
using PDFixSDK.Pdfix;
using System.IO;

namespace PDFix.App.Module
{
    class ParsePdsObjects
    {
        ///////////////////////////////////////////////////////////////////////
        // ParseElement
        ///////////////////////////////////////////////////////////////////////
        private static void ParseObject(PdsObject obj, int level)
        {
            if (level == 3) return; // Don't go too deep, it's just a sample.

            Action<string> dump = str =>
            {
                Console.WriteLine($"{str}");
            };

            String indent = new String('-', level);
            dump(indent);

            // parse element based on type;
            PdfObjectType objType = obj.GetObjectType();
            switch (objType)
            {
                case PdfObjectType.kPdsNull:
                    dump(indent + "null:" + ((PdsBoolean)obj).GetValue());
                    break;
                case PdfObjectType.kPdsBoolean:
                    dump(indent + "boolean:" + ((PdsBoolean)obj).GetValue());
                    break;
                case PdfObjectType.kPdsNumber:
                    dump(indent + "number:" + ((PdsNumber)obj).GetValue());
                    break;
                case PdfObjectType.kPdsString:
                    dump(indent + "string:" + ((PdsString)obj).GetText());
                    break;
                case PdfObjectType.kPdsStream:
                    dump(indent + "stream:" + ((PdsStream)obj).GetRawDataSize());
                    ParseObject(((PdsStream)obj).GetStreamDict(), level + 1);
                    break;
                case PdfObjectType.kPdsArray:
                    {
                        dump("array:");
                        PdsArray arr = (PdsArray)obj;
                        for (int i = 0; i < arr.GetNumObjects(); i++)
                        {
                            dump(indent + " [" + i + "]");
                            ParseObject(arr.Get(i), level + 1);
                        }
                    }
                    break;
                case PdfObjectType.kPdsDictionary:
                    {
                        dump("dictionary:");
                        PdsDictionary dict = (PdsDictionary)obj;
                        for (int i = 0; i < dict.GetNumKeys(); i++)
                        {
                            String key = dict.GetKey(i);
                            dump(indent + " /" + key);
                            ParseObject(dict.Get(key), level + 1);
                        }
                    }
                    break;
            }
        }

        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath                             // source PDF document
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

            PdsObject rootObj = doc.GetRootObject();
            ParseObject(rootObj, 1);

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [ParsePdsObjects_cs]
//\endcond
