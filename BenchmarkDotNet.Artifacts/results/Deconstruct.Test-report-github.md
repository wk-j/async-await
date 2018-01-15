``` ini

BenchmarkDotNet=v0.10.12, OS=macOS 10.13.2 (17C88) [Darwin 17.3.0]
Intel Core i5-7600K CPU 3.80GHz (Kaby Lake), 1 CPU, 4 logical cores and 4 physical cores
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.0.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.0.0), 64bit RyuJIT


```
|       Method | Count |        Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------------- |------ |------------:|----------:|----------:|-------:|----------:|
|         **Span** |    **10** |  **10.8352 ns** | **0.1354 ns** | **0.1266 ns** |      **-** |       **0 B** |
| ArraySegment |    10 |   0.8484 ns | 0.0282 ns | 0.0250 ns |      - |       0 B |
|         Take |    10 |  93.4998 ns | 0.4059 ns | 0.3390 ns | 0.0304 |      96 B |
|         **Span** |   **100** |  **11.1367 ns** | **0.2452 ns** | **0.3012 ns** |      **-** |       **0 B** |
| ArraySegment |   100 |   0.8769 ns | 0.0474 ns | 0.0600 ns |      - |       0 B |
|         Take |   100 | 101.5808 ns | 2.0452 ns | 3.7910 ns | 0.0304 |      96 B |
