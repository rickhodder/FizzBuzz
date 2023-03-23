namespace FizzBuzz;
public class FizzBuzzer
{
    public Dictionary<int,string> FizzBuzz()
    {
        var result = new Dictionary<int, string>();
        
        for (int i = 1; i <= 100; i++)
        {
            result.Add(i, i.ToString());
        }

        return result;
    }
}
