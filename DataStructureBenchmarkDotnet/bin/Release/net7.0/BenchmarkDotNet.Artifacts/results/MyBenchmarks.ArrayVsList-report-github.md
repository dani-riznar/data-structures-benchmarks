``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  Job-QKIYXC : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=1000  IterationCount=1  LaunchCount=1  
UnrollFactor=1  WarmupCount=10  

```
|    Method |      n |             Mean | Error |
|---------- |------- |-----------------:|------:|
| **AArrayAdd** |   **1000** |    **37,545.250 ns** |    **NA** |
|  BListAdd |   1000 |     9,024.500 ns |    NA |
|  CListFor |   1000 |         1.650 ns |    NA |
| DArrayFor |   1000 |     2,390.100 ns |    NA |
| **AArrayAdd** |  **10000** |   **186,809.700 ns** |    **NA** |
|  BListAdd |  10000 |    50,899.400 ns |    NA |
|  CListFor |  10000 |       366.500 ns |    NA |
| DArrayFor |  10000 |     7,341.000 ns |    NA |
| **AArrayAdd** | **100000** | **1,434,809.700 ns** |    **NA** |
|  BListAdd | 100000 |   425,103.900 ns |    NA |
|  CListFor | 100000 |         2.200 ns |    NA |
| DArrayFor | 100000 |    50,340.200 ns |    NA |
