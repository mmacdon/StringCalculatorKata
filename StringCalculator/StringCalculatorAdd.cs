using Xunit;
namespace StringCalculatorKata;
public class StringCalculatorAdd
{
    private readonly StringCalculator sut = new();

    [Fact]
    public void EmptyStringReturns0()
    {
        var result = sut.Add("");
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("100", 100)]
    public void GivenStringWithOneNumberReturnsNumber(string numbers, int expectedResult)
    {
        var result = sut.Add(numbers);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("20,2", 22)]
    [InlineData("100,-1", 99)]
    public void GivenStringWithTwoCommaSeparatedNumbersReturnsSumOfNumbers(string numbers, int expectedResult)
    {
        var result = sut.Add(numbers);
        Assert.Equal(expectedResult, result);
    }
}
