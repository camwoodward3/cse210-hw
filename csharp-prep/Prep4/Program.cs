using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number (0 to quit)");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // 1. Complete the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        // 2. Complete the average of the numbers in the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // 3. Find the maximum, or largest, number in the list.
        int max = numbers[0];

        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        int min = numbers[0];

        foreach(int number in numbers)
        {
            if (number < max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The min is: {min}");

        

    }
    
}