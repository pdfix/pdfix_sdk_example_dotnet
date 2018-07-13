////////////////////////////////////////////////////////////////////////////////////////////////////
// Initialization.cs
// Copyright (c) 2018 PDFix. All Rights Reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////

/*! 
\page CS_Samples C# Samples
- \subpage Initialization_cs
*/
/*! 
\page Initialization_cs Initialization Sample
// Example how to initialize PDFix SDK in c#.
\snippet /Initialization.cs Initialization_cs
*/

//\cond INTERNAL
//! [Initialization_cs]
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

            if (!pdfix.Authorize(email, licenseKey))
                throw new Exception(pdfix.GetError());

            if (!pdfix.IsAuthorized())
                throw new Exception("Pdfix Authorization fail");

            // ...

            pdfix.Destroy();
        }
    }
}
//! [Initialization_cs]
//\endcond
