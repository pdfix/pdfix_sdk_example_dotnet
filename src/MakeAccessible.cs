////////////////////////////////////////////////////////////////////////////////////////////////////
// MakeAccessible.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Text;
using System.Text.Json;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class MakeAccessible
    {
        public static void Run(
            string openPath,
            string savePath,
            string commandPath)
        {
            Run(openPath, savePath, commandPath, "", "");
        }

        public static void Run(
            string openPath,
            string savePath,
            string commandPath,
            string language,
            string title)
        {
            Pdfix pdfix = PdfixEngine.Instance;
            PdfDoc doc = null;
            PsStream cmdStm = null;

            try
            {
                doc = pdfix.OpenDoc(openPath, "");
                if (doc == null)
                    throw new Exception(pdfix.GetError());

                PsCommand command = doc.GetCommand();
                if (command == null)
                    throw new Exception(pdfix.GetError());

                // If commandPath is empty, find the embedded custom action with name "make_accessible".
                // Otherwise load JSON from the provided file.
                if (string.IsNullOrEmpty(commandPath))
                {
                    int cmdCount = command.GetNumCustomActions();

                    for (int i = 0; i < cmdCount; i++)
                    {
                        PsStream tmpStm = pdfix.CreateMemStream();
                        if (tmpStm == null)
                            throw new Exception(pdfix.GetError());

                        try
                        {
                            if (!command.SaveCustomActionToStream(
                                    i,
                                    tmpStm,
                                    PsDataFormat.kDataFormatJson,
                                    Pdfix.kSaveFull))
                            {
                                throw new Exception(pdfix.GetError());
                            }

                            string json = ReadStreamAsString(tmpStm);
                            string name = ExtractJsonName(json);

                            if (name == "make_accessible")
                            {
                                cmdStm = tmpStm;
                                tmpStm = null; // ownership transferred
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"[WARNING]: Loading JSON command failed. [{i}] {ex.Message}");
                        }
                        finally
                        {
                            if (tmpStm != null)
                                tmpStm.Destroy();
                        }
                    }

                    if (cmdStm == null)
                        throw new Exception("Embedded custom action 'make_accessible' was not found.");
                }
                else
                {
                    cmdStm = pdfix.CreateFileStream(commandPath, PsFileMode.kPsReadOnly);
                    if (cmdStm == null)
                        throw new Exception(pdfix.GetError());
                }

                if (!command.LoadParamsFromStream(cmdStm, PsDataFormat.kDataFormatJson))
                    throw new Exception(pdfix.GetError());

                cmdStm.Destroy();
                cmdStm = null;

                if (!command.Run())
                    throw new Exception(pdfix.GetError());

                if (!string.IsNullOrEmpty(language) && !doc.SetLang(language))
                    throw new Exception(pdfix.GetError());

                if (!string.IsNullOrEmpty(title) && !doc.SetInfo("Title", title))
                    throw new Exception(pdfix.GetError());

                if (!doc.Save(savePath, Pdfix.kSaveFull))
                    throw new Exception(pdfix.GetError());
            }
            finally
            {
                if (cmdStm != null)
                    cmdStm.Destroy();

                if (doc != null)
                    doc.Close();
            }
        }

        private static string ReadStreamAsString(PsStream stm)
        {
            long size = stm.GetSize();
            if (size < 0 || size > int.MaxValue)
                throw new Exception($"Invalid stream size: {size}");

            byte[] buffer = new byte[(int)size];
            if (size > 0)
            {
                if (!stm.Read(0, buffer)) {
                    throw new Exception("Failed to read stream.");
                }
            }

            return Encoding.UTF8.GetString(buffer);
        }

        private static string ExtractJsonName(string json)
        {
            if (string.IsNullOrEmpty(json))
                return null;

            try
            {
                using JsonDocument doc = JsonDocument.Parse(json);
                JsonElement root = doc.RootElement;

                if (root.TryGetProperty("name", out JsonElement nameEl) &&
                    nameEl.ValueKind == JsonValueKind.String)
                {
                    return nameEl.GetString();
                }
            }
            catch
            {
            }

            return null;
        }
    }
}