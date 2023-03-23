namespace FizzBuzz;
public class FizzBuzzer
{
    public Dictionary<int,string> FizzBuzz()
    {
        var result = new Dictionary<int, string>();
        
        for (int i = 1; i <= 100; i++)
        {
            if(i.ToString().Contains("3"))
            {
                result.Add(i, "Fizz");
                continue;
            }

            if(i.ToString().Contains("5"))
            {
                result.Add(i, "Buzz");
                continue;
            }

             if(i % 3 ==0 && i % 5 ==0)
            {
                result.Add(i, "FizzBuzz");
                continue;
            }
            if(i % 3 ==0)
            {
                result.Add(i, "Fizz");
                continue;
            }
            if(i % 5==0)
            {
                result.Add(i, "Buzz");
                continue;
            }
            
            result.Add(i, i.ToString());
        }

        return result;
    }
}
