using CalculatorLib;
namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void Add2And2()
    {
        // Arrange
        double a = 2;
        double b = 2;
        double expected = 4;
        Calculator calc = new();
        // Act
        double actual = calc.Add(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Add2And3()
    {
        // arrange
        double a = 2;
        double b = 3;
        double expected = 5;
        Calculator calc = new();
        // act
        double actual = calc.Add(a, b);
        // assert
        Assert.Equal(expected, actual);
    }
}