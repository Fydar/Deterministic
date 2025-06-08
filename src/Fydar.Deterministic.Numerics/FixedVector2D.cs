namespace Fydar.Deterministic.Numerics;

/// <summary>
/// Represents a vector with two fixed-point values.
/// </summary>
/// <seealso cref="FixedVector3D"/>
public readonly struct FixedVector2D
{
    /// <summary>
    /// <para>The X component of the vector.</para>
    /// </summary>
    public readonly Fixed X { get; }

    /// <summary>
    /// <para>The Y component of the vector.</para>
    /// </summary>
    public readonly Fixed Y { get; }
}
