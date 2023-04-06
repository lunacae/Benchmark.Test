``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-1035G1 CPU 1.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|            Method |     Mean |   Error |  StdDev | Rank | Allocated |
|------------------ |---------:|--------:|--------:|-----:|----------:|
| RestClientConsume | 111.0 ms | 3.17 ms | 9.25 ms |    1 |     67 KB |
| HttpClientConsume | 115.8 ms | 3.11 ms | 9.12 ms |    2 |     42 KB |
