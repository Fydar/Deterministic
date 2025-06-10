using System.Runtime.InteropServices;

namespace Fydar.Deterministic.Numerics.Internal;

internal static class MathEngine
{
    internal static readonly ushort[] sin;
    internal static readonly Fixed[] tan;

    static MathEngine()
    {
        sin = LoadUShorts("Fydar.Deterministic.Numerics.LUT.Sin.bin");
        tan = Load("Fydar.Deterministic.Numerics.LUT.Tan.bin");
    }

    private static ushort[] LoadUShorts(string resourceName)
    {
        var assembly = typeof(MathEngine).Assembly;
        var stream = assembly.GetManifestResourceStream(resourceName);

        var data = new ushort[stream.Length / 2];
        stream.Read(MemoryMarshal.Cast<ushort, byte>(data));
        return data;
    }

    private static Fixed[] Load(string resourceName)
    {
        var assembly = typeof(MathEngine).Assembly;
        var stream = assembly.GetManifestResourceStream(resourceName);

        var data = new Fixed[stream.Length / 8];
        stream.Read(MemoryMarshal.Cast<Fixed, byte>(data));
        return data;
    }
}
