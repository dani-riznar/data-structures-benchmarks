``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  Job-PWOTSX : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=10  IterationCount=1  LaunchCount=1  
UnrollFactor=1  WarmupCount=10  

```
|           Method |      n |     Mean | Error |
|----------------- |------- |---------:|------:|
|   **HashListAccess** |   **1000** | **145.0 ns** |    **NA** |
| DictionaryAccess |   1000 | 240.0 ns |    NA |
|   **HashListAccess** |  **10000** | **230.0 ns** |    **NA** |
| DictionaryAccess |  10000 | 100.0 ns |    NA |
|   **HashListAccess** | **100000** | **140.0 ns** |    **NA** |
| DictionaryAccess | 100000 | 200.0 ns |    NA |
