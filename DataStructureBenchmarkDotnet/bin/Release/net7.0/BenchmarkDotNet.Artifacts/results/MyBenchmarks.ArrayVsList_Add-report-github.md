``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  Job-LMVNOK : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=1000  IterationCount=1  LaunchCount=1  
UnrollFactor=1  WarmupCount=10  

```
|         Method |      n |         Mean | Error |
|--------------- |------- |-------------:|------:|
|       **ArrayAdd** |   **1000** |     **2.899 μs** |    **NA** |
| ArrayAddConcat |   1000 |    39.222 μs |    NA |
|        ListAdd |   1000 |    18.953 μs |    NA |
|       **ArrayAdd** |  **10000** |     **8.328 μs** |    **NA** |
| ArrayAddConcat |  10000 |   197.643 μs |    NA |
|        ListAdd |  10000 |    68.189 μs |    NA |
|       **ArrayAdd** | **100000** |    **55.240 μs** |    **NA** |
| ArrayAddConcat | 100000 | 1,505.233 μs |    NA |
|        ListAdd | 100000 |   402.551 μs |    NA |
