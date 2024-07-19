using System;

namespace PDFix.App.Module
{
    class Program
    {
        static void Main()
        {
            try
            {
                PdfixEngine.Init();
                PdfixSamples.Run("../../../");
                Console.WriteLine("SUCCESS");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                PdfixEngine.Terminate();
            }
        }
    }
}
