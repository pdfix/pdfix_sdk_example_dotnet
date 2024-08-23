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

            PsCommand command = doc.GetCommand();

            PsStream cmdStm;

            // if command path is empty, use the default make accessible command from the SDK, othervise use the provided path to JSON
            if (commandPath.Length == 0)
            {
                cmdStm = pdfix.CreateMemStream();
                if ((cmdStm == null) || !command.SaveCommandsToStream(PsCommandType.kActionMakeAccessible, cmdStm, PsDataFormat.kDataFormatJson,
                                                            Pdfix.kSaveFull))
                {
                    throw new Exception(pdfix.GetError());
                }
            }
            else
            {
                cmdStm = pdfix.CreateFileStream(commandPath, PsFileMode.kPsReadOnly);
                if (cmdStm == null)
                {
                    throw new Exception(pdfix.GetError());
                }
            }
            if (!command.LoadParamsFromStream(cmdStm, PsDataFormat.kDataFormatJson))
            {
                throw new Exception(pdfix.GetError());
            }
            cmdStm.Destroy();

            // Run the command
            if (!command.Run())
            {
                throw new Exception(pdfix.GetError());
            }

            // save document
            if (!doc.Save(savePath, Pdfix.kSaveFull))
                throw new Exception(pdfix.GetError());

            doc.Close();
        }
    }
}