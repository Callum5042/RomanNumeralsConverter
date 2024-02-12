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
}