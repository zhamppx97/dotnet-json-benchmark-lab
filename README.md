# dotnet-json-benchmark-lab
dotnet-json-benchmark-lab

## Working with NewtonsoftJson VS System.Text.Json
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT


```
|                          Method |             Mean |            Error |            StdDev |      Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
|-------------------------------- |-----------------:|-----------------:|------------------:|-----------:|----------:|----------:|------------:|
| NewtonsoftJsonDeserializeObject | 986,830,033.3 ns | 61,518,048.75 ns | 180,421,787.82 ns | 12000.0000 | 4000.0000 |         - | 104069984 B |
| SystemTextJsonDeserializeObject | 652,661,360.4 ns | 50,374,250.53 ns | 145,341,230.63 ns |  2000.0000 | 2000.0000 | 2000.0000 |  24231840 B |
|   NewtonsoftJsonSerializeObject |         329.7 ns |         17.28 ns |          50.40 ns |     0.5581 |         - |         - |      1168 B |
|   SystemTextJsonSerializeObject |         299.0 ns |         17.96 ns |          52.97 ns |     0.0877 |         - |         - |       184 B |
