## Async Await

## Run

```
dotnet run --project FSharp/FSharpAsyncAwait/FSharpAsyncAwait.fsproj
dotnet run --project CSharp/CSharpAsyncAwait/CSharpAsyncAwait.csproj
ts-node ./TypeScript/App.ts
```


```
       Method | Count |        Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------- |------ |------------:|----------:|----------:|-------:|----------:|
         Span |    10 |  10.8352 ns | 0.1354 ns | 0.1266 ns |      - |       0 B |
 ArraySegment |    10 |   0.8484 ns | 0.0282 ns | 0.0250 ns |      - |       0 B |
         Take |    10 |  93.4998 ns | 0.4059 ns | 0.3390 ns | 0.0304 |      96 B |
         Span |   100 |  11.1367 ns | 0.2452 ns | 0.3012 ns |      - |       0 B |
 ArraySegment |   100 |   0.8769 ns | 0.0474 ns | 0.0600 ns |      - |       0 B |
         Take |   100 | 101.5808 ns | 2.0452 ns | 3.7910 ns | 0.0304 |      96 B |
```