namespace Fydar.Deterministic.Numerics.UnitTests;

/// <summary>
/// Unit tests for the <see cref="FixedVector3D"/> type.
/// </summary>
public class FixedVector3DTests
{
    [Fact]
    public void Add()
    {
        Assert.Equal(new FixedVector3D(1, 1, 1), new FixedVector3D(1, 1, 1) + new FixedVector3D(0, 0, 0));
        Assert.Equal(new FixedVector3D(2, 2, 2), new FixedVector3D(1, 1, 1) + new FixedVector3D(1, 1, 1));
        Assert.Equal(new FixedVector3D(3, 3, 3), new FixedVector3D(1, 1, 1) + new FixedVector3D(2, 2, 2));
    }

    [Fact]
    public void Subtract()
    {
        Assert.Equal(new FixedVector3D(0, 0, 0), new FixedVector3D(1, 1, 1) - new FixedVector3D(1, 1, 1));
        Assert.Equal(new FixedVector3D(-9, -9, -9), new FixedVector3D(1, 1, 1) - new FixedVector3D(10, 10, 10));
    }

    [Fact]
    public void Multiply()
    {
        Assert.Equal(new FixedVector3D(2, 3, 3), new FixedVector3D(1, 1, 1) * new FixedVector3D(2, 3, 3));
        Assert.Equal(new FixedVector3D(4, 6, 6), new FixedVector3D(2, 2, 2) * new FixedVector3D(2, 3, 3));
    }

    [Fact]
    public void Divide()
    {
        Assert.Equal(new FixedVector3D(4, 3, 3), new FixedVector3D(12, 12, 12) / new FixedVector3D(3, 4, 4));
        Assert.Equal(new FixedVector3D(6, 4, 4), new FixedVector3D(48, 32, 32) / new FixedVector3D(8, 8, 8));
    }
}
