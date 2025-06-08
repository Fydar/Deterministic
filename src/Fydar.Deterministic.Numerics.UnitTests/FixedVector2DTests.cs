namespace Fydar.Deterministic.Numerics.UnitTests;

/// <summary>
/// Unit tests for the <see cref="FixedVector2D"/> type.
/// </summary>
public class FixedVector2DTests
{
    [Fact]
    public void Add()
    {
        Assert.Equal(new FixedVector2D(1, 1), new FixedVector2D(1, 1) + new FixedVector2D(0, 0));
        Assert.Equal(new FixedVector2D(2, 2), new FixedVector2D(1, 1) + new FixedVector2D(1, 1));
        Assert.Equal(new FixedVector2D(3, 3), new FixedVector2D(1, 1) + new FixedVector2D(2, 2));
    }

    [Fact]
    public void Subtract()
    {
        Assert.Equal(new FixedVector2D(0, 0), new FixedVector2D(1, 1) - new FixedVector2D(1, 1));
        Assert.Equal(new FixedVector2D(-9, -9), new FixedVector2D(1, 1) - new FixedVector2D(10, 10));
    }

    [Fact]
    public void Multiply()
    {
        Assert.Equal(new FixedVector2D(2, 3), new FixedVector2D(1, 1) * new FixedVector2D(2, 3));
        Assert.Equal(new FixedVector2D(4, 6), new FixedVector2D(2, 2) * new FixedVector2D(2, 3));
    }

    [Fact]
    public void Divide()
    {
        Assert.Equal(new FixedVector2D(4, 3), new FixedVector2D(12, 12) / new FixedVector2D(3, 4));
        Assert.Equal(new FixedVector2D(6, 4), new FixedVector2D(48, 32) / new FixedVector2D(8, 8));
    }
}
