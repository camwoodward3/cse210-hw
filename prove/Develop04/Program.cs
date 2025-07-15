using System;

class Program
{
    static void Main()
    {
        string number = "";
        while (number != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflect");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select an activity: ");
            number = Console.ReadLine();
            if (number == "1")
            {
                new Breathing(30).Display();
            }
            else if (number == "2")
            {
                new Reflect(30).Display(); 
            }
            else if (number == "3")
            {
                new Listing(30).Display();
            }
        }
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}
