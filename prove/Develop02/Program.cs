using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;


public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string number = "";
        while (number != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            number = Console.ReadLine();
            if (number == "1")
            {
                string Prompt = Prompts.GiveQuestion();
                Console.WriteLine(Prompt);
                string Response = Console.ReadLine();
                DateTime currentTime = DateTime.Now;
                Entry entry = new Entry(currentTime, Prompt, Response);
                journal._entries.Add(entry);

            }
            else if (number == "2")
            {
                journal.DisplayEntries();
            }
            else if (number == "3")
            {
                journal.loadEntry();
            }
            else if (number == "4")
            {
                journal.Save();
            }
        }
        Console.WriteLine();
        Console.WriteLine("Goodbye!");


    }
}