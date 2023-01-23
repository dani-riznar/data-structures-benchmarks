``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  Job-AFNWQQ : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=10  IterationCount=1  LaunchCount=1  
UnrollFactor=1  WarmupCount=10  

```
|         Method |      n |          Mean | Error |
|--------------- |------- |--------------:|------:|
|  **ListAddRemove** |   **1000** |      **51.29 μs** |    **NA** |
| QueueAddRemove |   1000 |      22.26 μs |    NA |
|  **ListAddRemove** |  **10000** |   **3,627.67 μs** |    **NA** |
| QueueAddRemove |  10000 |     128.23 μs |    NA |
|  **ListAddRemove** | **100000** | **359,936.14 μs** |    **NA** |
| QueueAddRemove | 100000 |   1,121.25 μs |    NA |
