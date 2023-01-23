``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19044.2364/21H2/November2021Update)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|       Method |     Mean |     Error |    StdDev |
|------------- |---------:|----------:|----------:|
|      ListFor | 6.054 ms | 0.1195 ms | 0.2647 ms |
|     ArrayFor | 3.711 ms | 0.0731 ms | 0.0684 ms |
|  ListForEach | 4.485 ms | 0.0574 ms | 0.0480 ms |
| ArrayForEach | 3.281 ms | 0.0465 ms | 0.0412 ms |
