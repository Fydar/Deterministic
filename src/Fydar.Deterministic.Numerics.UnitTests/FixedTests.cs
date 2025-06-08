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
    public void ApproximateTau()
    {
        // Arrange
        var tau = Fixed.Tau;

        // Act
        string tauString = tau.ToString();

        // Assert
        Assert.Equal("6.28317", tauString);
    }
}
