using System.Runtime.CompilerServices;

namespace Fydar.Deterministic.Numerics.LUTGenerator.Internal;

internal class TanLookupTableGenerator
{
    public static void Generate(string filePath)
    {
        var fileInfo = new FileInfo(filePath);

        fileInfo.Directory?.Create();

        GeneratorUtilities.WriteToFile(fileInfo, stream => WriteOperationRange(stream, Math.Tan, 0, Fixed.Pi / 2, Fixed.Epsilon));
    }

    internal static void WriteOperationRange(Stream stream, Func<double, double> operation, Fixed min, Fixed max, Fixed increment)
    {
        var binaryWriter = new BinaryWriter(stream);

        long minCast = Unsafe.As<Fixed, long>(ref min);
        long maxCast = Unsafe.As<Fixed, long>(ref max);
        long incCast = Unsafe.As<Fixed, long>(ref increment);

        for (long i = minCast; i <= maxCast; i += incCast)
        {
            var value = (Fixed)operation((double)Unsafe.As<long, Fixed>(ref i));

            long writeValue = Unsafe.As<Fixed, long>(ref value);
            binaryWriter.Write(writeValue);
        }
        binaryWriter.Flush();
    }
}
