``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  Job-HYVVUA : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=10  IterationCount=1  LaunchCount=1  
UnrollFactor=1  WarmupCount=10  

```
|         Method |      n |           Mean | Error |
|--------------- |------- |---------------:|------:|
|  **ListAddRemove** |   **1000** |      **36.630 μs** |    **NA** |
| StackAddRemove |   1000 |       8.240 μs |    NA |
|  **ListAddRemove** |  **10000** |   **2,184.180 μs** |    **NA** |
| StackAddRemove |  10000 |      53.430 μs |    NA |
|  **ListAddRemove** | **100000** | **345,125.320 μs** |    **NA** |
| StackAddRemove | 100000 |     545.890 μs |    NA |
