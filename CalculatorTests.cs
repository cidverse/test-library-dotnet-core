namespace test_library_dotnet_core;

using Xunit;

public class CalculatorTests {
    private readonly Calculator _calculator;

    public CalculatorTests() {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_ReturnsCorrectSum() {
        // Arrange
        double a = 5;
        double b = 3;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference() {
        // Arrange
        double a = 10;
        double b = 4;

        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct() {
        // Arrange
        double a = 7;
        double b = 6;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(42, result);
    }
}