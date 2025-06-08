namespace Fydar.Deterministic.Numerics;

/// <summary>
/// Represents a vector with three fixed-point values.
/// </summary>
/// <seealso cref="FixedVector2D"/>
public readonly struct FixedVector3D
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
}
