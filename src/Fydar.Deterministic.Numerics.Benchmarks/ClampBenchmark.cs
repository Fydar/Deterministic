using BenchmarkDotNet.Attributes;
using System.Runtime.InteropServices;

namespace Fydar.Deterministic.Numerics.Benchmarks;

public class ClampBenchmark
{
    private const int N = 10000;

    private readonly Fixed[] valueA;
    private readonly Fixed[] valueB;

    public ClampBenchmark()
    {
        valueA = new Fixed[N];
        valueB = new Fixed[N];

        var span = MemoryMarshal.AsBytes<Fixed>(valueA);
        new Random(12).NextBytes(span);

        span = MemoryMarshal.AsBytes<Fixed>(valueB);
        new Random(12).NextBytes(span);
    }

    [Benchmark]
    public Fixed[] Clamp()
    {
        var result = new Fixed[N];
        for (int i = 0; i < N; i++)
        {
            result[i] = Fixed.Clamp(valueA[i], valueB[i], valueB[i] + 100000);
        }
        return result;
    }
}
