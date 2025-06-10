using System.Runtime.CompilerServices;

namespace Fydar.Deterministic.Numerics.LUTGenerator.Internal;

internal static class GeneratorUtilities
{
    internal static void WriteToFile(FileInfo fileInfo, Action<Stream> generator)
    {
        if (fileInfo.Exists)
        {
            fileInfo.Delete();
        }
        using var fileStream = fileInfo.OpenWrite();
        generator?.Invoke(fileStream);
        fileStream.Flush();
    }
}
