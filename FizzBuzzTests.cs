namespace FizzBuzz;

public class FizzBuzzTests
{
    private FizzBuzzer _sut;

    public FizzBuzzTests()
    {
        _sut = new FizzBuzzer();
    }

    [Fact]
    public void CallFizzBuzzSuccessfully()
    {
        var result = _sut.FizzBuzz();
    }

    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    public void FizzBuzz_DivisibleBy3_ReturnsFizz(int input, string expected)
    {
        var result = _sut.FizzBuzz();
        Assert.Equal(expected, result[input]);
    }    
}