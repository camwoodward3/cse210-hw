using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string number = "75";
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
                string Prompt = Prompts.GetRandomPrompt();
                Console.WriteLine(Prompt);
                string Response = Console.ReadLine();
                DateTime currentTime = DateTime.Now;
                Entry entry = new Entry(currentTime, Prompt, Response);
                journal._entries.Add(entry);

            }
            else if (number == "2")
            {
                foreach (Entry entry in journal._entries)
                {
                    Console.WriteLine($"Date:{entry._theCurrentTime.ToShortDateString()}- Prompt: {entry._question}");
                    Console.WriteLine($"{entry._answer}");
                }
            }
            else if (number == "3")
            {
                journal._entries.Clear();
                Console.WriteLine("Enter Filename: ");
                string fileName = Console.ReadLine();
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    if (line.Trim() != "")
                    {
                        string[] parts = line.Split("|");
                        Console.WriteLine(parts);
                        DateTime date = DateTime.ParseExact(parts[0], "M/d/yyyy", CultureInfo.InvariantCulture);
                        journal._entries.Add(new Entry(date, parts[1], parts[2]));
                    }
                }

            }
            else if (number == "4")
            {
                Console.WriteLine("Enter Filename: ");
                string fileName = Console.ReadLine();
                File.WriteAllText(fileName, "");
                foreach (Entry item in journal._entries)
                {
                    item.StoreInputInto(fileName);
                }

            }
        }


    }
}