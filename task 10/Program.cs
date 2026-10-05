using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Question 1
        int[] numbers = { 5, 3, 8, 4, 2, 1 };

        BubbleSort.Sort(numbers);

        Console.WriteLine("Question 1:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // Question 2
        Range<int> range = new Range<int>(10, 20);

        Console.WriteLine("Question 2:");
        Console.WriteLine(range.IsInRange(15));
        Console.WriteLine(range.Length());

        Console.WriteLine();


        // Question 3
        ArrayList list = new ArrayList()
        {
            1, 2, 3, 4, 5
        };

        ArrayListReverser.Reverse(list);

        Console.WriteLine("Question 3:");
        foreach (object item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // Question 4
        List<int> nums = new List<int>()
        {
            1, 2, 3, 4, 5, 6
        };

        List<int> evenNumbers =
            EvenNumbers.GetEvenNumbers(nums);

        Console.WriteLine("Question 4:");
        foreach (int number in evenNumbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // Question 5
        FixedSizeList<int> fixedList =
            new FixedSizeList<int>(3);

        fixedList.Add(10);
        fixedList.Add(20);
        fixedList.Add(30);

        Console.WriteLine("Question 5:");
        Console.WriteLine(fixedList.Get(1));

        Console.WriteLine();


        // Question 6
        string text = "swiss";

        int index =
            FirstNonRepeatedCharacter.Find(text);

        Console.WriteLine("Question 6:");
        Console.WriteLine(index);
    }
}