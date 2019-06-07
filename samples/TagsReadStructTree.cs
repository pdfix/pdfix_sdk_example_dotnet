////////////////////////////////////////////////////////////////////////////////////////////////////
// TagsReadStructTree.cs
// Copyright (c) 2019 Pdfix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*!
\page CS_Samples C# Samples
- \subpage TagsReadStructTree_cs
*/
/*! 
\page TagsReadStructTree_cs Read structure tree
Example how to manually read the document structure tree.
\snippet /TagsReadStructTree.cs TagsReadStructTree_cs
*/

//\cond INTERNAL
//! [TagsReadStructTree_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class TagsReadStructTree
    {
        internal static Pdfix pdfix;
        static void ProcessStructElement(PdsStructElement struct_elem, string indent)
        {
            indent += " ";
            if (struct_elem == null)
                throw new Exception(pdfix.GetErrorType().ToString());

            string type_str = struct_elem.GetType_(true);
            Console.WriteLine(indent + type_str);

            string tile_str = struct_elem.GetTitle();
            Console.WriteLine(indent + tile_str);

            string actual_text_str = struct_elem.GetActualText();
            Console.WriteLine(indent + actual_text_str);

            string alt_str = struct_elem.GetAlt();
            Console.WriteLine(indent, alt_str);

            var page_num = struct_elem.GetPageNumber();
            Console.WriteLine(indent, "Page number: "+ page_num);

            int num_kids = struct_elem.GetNumKids();
            for (int i = 0; i < num_kids; i++)
            {
                var kid_obj = struct_elem.GetKidObject(i);
                // based on structure element you can obtain different data
                switch (struct_elem.GetKidType(i))
                {
                    case PdfStructElementType.kPdsStructKidElement:
                        {
                            var kid_struct_elem = struct_elem.GetStructTree().AcquireStructElement(kid_obj);
                            if (kid_struct_elem == null)
                                throw new Exception(pdfix.GetErrorType().ToString());
                            ProcessStructElement(kid_struct_elem, indent);
                            kid_struct_elem.Release();
                        }
                        break;
                    case PdfStructElementType.kPdsStructKidObject:
                        break;
                    case PdfStructElementType.kPdsStructKidStreamContent:
                        {
                            var kid_page_num = struct_elem.GetKidPageNumber(i);
                            Console.WriteLine(indent + "Kid Page number: " + kid_page_num);
                            var mcid = struct_elem.GetKidMcid(i);
                            Console.WriteLine(indent + "MCID: " + mcid);
                        }
                        break;
                    case PdfStructElementType.kPdsStructKidPageContent:
                        {
                            var mcid = struct_elem.GetKidMcid(i);
                            Console.WriteLine(indent + "MCID: " + mcid);
                        }
                        break;               
                }
            }
        }
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath                             // dest PDF document
            )
        {
            pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetErrorType().ToString());

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // cleanup any previous structure tree
            if (!doc.RemoveTags(null, IntPtr.Zero))
                throw new Exception(pdfix.GetErrorType().ToString());

            // autotag document first
            if (!doc.AddTags(null, IntPtr.Zero))
                throw new Exception(pdfix.GetErrorType().ToString());

            // read document structure tree
            PdsStructTree struct_tree = doc.GetStructTree();
            if (struct_tree == null)
                Console.WriteLine("No Tags available");
            else
            {
                for (var i = 0; i < struct_tree.GetNumKids(); i++)
                {
                    PdsObject kid_object = struct_tree.GetKidObject(i);
                    PdsStructElement struct_elem = struct_tree.AcquireStructElement(kid_object);
                    ProcessStructElement(struct_elem, "");
                    struct_elem.Release();
                }
            }


            doc.Close();
            pdfix.Destroy();
        }
    }
}
//! [TagsReadStructTree_cs]
//\endcond