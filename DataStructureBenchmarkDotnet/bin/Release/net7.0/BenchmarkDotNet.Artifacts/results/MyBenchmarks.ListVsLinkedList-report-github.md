``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  Job-VXZFZY : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=1000  IterationCount=1  LaunchCount=1  
UnrollFactor=1  WarmupCount=10  

```
|             Method |      n |         Mean | Error |
|------------------- |------- |-------------:|------:|
|        **ListPrepend** |   **1000** |    **121.45 ns** |    **NA** |
|  LinkedListPrepend |   1000 |     22.20 ns |    NA |
|         ListInsert |   1000 |     70.80 ns |    NA |
|   LinkedListInsert |   1000 |     60.50 ns |    NA |
|       ListRemoveAt |   1000 |     36.60 ns |    NA |
| LinkedListRemoveAt |   1000 |     13.80 ns |    NA |
|        **ListPrepend** |  **10000** |    **863.90 ns** |    **NA** |
|  LinkedListPrepend |  10000 |     21.80 ns |    NA |
|         ListInsert |  10000 |    350.50 ns |    NA |
|   LinkedListInsert |  10000 |     22.90 ns |    NA |
|       ListRemoveAt |  10000 |    553.90 ns |    NA |
| LinkedListRemoveAt |  10000 |     21.55 ns |    NA |
|        **ListPrepend** | **100000** | **11,614.30 ns** |    **NA** |
|  LinkedListPrepend | 100000 |     69.90 ns |    NA |
|         ListInsert | 100000 |  5,777.20 ns |    NA |
|   LinkedListInsert | 100000 |     54.70 ns |    NA |
|       ListRemoveAt | 100000 |  8,653.00 ns |    NA |
| LinkedListRemoveAt | 100000 |     56.20 ns |    NA |
