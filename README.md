# PDFix SDK example .NET

Example project demonstrating the capabilities of PDFix SDK written in C#.

## Description

For more information please visit [https://pdfix.net](https://pdfix.net).

## Code integration

```cs
using System;
using PDFixSDK.Pdfix;

static void Main()
{
    // Typical pattern: one Pdfix per process. Dispose()/Destroy() release native
    // objects for this session; they do not unload pdf.dll from the process.
    using (var pdfix = new Pdfix())
    {
        if (pdfix == null)
            throw new Exception("Pdfix initialization fail");

        using (var doc = pdfix.OpenDoc("input.pdf", ""))
        {
            // your code ...
        }
        // Exiting the pdfix using block calls Dispose() → Destroy() on the root
        // Pdfix instance. The native library remains loaded until process exit.
    }
}
```

Owned SDK objects implement `IDisposable`. Prefer `using` — `Dispose()` calls the correct native cleanup (`Close`, `Destroy`, or `Release`) for each type. See the [PDFix.SDK NuGet readme](https://www.nuget.org/packages/PDFix.SDK/) for callback pinning and handle-map behavior (9.1+).

**Process lifetime:** `Pdfix.Destroy()` (or `Dispose()` on `Pdfix`) tears down open documents and native SDK state for the current session. It does **not** unload `pdf.dll` / `libpdf.so` / `libpdf.dylib` from the process. The native library stays loaded until the host process exits. Plan for **one SDK init per process** in long-running services, plugins, or app domains — not repeated full unload/reload cycles. Short demos and CLI-style apps match this model; `Release()` on borrowed handles (for example pages from `AcquirePage()`) only drops that borrow and is unrelated to unloading the DLL.

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

To target a different .NET version, run restore and build with `TargetFramework` override:

```bash
# .NET 8.0
dotnet restore pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net8.0
dotnet build pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net8.0 --no-restore

# .NET 10.0
dotnet restore pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net10.0
dotnet build pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net10.0 --no-restore

# .NET Framework 4.8 (Windows only)
dotnet restore pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net48
dotnet build pdfix_sdk_example_dotnet.csproj -p:TargetFramework=net48 --no-restore
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
