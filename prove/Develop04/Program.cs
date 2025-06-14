using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflect");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Select an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new Breathing(30).Display(); break;
                case "2":
                    new Reflect(30).Display(); break;
                case "3":
                    new Listing(30).Display(); break;
                case "4":
                    running = false; break;
                default:
                    Console.WriteLine("Invalid choice."); break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to menu...");
                Console.ReadLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}
