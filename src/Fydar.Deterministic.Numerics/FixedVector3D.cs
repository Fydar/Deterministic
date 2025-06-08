using System;

namespace Fydar.Deterministic.Numerics;

/// <summary>
/// Represents a vector with three fixed-point values.
/// </summary>
/// <seealso cref="FixedVector2D"/>
public readonly struct FixedVector3D :
    IEquatable<FixedVector3D>
{
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
