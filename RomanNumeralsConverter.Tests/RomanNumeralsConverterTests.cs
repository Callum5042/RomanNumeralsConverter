using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RomanNumeralsConverter.Tests;

public class RomanNumeralsConverterTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(5, "V")]
    [InlineData(10, "X")]
    [InlineData(50, "L")]
    [InlineData(100, "C")]
    [InlineData(500, "D")]
    [InlineData(1000, "M")]
    public void Convert_BasicValues(int number, string roman)
    {
        // Act
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        // Assert
        Assert.Equal(roman, result);
    }

    [Theory]
    [InlineData(125, "CXXV")]
    public void Convert_ComplexValues(int number, string roman)
    {
        // Act
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(number);

        // Assert
        Assert.Equal(roman, result);
    }

    [Fact]
    public void Convert_GreaterThan1000()
    {
        // Act
        var converter = new RomanNumeralsConverter();
        var result = converter.Convert(3000);

        // Assert
        Assert.Equal("MMM", result);
    }
}