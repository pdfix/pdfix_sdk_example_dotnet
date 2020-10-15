////////////////////////////////////////////////////////////////////////////////////////////////////
// Initialization.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using PDFixSDK.Pdfix;

namespace PDFix.App.Module
{
    class Initialization
    {
        public static void Run( 
            String email,                                           // authorization email
            String licenseKey                                       // license key
            )
        {
            Pdfix pdfix = new Pdfix();
            if (pdfix == null)
                throw new Exception("Pdfix initialization fail. Please set correct email and license key.");

            Console.WriteLine(pdfix.GetVersionMajor().ToString());

            if (licenseKey.Length > 0)
            {
                if (email.Length > 0)
                {
                    // Authorization using an account name/key
                    var account_auth = pdfix.GetAccountAuthorization();
                    if (account_auth.Authorize(email, licenseKey) == false)
                    {
                        throw new Exception("PDFix SDK Account Authorization failed");
                    }
                }
                else
                {
                    // Authorization using the activation key
                    var standard_auth = pdfix.GetStandardAuthorization();
                    if (!standard_auth.IsAuthorized() && !standard_auth.Activate(licenseKey))
                    {
                        throw new Exception("PDFix SDK Standard Authorization failed");
                    }
                }
            }

            pdfix.Destroy();
        }
    }
}