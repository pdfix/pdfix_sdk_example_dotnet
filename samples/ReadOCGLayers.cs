////////////////////////////////////////////////////////////////////////////////////////////////////
// ReadOCGLayers.cs
// Copyright (c) 2018 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////
/*!
\page CS_Samples C# Samples
- \subpage ReadOCGLayers_cs
*/
/*!
\page ReadOCGLayers_cs Read OCG Layers Sample
Example how to read optional content groups - OCG Layers.
\snippet /ReadOCGLayers.cs ReadOCGLayers_cs
*/

//\cond INTERNAL
//! [ReadOCGLayers_cs]
using System;
using PDFixSDK.Pdfix;
using System.IO;
using System.Collections.Generic;

namespace PDFix.App.Module
{
    class ReadOCGLayers
    {
        public static List<KeyValuePair<string, int>> ReadLayerNames(PdsDictionary rootObj)
        {
            var layers = new List<KeyValuePair<string, int>>();

            var ocprops = rootObj.GetDictionary("OCProperties");
            if (ocprops != null)
            {
                var ocgs = ocprops.GetArray("OCGs");
                if (ocgs != null)
                {
                    for (var index = 0; index < ocgs.GetNumObjects(); index++)
                    {
                        var ocg = ocgs.GetDictionary(index);
                        if (ocg == null)
                            continue;
                        
                        var name = ocg.GetText("Name");
                        var id = ocg.GetId();
                        layers.Add(new KeyValuePair<string, int>(name, id));
                    }
                }
            }
            return layers;
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

            var rootObj = doc.GetRootObject();
            var layers = ReadLayerNames(rootObj);

            foreach (KeyValuePair<string, int> layer in layers)
            {
                Console.WriteLine(layer.Key + " : " + layer.Value.ToString());
            }

            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [ReadOCGLayers_cs]
//\endcond
