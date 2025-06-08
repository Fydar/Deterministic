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

    /// <summary>
    /// <para>Represents the smallest positive <see cref="Fixed"/> value that is greater than <see cref="Zero"/>.</para>
    /// </summary>
    /// <value><c>0.00099</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static Fixed Epsilon { get; } = new(1L);

    /// <summary>
    /// <para>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, &#960;.</para>
    /// </summary>
    /// <value><c>3.14159</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static Fixed Pi { get; } = new(205887L);

    /// <summary>
    /// <para>Represents the number of radians in one turn, specified by the constant, &#964;.</para>
    /// </summary>
    /// <value><c>6.28317</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static Fixed Tau { get; } = new(411774L);

    private readonly long rawValue;

    internal Fixed(in long rawValue)
    {
        this.rawValue = rawValue;
    }
}
