using BenchmarkDotNet.Running;

namespace Fydar.Deterministic.Numerics.Benchmarks;

internal class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<AbsBenchmark>();
    }
}
