namespace FizzBuzz;
public class FizzBuzzer
{
    public Dictionary<int,string> FizzBuzz()
    {
        var result = new Dictionary<int, string>();
        
        for (int i = 1; i <= 100; i++)
        {
            if(i%3==0)
            {
                result.Add(i, "Fizz");
                continue;
            }
            result.Add(i, i.ToString());
        }

        return result;
    }
}
