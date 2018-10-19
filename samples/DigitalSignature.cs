////////////////////////////////////////////////////////////////////////////////////////////////////
// DigitalSignature.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*! 
\page CS_Samples C# Samples
- \subpage DigitalSignature_cs
*/
/*! 
\page DigitalSignature_cs PFX Digital Signature Sample
// Example how to apply a digital signature from the PFX file.
\snippet /DigitalSignature.cs DigitalSignature_cs
*/

//\cond INTERNAL
//! [DigitalSignature_cs]
using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class DigitalSignature
    {
        public static void Run(
            String email,                               // authorization email   
            String licenseKey,                          // authorization license key
            String openPath,                            // source PDF document
            String savePath,                            // output PDF document
            String pfxPath,                             // pfx file PKCS 12 certificate
            String pfxPassword                          // pfx password
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail");

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetError());

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
//! [DigitalSignature_cs]
//\endcond
