``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-1035G1 CPU 1.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|  Method |     Mean |     Error |   StdDev | Allocated |
|-------- |---------:|----------:|---------:|----------:|
| Consume | 9.197 ms | 0.4564 ms | 1.287 ms |     94 KB |
