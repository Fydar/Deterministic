using Fydar.Deterministic.Numerics.LUTGenerator.Internal;

namespace Fydar.Deterministic.Numerics.LUTGenerator;

internal class Program
{
    private static void Main(string[] args)
    {
        SineLookupTableGenerator.Generate("LUT/Sin.bin");
        TanLookupTableGenerator.Generate("LUT/Tan.bin");
        ArcSineLookupTableGenerator.Generate("LUT/Asin.bin");
    }
}
