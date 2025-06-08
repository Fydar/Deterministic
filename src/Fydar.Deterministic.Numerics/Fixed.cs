using System.Diagnostics;

namespace Fydar.Deterministic.Numerics;

/// <summary>
/// <para>Represents a deterministic fixed-point number.</para>
/// </summary>
/// <remarks>
/// <para>The <see cref="Fixed"/> value type represents a 64-bit number with values ranging <b>from</b> <c>-140,737,488,355,328.00000</c> <b>to</b> <c>-140,737,488,355,328.00000</c>.</para>
/// </remarks>
public readonly struct Fixed
{
    /// <summary>
    /// <para>Represents a zero value.</para>
    /// </summary>
    /// <value><c>0</c></value>
    /// <seealso cref="MinValue"/>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static Fixed Zero { get; } = new(0L);

    /// <summary>
    /// <para>Represents the smallest possible value of <see cref="Fixed"/>.</para>
    /// </summary>
    /// <value><c>-140,737,488,355,328.00000</c></value>
    /// <seealso cref="MaxValue"/>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static Fixed MinValue { get; } = new(long.MinValue);

    /// <summary>
    /// <para>Represents the largest possible value of <see cref="Fixed"/>.</para>
    /// </summary>
    /// <value><c>140,737,488,355,328.00000</c></value>
    /// <seealso cref="MinValue"/>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static Fixed MaxValue { get; } = new(long.MaxValue);

    private readonly long rawValue;

    internal Fixed(in long rawValue)
    {
        this.rawValue = rawValue;
    }
}
