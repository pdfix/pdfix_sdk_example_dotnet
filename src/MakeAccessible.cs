////////////////////////////////////////////////////////////////////////////////////////////////////
// MakeAccessible.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class MakeAccessible
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String commandPath                          // command configuration file
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            PsCommand cmd = doc.GetCommand();

            // customize auto-tagging
            PsFileStream stm = pdfix.CreateFileStream(commandPath, PsFileMode.kPsReadOnly);
            if (stm == null)
            {
                throw new Exception(pdfix.GetError());
            }
            if (!cmd.LoadParamsFromStream(stm, PsDataFormat.kDataFormatJson))
            {
                throw new Exception(pdfix.GetError());
            }
            stm.Destroy();

            if (!cmd.Run())
            {
                throw new Exception(pdfix.GetError());
            }

            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}