using System;
using System.Diagnostics;

namespace Fydar.Deterministic.Numerics;

/// <summary>
/// Represents a vector with three fixed-point values.
/// </summary>
/// <seealso cref="FixedVector2D"/>
[DebuggerDisplay("{ToString(),nq}")]
public readonly struct FixedVector3D :
    IEquatable<FixedVector3D>,
    IFormattable
{
    /// <summary>
    /// <para>Represents a vector whose three components are equal to zero.</para>
    /// </summary>
    /// <value><c>(0, 0, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D Zero { get; } = new(0, 0, 0);

    /// <summary>
    /// <para>Represents a vector whose three components are equal to one.</para>
    /// </summary>
    /// <value><c>(1, 1, 1)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D One { get; } = new(1, 1, 1);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to one and Y component is equal to zero, and Z component is equal to zero.</para>
    /// </summary>
    /// <value><c>(1, 0, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D Right { get; } = new(1, 0, 0);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to negative one and Y component is equal to zero, and Z component is equal to zero.</para>
    /// </summary>
    /// <value><c>(1, 0, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D Left { get; } = new(-1, 0, 0);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to zero, Y component is equal to one, and Z component is equal to zero.</para>
    /// </summary>
    /// <value><c>(0, 1, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D Up { get; } = new(0, 1, 0);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to zero and Y component is equal to zero, and Z component is equal to zero.</para>
    /// </summary>
    /// <value><c>(0, -1, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D Down { get; } = new(0, -1, 0);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to zero and Y component is equal to zero, and Z component is equal to one.</para>
    /// </summary>
    /// <value><c>(0, -1, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D Forward { get; } = new(0, 0, 1);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to zero and Y component is equal to zero, and Z component is equal to negative one.</para>
    /// </summary>
    /// <value><c>(0, -1, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector3D Back { get; } = new(0, 0, -1);

    /// <summary>
    /// <para>The X component of the vector.</para>
    /// </summary>
    public readonly Fixed X { get; }

    /// <summary>
    /// <para>The Y component of the vector.</para>
    /// </summary>
    public readonly Fixed Y { get; }

    /// <summary>
    /// <para>The Z component of the vector.</para>
    /// </summary>
    public readonly Fixed Z { get; }

    /// <summary>
    /// Creates a vector whose elements have the specified values.
    /// </summary>
    /// <param name="x">The value to assign to the <see cref="X"/> property.</param>
    /// <param name="y">The value to assign to the <see cref="Y"/> property.</param>
    /// <param name="z">The value to assign to the <see cref="Z"/> property.</param>
    public FixedVector3D(in Fixed x, in Fixed y, in Fixed z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    /// <para>Returns a value indicating whether this instance is equal to a specified object.</para>
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns><c>true</c> if <paramref name="obj"/> is an instance of <see cref="FixedVector3D"> and equals the value of this instance; otherwise, <c>false</c>.</returns>
    public override readonly bool Equals(object? obj)
    {
        return obj is FixedVector3D other && Equals(other);
    }

    /// <summary>
    /// <para>Returns a value indicating whether this instance and a specified <see cref="FixedVector3D"/> object represent the same value.</para>
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns><c>true</c> if <paramref name="obj"/> is equal to this instance; otherwise, <c>false</c>.</returns>
    public readonly bool Equals(FixedVector3D obj)
    {
        return this == obj;
    }

    /// <summary>
    /// <para>Returns the hash code for this instance.</para>
    /// </summary>
    /// <returns>A 32-bit signed integer hash code.</returns>
    public override readonly int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    /// <summary>
    /// <para>Converts the numeric value of this instance to its equivalent string representation.</para>
    /// </summary>
    /// <returns>The string representation of the value of this instance.</returns>
    public override readonly string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }

    /// <summary>
    /// <para>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</para>
    /// </summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <returns>The string representation of the value of this instance as specified by <paramref name="provider"/>.</returns>
    public readonly string ToString(IFormatProvider provider)
    {
        return $"({X.ToString(provider)}, {Y.ToString(provider)}, {Z.ToString(provider)})";
    }

    /// <summary>
    /// <para>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</para>
    /// </summary>
    /// <param name="format">A numeric format string.</param>
    /// <returns>The string representation of the value of this instance as specified by <paramref name="format"/>.</returns>
    /// <exception cref="FormatException"><paramref name="format"/> is invalid.</exception>
    public readonly string ToString(string format)
    {
        return $"({X.ToString(format)}, {Y.ToString(format)}, {Z.ToString(format)})";
    }

    /// <summary>
    /// <para>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</para>
    /// </summary>
    /// <param name="format">A numeric format string.</param>
    /// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
    /// <returns>The string representation of the value of this instance as specified by <paramref name="format"/> and <paramref name="provider"/>.</returns>
    /// <exception cref="FormatException"><paramref name="format"/> is invalid.</exception>
    public readonly string ToString(string format, IFormatProvider provider)
    {
        return $"({X.ToString(format, provider)}, {Y.ToString(format, provider)}, {Z.ToString(format, provider)})";
    }

    /// <summary>
    /// <para>Compares two values to determine equality.</para>
    /// </summary>
    /// <param name="left">The value to compare with <paramref name="right"/>.</param>
    /// <param name="right">The value to compare with <paramref name="left"/>.</param>
    /// <returns><c>true</c> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
    public static bool operator ==(FixedVector3D left, FixedVector3D right)
    {
        return left.X.rawValue == right.X.rawValue
            && left.Y.rawValue == right.Y.rawValue
            && left.Z.rawValue == right.Z.rawValue;
    }

    /// <summary>
    /// <para>Compares two values to determine inequality.</para>
    /// </summary>
    /// <param name="left">The value to compare with <paramref name="right"/>.</param>
    /// <param name="right">The value to compare with <paramref name="left"/>.</param>
    /// <returns><c>true</c> if <paramref name="left"/> is not equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
    public static bool operator !=(FixedVector3D left, FixedVector3D right)
    {
        return left.X.rawValue != right.X.rawValue
            || left.Y.rawValue != right.Y.rawValue
            || left.Z.rawValue != right.Z.rawValue;
    }
}
