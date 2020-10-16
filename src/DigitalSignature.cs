////////////////////////////////////////////////////////////////////////////////////////////////////
// DigitalSignature.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class DigitalSignature
    {
        public static void Run(
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String pfxPath,                             // pfx file PKCS 12 certificate
            String pfxPassword                          // pfx password
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            PdfDoc doc = pdfix.OpenDoc(openPath, "");
            if (doc == null)
                throw new Exception(pdfix.GetError());

            PdfDigSig digSig = pdfix.CreateDigSig();
            if (digSig == null)
                throw new Exception(pdfix.GetError());

            digSig.SetReason("Testing PDFix API");
            digSig.SetLocation("Location");
            digSig.SetContactInfo("info@pdfix.net");
            if (!digSig.SetPfxFile(pfxPath, pfxPassword))
                throw new Exception(pdfix.GetError());
            if (!digSig.SignDoc(doc, savePath))
                throw new Exception(pdfix.GetError());
            digSig.Destroy();

            doc.Close();
            pdfix.Destroy();
        }
    }
}