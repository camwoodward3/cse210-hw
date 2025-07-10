using System;
using System.Globalization;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date:{entry._theCurrentTime.ToShortDateString()} - Prompt: {entry._question}");
            Console.WriteLine($"{entry._answer}");
        }
        Console.WriteLine("");
    }

    public void loadEntry()
    {
        Console.WriteLine("Enter Filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            if (line.Trim() != "")
            {
                string[] parts = line.Split("|");
                Console.WriteLine(parts);
                DateTime date = DateTime.ParseExact(parts[0], "M/d/yyyy", CultureInfo.InvariantCulture);
                _entries.Add(new Entry(date, parts[1], parts[2]));
            }
        }

        Console.WriteLine("Entries loaded successfully!");
    }

    public void Save()
    {
        Console.WriteLine("Enter Filename: ");
        string file = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(file))
        {
           
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.GetData());
            }
        }

        Console.WriteLine("Entries saved successfully!");
    }

}