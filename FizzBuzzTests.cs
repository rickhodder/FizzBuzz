namespace FizzBuzz;

public class FizzBuzzTests
{
    private FizzBuzzer _sut;

    [Fact]
    public void CallFizzBuzzSuccessfully()
    {
        _sut = new FizzBuzzer();
        var result = _sut.FizzBuzz();
    }
}