using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goals> _goals = new List<Goals>();
    public static int _totalScore = 0;
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
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
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    Save();
                    break;
                case "4":
                    Load();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;

            }
        }
    }

    static void AddGoal()
    {

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would like you to create? ");
        string type = Console.ReadLine();

        Console.WriteLine("What is the name of your Goal? ");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();


        switch (type)
        {
            case "1":
                Console.WriteLine("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                _goals.Add(new Simple(name, description, points, false));
                break;
            case "2":
                Console.WriteLine("What is the amount of points associated with this goal?" );
                int points2 = int.Parse(Console.ReadLine());
                _goals.Add(new Eternal(name, description, points2, false));
                break;
            case "3":
                Console.WriteLine("What is the amount of points associated with this goal? ");
                int points3 = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accompolished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accompolishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new Check(name, description, points3, false,  0, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type");
                break;

        }

    }
    static void ListGoals()
    {
        Console.WriteLine("Your goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].List()}");
        }
    }

    static void Save()
    {
        Console.Write("What is the filename for the goal file? ");
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

    static void Load()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        _totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            switch (type)
            {
                case "Simple":
                    _goals.Add(new Simple(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4])));
                    break;
                case "Eternal":
                    _goals.Add(new Eternal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "Check":
                    _goals.Add(new Check(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.WriteLine("Which goal did you accompolish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _totalScore += _goals[index].GetScore();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    
}