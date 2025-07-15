using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static int _totalScore = 0;
    private static List<Goals> _goals = new List<Goals>();
    static void Main(string[] args)
    {
        string number = "";
        while (number != "6")
        {

            Console.WriteLine($"You have {_totalScore} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            number = Console.ReadLine();
            if (number == "1")
            {
                AddGlobal();
            }
            else if (number == "2")
            {
                ListGoals();
            }
            else if (number == "3")
            {
                Save();
            }
            else if (number == "4")
            {
                Load();
            }
            else if (number == "5")
            {
                RecordEvent();
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
    public static void AddGlobal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.WriteLine("What is the name of your Goal? ");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();

        if (type == "1")
        {
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(new Simple(name, description, points, false));
        }
        else if (type == "2")
        {
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int points2 = int.Parse(Console.ReadLine());
            _goals.Add(new Eternal(name, description, points2, false));
        }
        else if (type == "3")
        {
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int points3 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accompolished for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accompolishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new Check(name, description, points3, false, 0, targetCount, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type");
        }
    }

    public static void ListGoals()
    {

        Console.WriteLine("Your goals are:");
        foreach (Goals goals in _goals)
        {
            Console.WriteLine($"{goals.List()}");
        }
    }

    public static void Save()
    {
        Console.WriteLine("Enter filename: ");
        string file = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_totalScore);
            foreach (Goals goal in _goals)
            {
                writer.WriteLine(goal.SaveToFile());
            }
        }
        Console.WriteLine("Goals saved successfully!");

    }

    public static void Load()
    {
        Console.WriteLine("Enter filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string type = parts[0];
            if (type == "Simple")
            {
                _goals.Add(new Simple(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4])));
            }
            else if (type == "Eternal")
            {
                _goals.Add(new Eternal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (type == "Check")
            {
                _goals.Add(new Check(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }

    public static void RecordEvent()
    {
        ListGoals();
        Console.WriteLine("Which goal did you accompolish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goals goal = _goals[index];
            goal.RecordEvent();
            _totalScore += goal.GetScore();
            Console.WriteLine($"Congratulations! You earned {goal.GetScore()} points.");
            Console.WriteLine($"Total Score: {_totalScore}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    

}