``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-ICTCKG : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=5  IterationCount=3  LaunchCount=2  
RunStrategy=ColdStart  UnrollFactor=1  

```
| Method |     Mean |      Error |   StdDev |    Median |
|------- |---------:|-----------:|---------:|----------:|
| Sha256 | 571.4 μs | 1,737.6 μs | 619.6 μs | 218.99 μs |
|    Md5 | 566.3 μs | 2,221.0 μs | 792.0 μs |  79.23 μs |
