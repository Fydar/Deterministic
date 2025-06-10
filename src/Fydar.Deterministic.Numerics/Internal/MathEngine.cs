using System.Runtime.InteropServices;

namespace Fydar.Deterministic.Numerics.Internal;

internal static class MathEngine
{
    internal static readonly ushort[] sin;

    static MathEngine()
    {
        sin = LoadUShorts("Fydar.Deterministic.Numerics.LUT.Sin.bin");
    }

    private static ushort[] LoadUShorts(string resourceName)
    {
        var assembly = typeof(MathEngine).Assembly;
        var stream = assembly.GetManifestResourceStream(resourceName);

        var data = new ushort[stream.Length / 2];
        stream.Read(MemoryMarshal.Cast<ushort, byte>(data));
        return data;
    }
}
