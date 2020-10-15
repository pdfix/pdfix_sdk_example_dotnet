# PDFix SDK example .Net Framework and .Net Core
Example project demonstrating the capabilities of PDFix SDK written in C#
language.

## Description

Our PDF library analyses the key components of the PDF and make it easily
available for you. With the ability to sign PDF's with both eSignatures and
Digital Signatures we have your digital transactions covered.  
We turn your simple PDF into a fully responsive document with semantic content
and logical reading order built for you. You can search texts, you can save all
images, you can export table values into your database or you can use exported
elements for conversions – to HTML, JSON, Word, Excel, etc.  
PDF form filling using AcroForm is an important part of many workflows. It
allows data entry directly on print ready media with ability to import, export,
submit or email data for further processing.  
Try our autotag feature that recognises all important structures in your
documents like tables, lists, reading order.

## Code integration
```cs
using PDFixSDK.Pdfix;

static void Main()
    {
        Pdfix pdfix = new Pdfix();
        if (pdfix == null)
            throw new Exception("Pdfix initialization fail");
            
        // your code ...
        
        pdfix.Destroy();
    }
```

## Prerequisites

### Windows
- MS Visual Studio 2017 or latest
- PDFix SDK Nuget packages [Download from here](https://www.nuget.org/packages/PDFix.SDK/) or from Nuget package manager in Visual Studio

## Download
Clone the repository:  
`git clone https://github.com/pdfix/pdfix_sdk_example_dotnet`  

...or download as .zip:  
[Download as .zip](https://github.com/pdfix/pdfix_sdk_example_dotnet/archive/master.zip)

## Run the example

From pdfix_sdk_exmple_net dir:

### .Net Framework
 `./bin/Release/net48/example`  

### .Net Core
 `./bin/Release/netcoreapp3.1/example`  

## Documentation
For complete SDK documentation see the [PDFix website](https://pdfix.net).

## Have a question? Need help?
Let us know and we’ll get back to you. Write us to support@pdfix.net or fill the
[contact form](https://pdfix.net/support/).
