# PDFix SDK example .NET

Example project demonstrating the capabilities of PDFix SDK written in C#.

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

- [.NET SDK 6.0](https://dotnet.microsoft.com/download) or later
- PDFix SDK NuGet package ([NuGet Gallery](https://www.nuget.org/packages/PDFix.SDK/))

## Download

Clone the repository:

```bash
git clone https://github.com/pdfix/pdfix_sdk_example_dotnet
```

## Build

The project defaults to `net6.0`. Any .NET SDK 6.0 or later can build it:

```bash
dotnet build pdfix_sdk_example_dotnet.csproj
```

To target a different .NET version, override `TargetFramework`:

```bash
# .NET 8.0
dotnet build pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net8.0

# .NET 10.0
dotnet build pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net10.0

# .NET Framework 4.8 (Windows only)
dotnet build pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net48
```

## Run the example

After building, run the compiled binary from the output directory:

```bash
# Default (net6.0)
./bin/Debug/net6.0/example

# If you built for a different target
./bin/Debug/net8.0/example
./bin/Debug/net10.0/example
./bin/Debug/net48/example        # Windows only
```

## Have a question? Need help?

Let us know and we'll get back to you. Write us to support@pdfix.net or fill the
[contact form](https://pdfix.net/support/).
