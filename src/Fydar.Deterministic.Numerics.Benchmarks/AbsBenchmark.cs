using BenchmarkDotNet.Attributes;
using System.Runtime.InteropServices;

namespace Fydar.Deterministic.Numerics.Benchmarks;

public class AbsBenchmark
{
    private const int N = 100000;

    private readonly Fixed[] valueA;

    public AbsBenchmark()
    {
        valueA = new Fixed[N];

        var span = MemoryMarshal.AsBytes<Fixed>(valueA);
        new Random(12).NextBytes(span);
    }

    [Benchmark]
    public Fixed[] Abs()
    {
        var result = new Fixed[N];
        for (int i = 0; i < N; i++)
        {
            result[i] = Fixed.Abs(valueA[i]);
        }
        return result;
    }
}
