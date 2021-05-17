using BenchmarkDotNet.Running;

namespace dotnet_json_benchmark_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<JsonBenchmarks>();
        }
    }
}
