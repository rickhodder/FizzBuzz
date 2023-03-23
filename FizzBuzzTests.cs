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

    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(13, "Fizz")]
    [InlineData(23, "Fizz")]
    public void FizzBuzz_HasA3digit_ReturnsFizz(int input, string expected)
    {
        var result = _sut.FizzBuzz();
        Assert.Equal(expected, result[input]);
    }    

    [Theory]
    [InlineData(5, "Buzz")]
    [InlineData(15, "Buzz")]
    [InlineData(25, "Buzz")]
    public void FizzBuzz_HasA5digit_ReturnsBuzz(int input, string expected)
    {
        var result = _sut.FizzBuzz();
        Assert.Equal(expected, result[input]);
    }


    [Theory]
    [InlineData(35, "FizzBuzz")]
    [InlineData(53, "FizzBuzz")]
    
    public void FizzBuzz_HasA3and5digit_ReturnsFizzBuzz(int input, string expected)
    {
        var result = _sut.FizzBuzz();
        Assert.Equal(expected, result[input]);
    }

    [Theory]
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
    [InlineData(20, "Buzz")]
    public void FizzBuzz_DivisibleBy5_ReturnsFizz(int input, string expected)
    {
        var result = _sut.FizzBuzz();
        Assert.Equal(expected, result[input]);
    }    


    
}