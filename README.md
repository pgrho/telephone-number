# Shipwreck.TelephoneNumber

.NET Telephone Number formatter.

## Supported Regions

|Region|Class|Reference|
|-|-|-|
|Japan|`JapaneseTelephoneNumber`|[soumu.go.jp](https://www.soumu.go.jp/main_sosiki/joho_tsusin/top/tel_number/shigai_list.html)|

## Usage

- [NuGet](https://www.nuget.org/packages/Shipwreck.TelephoneNumber/)

```csharp
using Shipwreck.TelephoneNumber;

Console.WriteLine(JapaneseTelephoneNumber.Format("0312345678"));
// -> 03-1234-5678

Console.WriteLine(JapaneseTelephoneNumber.Sanitize("03-1234-5678"));
// -> 0312345678
```