using System;
using System.Diagnostics;

namespace Fydar.Deterministic.Numerics;

/// <summary>
/// Represents a vector with two fixed-point values.
/// </summary>
/// <seealso cref="FixedVector3D"/>
public readonly struct FixedVector2D :
    IEquatable<FixedVector2D>
{
    /// <summary>
    /// <para>Represents a vector whose two components are equal to zero.</para>
    /// </summary>
    /// <value><c>(0, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector2D Zero { get; } = new(0, 0);

    /// <summary>
    /// <para>Represents a vector whose two components are equal to one.</para>
    /// </summary>
    /// <value><c>(1, 1)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector2D One { get; } = new(1, 1);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to one and Y component is equal to zero.</para>
    /// </summary>
    /// <value><c>(1, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector2D Right { get; } = new(1, 0);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to negative one and Y component is equal to zero.</para>
    /// </summary>
    /// <value><c>(1, 0)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector2D Left { get; } = new(-1, 0);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to zero and Y component is equal to one.</para>
    /// </summary>
    /// <value><c>(0, 1)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector2D Up { get; } = new(0, 1);

    /// <summary>
    /// <para>Represents a vector whose X component is equal to zero and Y component is equal to negative one.</para>
    /// </summary>
    /// <value><c>(0, -1)</c></value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static FixedVector2D Down { get; } = new(0, -1);

    /// <summary>
    /// <para>The X component of the vector.</para>
    /// </summary>
    public readonly Fixed X { get; }

    /// <summary>
    /// <para>The Y component of the vector.</para>
    /// </summary>
    public readonly Fixed Y { get; }

    /// <summary>
    /// Creates a vector whose elements have the specified values.
    /// </summary>
    /// <param name="x">The value to assign to the <see cref="X"/> property.</param>
    /// <param name="y">The value to assign to the <see cref="Y"/> property.</param>
    public FixedVector2D(in Fixed x, in Fixed y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// <para>Returns a value indicating whether this instance is equal to a specified object.</para>
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns><c>true</c> if <paramref name="obj"/> is an instance of <see cref="FixedVector2D"> and equals the value of this instance; otherwise, <c>false</c>.</returns>
    public override readonly bool Equals(object? obj)
    {
        return obj is FixedVector2D other && Equals(other);
    }

    /// <summary>
    /// <para>Returns a value indicating whether this instance and a specified <see cref="FixedVector2D"/> object represent the same value.</para>
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns><c>true</c> if <paramref name="obj"/> is equal to this instance; otherwise, <c>false</c>.</returns>
    public readonly bool Equals(FixedVector2D obj)
    {
        return this == obj;
    }

    /// <summary>
    /// <para>Returns the hash code for this instance.</para>
    /// </summary>
    /// <returns>A 32-bit signed integer hash code.</returns>
    public override readonly int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    /// <summary>
    /// <para>Compares two values to determine equality.</para>
    /// </summary>
    /// <param name="left">The value to compare with <paramref name="right"/>.</param>
    /// <param name="right">The value to compare with <paramref name="left"/>.</param>
    /// <returns><c>true</c> if <paramref name="left"/> is equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
    public static bool operator ==(FixedVector2D left, FixedVector2D right)
    {
        return left.X.rawValue == right.X.rawValue
            && left.Y.rawValue == right.Y.rawValue;
    }

    /// <summary>
    /// <para>Compares two values to determine inequality.</para>
    /// </summary>
    /// <param name="left">The value to compare with <paramref name="right"/>.</param>
    /// <param name="right">The value to compare with <paramref name="left"/>.</param>
    /// <returns><c>true</c> if <paramref name="left"/> is not equal to <paramref name="right"/>; otherwise, <c>false</c>.</returns>
    public static bool operator !=(FixedVector2D left, FixedVector2D right)
    {
        return left.X.rawValue != right.X.rawValue
            || left.Y.rawValue != right.Y.rawValue;
    }
}
