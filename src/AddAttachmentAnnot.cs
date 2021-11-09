////////////////////////////////////////////////////////////////////////////////////////////////////
// AddAttachmentAnnot.cs
// Copyright (c) 2021 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class AddAttachmentAnnot
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String attachmentPath                       // attachment PDF
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // rect for the new annotation
            PdfRect annot_rect = new PdfRect()
            {
                left = 300,
                right = 328,
                bottom = 50,
                top = 118
            };

            // create annotation dictionary and fill it
            PdsDictionary annot_dict = doc.CreateDictObject(true);
            PdsArray color_array = annot_dict.PutArray("C");
            color_array.PutNumber(0, 1);
            color_array.PutNumber(1, 0.33f);
            color_array.PutNumber(2, 0.25f);
            annot_dict.PutString("Contents", "AutoTag_Sample_original.pdf");
            annot_dict.PutNumber("F", 28);
            annot_dict.PutString("Name", "Paperclip");
            annot_dict.PutRect("Rect", annot_rect);
            annot_dict.PutString("Subj", "File Attachment");
            annot_dict.PutName("Subtype", "FileAttachment");
            annot_dict.PutString("T", "Mr PDFixer");
            annot_dict.PutName("Type", "Annot");

            PdsDictionary fs_dict = annot_dict.PutDict("FS");
            fs_dict.PutString("F", "AutoTag_Sample_original.pdf");
            fs_dict.PutName("Type", "Filespec");
            fs_dict.PutString("UF", "AutoTag_Sample_original.pdf");

            // open attachment doc
            var fileStm = pdfix.CreateFileStream(attachmentPath, PsFileMode.kPsReadOnly);
            if (fileStm == null)
                throw new Exception(pdfix.GetError());

            byte[] fileData = new byte[fileStm.GetSize()];
            fileStm.Read(0, fileData);

            // create stream object from attachment
            PdsStream filestream = doc.CreateStreamObject(true, null, fileData);

            PdsDictionary ef_dict = fs_dict.PutDict("EF");
            ef_dict.Put("F", filestream);
      
            // create annotation object from dictionary
            PdfAnnot annot = doc.GetAnnotFromObject(annot_dict);

            // add annotation on the first page
            var page = doc.AcquirePage(0);
            if (page == null)
                throw new Exception(pdfix.GetError());

            if (!page.AddAnnot(0, annot))
                throw new Exception(pdfix.GetError());

            page.Release();

            // save document
            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}