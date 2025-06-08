using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Fydar.Deterministic.Numerics;

/// <summary>
/// <para>Represents a deterministic fixed-point number.</para>
/// </summary>
/// <remarks>
/// <para>The <see cref="Fixed"/> value type represents a 64-bit number with values ranging <b>from</b> <c>-140,737,488,355,328.00000</c> <b>to</b> <c>-140,737,488,355,328.00000</c>.</para>
/// </remarks>
[DebuggerDisplay("{ToString(),nq}")]
public readonly struct Fixed :
    IEquatable<Fixed>,
    IFormattable
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
    /// <para>Converts the numeric value of this instance to its equivalent string representation.</para>
    /// </summary>
    /// <returns>The string representation of the value of this instance.</returns>
    public override readonly string ToString()
    {
        return $"{(double)this:###,##0.00000}";
    }

    /// <summary>
    /// <para>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</para>
    /// </summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>The string representation of the value of this instance as specified by <paramref name="provider"/>.</returns>
    public readonly string ToString(IFormatProvider provider)
    {
        return ((double)this).ToString(provider);
    }

    /// <summary>
    /// <para>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</para>
    /// </summary>
    /// <param name="format">A numeric format string.</param>
    /// <returns>The string representation of the value of this instance as specified by <paramref name="format"/>.</returns>
    /// <exception cref="FormatException"><paramref name="format"/> is invalid.</exception>
    public readonly string ToString(string format)
    {
        if (string.IsNullOrEmpty(format))
        {
            format = "###,##0.00000";
        }
        return ((double)this).ToString(format);
    }

    /// <summary>
    /// <para>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</para>
    /// </summary>
    /// <param name="format">A numeric format string.</param>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>The string representation of the value of this instance as specified by <paramref name="format"/> and <paramref name="provider"/>.</returns>
    /// <exception cref="FormatException"><paramref name="format"/> is invalid.</exception>
    public readonly string ToString(string format, IFormatProvider provider)
    {
        if (string.IsNullOrEmpty(format))
        {
            format = "###,##0.00000";
        }
        return ((double)this).ToString(format, provider);
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

    /// <summary>
    /// <para>Explicitly converts <see cref="float"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Fixed(in float value)
    {
        return new Fixed((long)(value * 65536.0f));
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="double"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Fixed(in double value)
    {
        return new Fixed((long)(value * 65536.0));
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="decimal"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Fixed(in decimal value)
    {
        return new Fixed((long)(value * 65536.0m));
    }

    /// <summary>
    /// <para>Implicitly converts <see cref="byte"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to implicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Fixed(in byte value)
    {
        return new Fixed((long)value << 16);
    }

    /// <summary>
    /// <para>Implicitly converts <see cref="sbyte"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to implicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Fixed(in sbyte value)
    {
        return new Fixed((long)value << 16);
    }

    /// <summary>
    /// <para>Implicitly converts <see cref="int"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to implicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Fixed(in int value)
    {
        return new Fixed((long)value << 16);
    }

    /// <summary>
    /// <para>Implicitly converts <see cref="uint"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to implicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Fixed(in uint value)
    {
        return new Fixed((long)value << 16);
    }

    /// <summary>
    /// <para>Implicitly converts <see cref="long"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to implicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Fixed(in long value)
    {
        return new Fixed(value << 16);
    }

    /// <summary>
    /// <para>Implicitly converts <see cref="ulong"/> values to <see cref="Fixed"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to implicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Fixed(in ulong value)
    {
        return new Fixed((long)value << 16);
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="byte"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator byte(in Fixed value)
    {
        return (byte)(value.rawValue >> 16);
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="sbyte"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator sbyte(in Fixed value)
    {
        return (sbyte)(value.rawValue >> 16);
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="int"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator int(in Fixed value)
    {
        return (int)(value.rawValue >> 16);
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="uint"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator uint(in Fixed value)
    {
        return (uint)(value.rawValue >> 16);
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="long"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator long(in Fixed value)
    {
        return value.rawValue >> 16;
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="ulong"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator ulong(in Fixed value)
    {
        return (ulong)(value.rawValue >> 16);
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="float"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator float(in Fixed value)
    {
        return value.rawValue / 65536.0f;
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="double"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator double(in Fixed value)
    {
        return value.rawValue / 65536.0;
    }

    /// <summary>
    /// <para>Explicitly converts <see cref="Fixed"/> values to <see cref="decimal"/> numerics.</para>
    /// </summary>
    /// <param name="value">The value to explicitly convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator decimal(in Fixed value)
    {
        return value.rawValue / 65536.0m;
    }
}
