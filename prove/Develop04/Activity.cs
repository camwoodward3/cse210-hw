using System;

public class Activity
{
    public string _name;
    public int _duration;
    public string _description;

    public Activity(string name, int duration, string description)
    {
        _name = name;
        _duration = duration;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine(_description);
        AskForDuration();
        Console.Clear();
        Console.WriteLine($"Starting: {_name}");
        Console.WriteLine("Prepare to begin...");
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Spinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(3);
        Console.WriteLine("\nPlease Enter to return to menu...");
        Console.ReadLine();
    }

    public void AskForDuration()
    {
        Console.WriteLine("How long would like this session to be in seconds? ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int seconds) && seconds > 0)
        {
            _duration = seconds;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default of 30 seconds.");
            _duration = 30;
        }
    }

    public void Spinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime stopTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < stopTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(150);
            Console.Write("\b");
            i++;
        }
        Console.Write(" ");
        Console.Write("\b");
    }

    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

    public virtual void Display()
    {
        StartMessage();
        EndMessage();
    }
}


