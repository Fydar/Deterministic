namespace Fydar.Deterministic.Numerics.UnitTests;

/// <summary>
/// Unit tests for the <see cref="Fixed"/> type.
/// </summary>
public class FixedTests
{
    [Fact]
    public void ApproximatePi()
    {
        // Arrange
        var pi = Fixed.Pi;

        // Act
        string piString = pi.ToString();

        // Assert
        Assert.Equal("3.14159", piString);
    }

    [Fact]
    public void Sin()
    {
        // Arrange
        // A value like π/4 (0.785398...) which should result in approx 0.7071
        Fixed x = Fixed.Pi / 4;

        // Act
        Fixed result = Fixed.Sin(x);

        // Assert
        Assert.True(Math.Abs((double)result - 0.70710678) < 0.001);
    }

    [Fact]
    public void ApproximateTau()
    {
        // Arrange
        var tau = Fixed.Tau;

        // Act
        string tauString = tau.ToString();

        // Assert
        Assert.Equal("6.28317", tauString);
    }

    [Fact]
    public void ApproximateRoot2()
    {
        Assert.Equal("1.4142", Fixed.Sqrt(2).ToString("0.0000"));
    }

    [Fact]
    public void Root0Equals0()
    {
        Assert.Equal((Fixed)0, Fixed.Sqrt(0));
    }

    [Fact]
    public void Divide()
    {
        Assert.Equal(12, (Fixed)12 / (Fixed)1);
        Assert.Equal(6, (Fixed)12 / (Fixed)2);
        Assert.Equal(4, (Fixed)12 / (Fixed)3);
        Assert.Equal(3, (Fixed)12 / (Fixed)4);

        Assert.Equal(12, (Fixed)12 / 1);
        Assert.Equal(6, (Fixed)12 / 2);
        Assert.Equal(4, (Fixed)12 / 3);
        Assert.Equal(3, (Fixed)12 / 4);

        Assert.Equal(12, 12 / (Fixed)1);
        Assert.Equal(6, 12 / (Fixed)2);
        Assert.Equal(4, 12 / (Fixed)3);
        Assert.Equal(3, 12 / (Fixed)4);
    }

    [Fact]
    public void Multiply()
    {
        Assert.Equal(0, (Fixed)1 * (Fixed)0);
        Assert.Equal(1, (Fixed)1 * (Fixed)1);
        Assert.Equal(2, (Fixed)1 * (Fixed)2);
        Assert.Equal(3, (Fixed)1 * (Fixed)3);

        Assert.Equal(0, (Fixed)1 * 0);
        Assert.Equal(1, (Fixed)1 * 1);
        Assert.Equal(2, (Fixed)1 * 2);
        Assert.Equal(3, (Fixed)1 * 3);

        Assert.Equal(0, 1 * (Fixed)0);
        Assert.Equal(1, 1 * (Fixed)1);
        Assert.Equal(2, 1 * (Fixed)2);
        Assert.Equal(3, 1 * (Fixed)3);
    }

    [Fact]
    public void Add()
    {
        Assert.Equal(1, (Fixed)1 + (Fixed)0);
        Assert.Equal(2, (Fixed)1 + (Fixed)1);
        Assert.Equal(3, (Fixed)1 + (Fixed)2);
        Assert.Equal(4, (Fixed)1 + (Fixed)3);

        Assert.Equal(1, (Fixed)1 + 0);
        Assert.Equal(2, (Fixed)1 + 1);
        Assert.Equal(3, (Fixed)1 + 2);
        Assert.Equal(4, (Fixed)1 + 3);

        Assert.Equal(1, 1 + (Fixed)0);
        Assert.Equal(2, 1 + (Fixed)1);
        Assert.Equal(3, 1 + (Fixed)2);
        Assert.Equal(4, 1 + (Fixed)3);
    }

    [Fact]
    public void Subtract()
    {
        Assert.Equal(1, (Fixed)1 - (Fixed)0);
        Assert.Equal(0, (Fixed)1 - (Fixed)1);
        Assert.Equal(-1, (Fixed)1 - (Fixed)2);
        Assert.Equal(-2, (Fixed)1 - (Fixed)3);

        Assert.Equal(1, (Fixed)1 - 0);
        Assert.Equal(0, (Fixed)1 - 1);
        Assert.Equal(-1, (Fixed)1 - 2);
        Assert.Equal(-2, (Fixed)1 - 3);

        Assert.Equal(1, 1 - (Fixed)0);
        Assert.Equal(0, 1 - (Fixed)1);
        Assert.Equal(-1, 1 - (Fixed)2);
        Assert.Equal(-2, 1 - (Fixed)3);
    }
}
