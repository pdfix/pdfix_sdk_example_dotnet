////////////////////////////////////////////////////////////////////////////////////////////////////
// AddTags.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
//
// Tag content in page region as a Figure
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Security.Cryptography;
using PDFixSDK.Pdfix;
using System.Runtime.InteropServices;

namespace PDFix.App.Module
{
    class TagContentInRect
    {
        public static void Run(
            String openPath,                    // source PDF document
            String savePath                     // output PDF document
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            // open the document
            var doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // Prepare the structure tree where the content will be tagged
            var structTree = doc.CreateStructTree();
            var documentTagObj = structTree.GetChildObject(0);
            PdsStructElement documentStructElem =   documentTagObj == null ?
                                                    structTree.AddNewChild("Document", 0) :
                                                    structTree.GetStructElementFromObject(documentTagObj);
            
            // read the first page and prepare ccess to the page content
            PdfPage page = doc.AcquirePage(0);
            if (page == null) 
                throw new Exception(pdfix.GetError());                
            PdsContent content = page.GetContent();
            if (content == null) 
                throw new Exception(pdfix.GetError());

            // Define bounding box to be tagged
            PdfRect bbox = new PdfRect(_left: 53, _top: 700, _right: 205, _bottom: 526);

            // Define a page object enumeration callback. Method is called on each enumerated page object.
            PdfPageObjectEnumProc enumPageContentCallback = (_pageObject, _index, _data) =>
            {
                PdsPageObject obj = new PdsPageObject(_pageObject); 
                PdfRect objBbox = obj.GetBBox();
                if ((objBbox.left > bbox.right) || (objBbox.bottom > bbox.top) || (objBbox.right < bbox.left) || (objBbox.top < bbox.bottom))
                {
                    // Page Object is outside of the bbox
                    obj.SetStateFlags(Pdfix.kStateNoRender | Pdfix.kStateExclude);
                }                
                return PdfEnumResultType.kEnumResultContinue;
            };

            // Define annotation enumeration callback. Method is called on each enumerated annotation on the page.
            PdfAnnotEnumProc enumAnnotsCallback = (_page, _annot, _data) =>
            {
                var annot = new PdfAnnot(_annot); 
                PdfRect annotBBox = annot.GetBBox();
                if ((annotBBox.left > bbox.right) || (annotBBox.bottom > bbox.top) || (annotBBox.right < bbox.left) || (annotBBox.top < bbox.bottom))
                {
                    // Annotation is outside of the bbox
                    annot.SetStateFlags(Pdfix.kStateNoRender | Pdfix.kStateExclude);
                }                
                return PdfEnumResultType.kEnumResultContinue;
            };

            // enumerate all page objects and annotations on the page to exclude all outside of the tagged bbox
            doc.EnumPageObjects(content, null, Pdfix.kEnumForms, enumPageContentCallback, IntPtr.Zero);
            doc.EnumAnnots(0, Pdfix.kEnumNone, enumAnnotsCallback, IntPtr.Zero);

            // preare page map for layout recognition and tagging
            var pageMap = page.AcquirePageMap();            

            // [optional] create a layout element to tag as the desired type 
            var figureElem = pageMap.CreateElement(PdfElementType.kPdeImage, null);
            figureElem.SetBBox(bbox);
            figureElem.SetAlt("My Figure alt text");

            // create page map elemnts
            pageMap.CreateElements();

            // autotag the page unto the target struct element
            var tagParams = new PdfTagsParams();
            pageMap.AddTags(documentStructElem, false, tagParams);

            // cleanup
            pageMap.Release();
            page.Release();

            // save document
            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}