using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

          int x = 0;

        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("Please enter a number");
        string userInput = Console.ReadLine();
        int userInputAsInt = int.Parse(userInput);

        int y=10;
        int asdf=0;
        asdf=10;
        Console.WriteLine(asdf);

        if (userInputAsInt > 0) 
        {
            Console.WriteLine($"This number {userInputAsInt} is greater than 0");

               // do nothing
        } else if (userInputAsInt < 0) 
        {
            Console.WriteLine($"This number {userInputAsInt} is less than 0");

        }
        else if (userInputAsInt == 0)
        {
            Console.WriteLine($"This number {userInputAsInt} is 0");

        }
        if (userInputAsInt>0 || y==10) 
        {

        }
        if (userInputAsInt>0) {

        }
        if (y == 10) {

        }
    }
}