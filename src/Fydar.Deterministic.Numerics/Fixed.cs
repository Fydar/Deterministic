using System;
using System.Diagnostics;

namespace Fydar.Deterministic.Numerics;

/// <summary>
/// <para>Represents a deterministic fixed-point number.</para>
/// </summary>
/// <remarks>
/// <para>The <see cref="Fixed"/> value type represents a 64-bit number with values ranging <b>from</b> <c>-140,737,488,355,328.00000</c> <b>to</b> <c>-140,737,488,355,328.00000</c>.</para>
/// </remarks>
public readonly struct Fixed :
    IEquatable<Fixed>
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

    internal readonly long rawValue;

    internal Fixed(in long rawValue)
    {
        this.rawValue = rawValue;
    }

    /// <summary>
    /// <para>Returns a value indicating whether this instance is equal to a specified object.</para>
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns><c>true</c> if <paramref name="obj"/> is an instance of <see cref="Fixed"> and equals the value of this instance; otherwise, <c>false</c>.</returns>
    public override readonly bool Equals(object? obj)
    {
        return obj is Fixed other && Equals(other);
    }

    /// <summary>
    /// <para>Returns a value indicating whether this instance and a specified <see cref="Fixed"/> object represent the same value.</para>
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns><c>true</c> if <paramref name="obj"/> is equal to this instance; otherwise, <c>false</c>.</returns>
    public readonly bool Equals(Fixed obj)
    {
        return rawValue == obj.rawValue;
    }

    /// <summary>
    /// <para>Returns the hash code for this instance.</para>
    /// </summary>
    /// <returns>A 32-bit signed integer hash code.</returns>
    public override readonly int GetHashCode()
    {
        return 621480157 + rawValue.GetHashCode();
    }

    /// <summary>
    /// <para>Compares two values to determine equality.</para>
    /// </summary>
    /// <param name="left">The value to compare with <paramref name="right"/>.</param>
    /// <param name="right">The value to compare with <paramref name="left"/>.</param>
    /// <returns><c>true</c> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
    public static bool operator ==(Fixed left, Fixed right)
    {
        return left.rawValue == right.rawValue;
    }

    /// <summary>
    /// <para>Compares two values to determine inequality.</para>
    /// </summary>
    /// <param name="left">The value to compare with <paramref name="right"/>.</param>
    /// <param name="right">The value to compare with <paramref name="left"/>.</param>
    /// <returns><c>true</c> if <paramref name="left"/> is not equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
    public static bool operator !=(Fixed left, Fixed right)
    {
        return left.rawValue != right.rawValue;
    }
}
