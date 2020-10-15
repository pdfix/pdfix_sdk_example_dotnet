using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class GetFormFieldValueEx
    {
        public static void GetFormFieldValue(PdfFormField field)
        {
            Console.WriteLine("Field: " + field.GetFullName());
            var field_obj = field.GetObject();
            var value_obj = field_obj.Get("V");
            if (value_obj == null)
            {
                Console.WriteLine("Value is empty");
                return;
            }

            switch (value_obj.GetObjectType())
            {
                case PdfObjectType.kPdsString:
                    {
                        // single value od the form field
                        PdsString value_str = (PdsString)value_obj;
                        Console.WriteLine("Value: " + value_str.GetText());
                    }
                    break;
                case PdfObjectType.kPdsArray:
                    {
                        // multiple values (e.g listbox with mutiple selection set)
                        PdsArray value_arr = (PdsArray)value_obj;
                        for (var i = 0; i < value_arr.GetNumObjects(); i++)
                        {
                            Console.WriteLine("Value" + (i+1).ToString() +": " + value_arr.GetText(i));
                        }
                    }
                    break;
            }
        }

        public static void Run(
            String openPath                     // source PDF document
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            for (var i = 0; i < doc.GetNumFormFields(); i++)
            {
                var field = doc.GetFormField(i);
                GetFormFieldValue(field);
            }


            doc.Close();
            pdfix.Destroy();
        }
    }
}