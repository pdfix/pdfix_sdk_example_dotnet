# PDFix SDK example .Net Framework and .Net Core
Example project demonstrating the capabilities of PDFix SDK written in C#
language.

## Description

For more information please visit [https://pdfix.net](https://pdfix.net).

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

From pdfix_sdk_exmple_dotnet dir:

### .Net Framework
 `./bin/Release/net48/example`  

### .Net Core
 `./bin/Release/netcoreapp3.1/example`  

## Have a question? Need help?
Let us know and we’ll get back to you. Write us to support@pdfix.net or fill the
[contact form](https://pdfix.net/support/).
