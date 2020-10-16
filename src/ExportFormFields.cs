using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class ExportFormFields
    {
        private static int _tabOrder = 0;
        private static Pdfix _pdfix;

        private static void ProcessDocumentFormFields(PdfDoc doc)
        {
            for (int i = 0; i < doc.GetNumFormFields(); i++)
            {
                var field = doc.GetFormField(i);
                GetFormFieldProperties(null, null, field);
            }
        }
        private static void ProcessFormFieldsViaPages(PdfDoc doc)
        {
            _tabOrder = 0;
            // display form field names in th eorder of the tab order
            for (int i = 0; i < doc.GetNumPages(); i++)
            {
                var page = doc.AcquirePage(i);
                for (int j = 0; j < page.GetNumAnnots(); j++)
                {
                    var annot = page.GetAnnot(j);
                    if (annot.GetSubtype() == PdfAnnotSubtype.kAnnotWidget)
                    {
                        var widget = (PdfWidgetAnnot)annot;
                        GetWidgetAnnotProperties(page, widget);
                    }
                }
                page.Release();
            }
        }

        private static void GetWidgetAnnotProperties(PdfPage page, PdfWidgetAnnot widget)
        {
            var formField = widget.GetFormField();
            GetFormFieldProperties(page, widget, widget.GetFormField());
        }

        private static void GetFormFieldProperties(PdfPage page, PdfWidgetAnnot widget, PdfFormField field)
        {
            Console.WriteLine("===========================================");
            if (field != null)
            {
                Console.WriteLine("Name: " + field.GetFullName());
                Console.WriteLine("Value: " + field.GetValue());
                Console.WriteLine("Tooltip: " + field.GetTooltip());
                string options = "";
                for (int i = 0; i < field.GetNumOptions(); i++)
                {
                    options += field.GetOptionValue(i) + " | ";
                }
                Console.WriteLine("Options: " + options);
                Console.WriteLine("MaxLength: " + field.GetMaxLength());
                Console.WriteLine("Multiline: " + (field.GetFlags() & Pdfix.kFieldFlagMultiline).ToString());
                Console.WriteLine("IsFormatted: " + (field.GetAAction(PdfActionEventType.kActionEventFieldFormat) != null).ToString());
                Console.WriteLine("Required: " + ((field.GetFlags() & Pdfix.kFieldFlagRequired).ToString()).ToString());
                Console.WriteLine("ReadOnly: " + ((field.GetFlags() & Pdfix.kFieldFlagReadOnly).ToString()).ToString());
                Console.WriteLine("IsFormatted: " + (field.GetAAction(PdfActionEventType.kActionEventFieldCalculate) != null).ToString());
                Console.WriteLine("IsChecked: " + (field.GetValue() == field.GetWidgetExportValue(widget)).ToString());
                Console.WriteLine("FieldType: " + field.GetType().ToString());
            }

            if (page != null && widget != null)
            {
                // widget specific properties
                var bbox = widget.GetBBox();
                var page_view = page.AcquirePageView(1, PdfRotate.kRotate0);
                var rect = page_view.RectToDevice(bbox);
                page_view.Release();

                // calculate widget annot position in % of the page width
                var left = (double)rect.left / (double)page_view.GetDeviceWidth();
                var top = (double)rect.top / (double)page_view.GetDeviceHeight();
                var width = (double)(rect.right - rect.left) / (double)page_view.GetDeviceWidth();
                var height = (double)(rect.bottom - rect.top) / (double)page_view.GetDeviceHeight();

                Console.WriteLine("TabOrder: " + (_tabOrder++).ToString());
                Console.WriteLine("Left: " + left.ToString() + ", Top: " + top.ToString());
                Console.WriteLine("Width: " + width.ToString() + ", Height: " + height.ToString());
            }
        }


        public static void Run(
            String openPath                     // source PDF document
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");
            _pdfix = pdfix;

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            Console.WriteLine("detect form field tab order");
            ProcessFormFieldsViaPages(doc);

            Console.WriteLine("");
            Console.WriteLine("********************************************************");
            Console.WriteLine("");

            Console.WriteLine("map all document fields, some spccific proerties may ne inaccesscible"); 
            ProcessDocumentFormFields(doc);

            doc.Close();
            pdfix.Destroy();
        }
    }
}