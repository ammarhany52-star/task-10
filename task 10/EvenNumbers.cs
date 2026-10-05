using System.Collections.Generic;

public class EvenNumbers
{
    public static List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> result = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }
}