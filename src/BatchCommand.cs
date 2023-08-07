using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PDFixSDK.Pdfix;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PDFix.App.Module
{
    class BatchCommand
    {
        internal static string cmd_commands = "commands";
        internal static string cmd_params = "params";
        internal static string cmd_output = "output";
        internal static string cmd_get_doc_info = "get_doc_info";
        internal static string cmd_pdf_to_html = "pdf_to_html";
        internal static string cmd_pdf_to_json = "pdf_to_json";
        internal static string cmd_preflight = "preflight";
        internal static string cmd_load_template = "load_template";
        internal static string cmd_reset_template = "reset_template";
        internal static string cmd_add_tags = "add_tags";
        internal static string cmd_clear_structure = "clear_structure";
        internal static string cmd_set_doc_info = "set_doc_info";
        internal static string cmd_set_pdf_standard = "set_pdf_standard";
        internal static string cmd_set_language = "set_language";
        internal static string cmd_set_title = "set_title";
        internal static string cmd_embed_font = "embed_font";
        internal static string cmd_add_missing_unicode = "add_missing_unicode";
        internal static string cmd_repair_parent_tree = "repair_parent_tree";
        internal static string cmd_repair_id_tree = "repair_id_tree";
        internal static string cmd_create_bookmarks = "create_bookmarks";
        internal static string cmd_artifact_content = "artifact_content";
        internal static string cmd_flatten_xobject = "flatten_xobject";
        internal static string cmd_set_tabs_key = "set_tabs_key";
        internal static string cmd_delete_tags = "delete_tags";
        internal static string cmd_apply_standard_tags = "apply_standard_tags";
        internal static string cmd_set_tag_id = "set_tag_id";
        internal static string cmd_fix_placement = "fix_placement";
        internal static string cmd_remove_tag_data = "remove_tag_data";
        internal static string cmd_set_annot_contents = "set_annot_contents";
        internal static string cmd_flatten_annot = "flatten_annot";
        internal static string cmd_remove_content_marks = "remove_content_marks";
        internal static string cmd_set_structure_attribute = "set_structure_attribute";
        internal static string cmd_fix_structure_spaces = "fix_structure_spaces";
        internal static string cmd_rotate_pages = "rotate_pages";
        internal static string cmd_ocr_tesseract = "ocr_tesseract";
        internal static string cmd_error = "error";

        internal static void processCommand(PdfDoc doc, JObject command, JObject resultJson)
        {
            Pdfix pdfix = PdfixEngine.Instance;
            var doc_command = doc.GetCommand();
            if (doc_command == null)
                new Exception(pdfix.GetError());

            if (!doc_command.Reset())
                new Exception(pdfix.GetError());

            var cmd_name = (string)command["name"];
            var cmd_params = (JObject)command["params"];
            if (cmd_params != null)
            {
                var memStm = pdfix.CreateMemStream();
                if (memStm == null)
                    new Exception(pdfix.GetError());

                memStm.Write(0, Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(cmd_params)));
                if (!doc_command.LoadParamsFromStream(memStm, PsDataFormat.kDataFormatJson))
                    new Exception(pdfix.GetError());

                memStm.Destroy();
            }

            // Commands
            bool result = true;
            if (cmd_name == cmd_get_doc_info)
            {
                result = doc_command.GetInfo();
            }
            else if (cmd_name == cmd_pdf_to_html)
            {
                result = doc_command.ConvertToHtml(null, null);
            }
            else if (cmd_name == cmd_pdf_to_json)
            {
                result = doc_command.ConvertToJson(null, null, null);
            }
            else if (cmd_name == cmd_preflight)
            {
                result = doc_command.Preflight(null, null);
            }
            else if (cmd_name == cmd_load_template)
            {
                result = doc_command.LoadTemplate();
            }
            else if (cmd_name == cmd_reset_template)
            {
                result = doc_command.ResetTemplate();
            }
            else if (cmd_name == cmd_add_tags)
            {
                result = doc_command.AddTags(null, null);
            }
            else if (cmd_name == cmd_clear_structure)
            {
                result = doc_command.DeleteDocumentStructure(null, null);
            }
            else if (cmd_name == cmd_set_doc_info)
            {
                result = doc_command.SetInfo();
            }
            else if (cmd_name == cmd_set_pdf_standard)
            {
                result = doc_command.SetPdfStandard();
            }
            else if (cmd_name == cmd_set_language)
            {
                result = doc_command.SetLanguage();
            }
            else if (cmd_name == cmd_set_title)
            {
                result = doc_command.SetTitle();
            }
            else if (cmd_name == cmd_embed_font)
            {
                result = doc_command.EmbedFonts(null, null);
            }
            else if (cmd_name == cmd_add_missing_unicode)
            {
                result = doc_command.AddMissingUnicode(null, null);
            }
            else if (cmd_name == cmd_repair_parent_tree)
            {
                result = doc_command.RepairParentTree(null, null);
            }
            else if (cmd_name == cmd_repair_id_tree)
            {
                result = doc_command.RepairIdTree(null, null);
            }
            else if (cmd_name == cmd_create_bookmarks)
            {
                result = doc_command.CreateBookmarks(null, null);
            }
            else if (cmd_name == cmd_artifact_content)
            {
                result = doc_command.ArtifactContent(null, null, null, null);
            }
            else if (cmd_name == cmd_flatten_xobject)
            {
                result = doc_command.FlattenFormXObject(null, null, null);
            }
            else if (cmd_name == cmd_set_tabs_key)
            {
                result = doc_command.SetTabsKey(null, null, null);
            }
            //else if (cmd_name == cmd_delete_tags)
            //{
            //    result = doc_command.DeleteTags(null, null, null);
            //}
            else if (cmd_name == cmd_apply_standard_tags)
            {
                result = doc_command.ApplyStandardTags(null, null, null);
            }
            else if (cmd_name == cmd_set_tag_id)
            {
                result = doc_command.AddTagId(null, null, null);
            }
            else if (cmd_name == cmd_fix_placement)
            {
                result = doc_command.FixPlacement(null, null, null);
            }
            else if (cmd_name == cmd_remove_tag_data)
            {
                result = doc_command.RemoveTagData(null, null, null);
            }
            else if (cmd_name == cmd_set_annot_contents)
            {
                result = doc_command.SetAnnotContents(null, null, null, null);
            }
            else if (cmd_name == cmd_flatten_annot)
            {
                result = doc_command.FlattenAnnot(null, null, null, null);
            }
            else if (cmd_name == cmd_remove_content_marks)
            {
                result = doc_command.RemoveContentMarks(null, null, null);
            }
            else if (cmd_name == cmd_set_structure_attribute)
            {
                result = doc_command.SetStructureAttribute(null, null, null);
            }
            else if (cmd_name == cmd_fix_structure_spaces)
            {
                result = doc_command.FixStructureSpaces(null, null, null);
            }
            //else if (cmd_name == cmd_rotate_pages)
            //{
            //    result = doc_command.RotatePages(null, null);
            //}
            //else if (cmd_name == cmd_ocr_tesseract)
            //{
            //    // initialize OCR Plugin on the first use
            //    if (!OcrTesseract_init(OcrTesseract_MODULE_NAME))
            //    {
            //        throw std::runtime_error("OCR Tesseract initialization fail");
            //    }
            //    if (!GetOcrTesseract()->Initialize(GetPdfix()) ||
            //        (!GetPdfix()->GetPluginByName(PLUGIN_OCR_TESSERACT) &&
            //         (!GetPdfix()->RegisterPlugin(GetOcrTesseract(), PLUGIN_OCR_TESSERACT))))
            //    {
            //        throw PdfixException();
            //    }
            //    result = doc_command.OcrTesseract(null, null);
            //}
            else
            {
                resultJson[cmd_error] = "command not found";
            }
            if (!result)
            {
                throw new Exception(pdfix.GetError());
            }

            // write output node
            PsMemoryStream outputMemStm = pdfix.CreateMemStream();
            if (outputMemStm != null)
            {
                if (!doc_command.SaveOutputToStream(outputMemStm, PsDataFormat.kDataFormatJson, Pdfix.kSaveUncompressed))
                    throw new Exception(pdfix.GetError());

                var sz = outputMemStm.GetSize();
                if (sz > 0)
                {
                    byte[] data = new byte[sz];
                    if (!outputMemStm.Read(0, data))
                        throw new Exception(pdfix.GetError());

                    var outputJson = (JObject)JsonConvert.DeserializeObject(Encoding.UTF8.GetString(data));
                    if (outputJson != null)
                    {
                        resultJson[cmd_output] = outputJson;
                    }
                }
                outputMemStm.Destroy();
            }
        }

        static void processBatch(PdfDoc doc, JObject batchJson, JObject resultJson)
        {
            JArray batchResults = new JArray();
            var commands = (JArray)batchJson["commands"];
            if (commands == null)
            {
                throw new Exception("commands not found");
            }
            foreach (var command in commands)
            {
                JObject cmdResults = new JObject();
                processCommand(doc, (JObject)command, cmdResults);
                batchResults.Add(cmdResults);
            }
            resultJson[cmd_commands] = batchResults;
        }

        public static void Run(
            String openPath,                    // source PDF document
            String savePath,                    // output PDF document
            String configPath                   // batch configuration file
            )
        {
            Pdfix pdfix = PdfixEngine.Instance;

            // open the document
            var doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            // load JSON from path
            JObject batchJson = JObject.Parse(File.ReadAllText(configPath));
            JObject resultsJson = new JObject();
            processBatch(doc, batchJson, resultsJson);

            // save only if modified. the document will not be saved if not modified
            if ((doc.GetFlags() & (Pdfix.kDocIsModified | Pdfix.kDocNeedsSave)) != 0)
            {
                // save changes if modified
                if (!doc.Save(savePath, Pdfix.kSaveFull))
                {
                    throw new Exception(pdfix.GetError());
                }
            }
            doc.Close();
        }
    }
}
