```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 5600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| TerminaComString | 608.0679 ns | 5.7029 ns | 5.3345 ns |
| TerminaComChar   |   0.2807 ns | 0.0067 ns | 0.0063 ns |
