using System;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    List<string> _responses = new List<string>();


    public Listing(int duration)
        : base("Listing", duration, "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
    public void ResponseControl()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("You may begin in: ");
        CountDown(5);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                _responses.Add(input);
            }
        }
    }
    public void DisplayResponseControl()
    {
        Console.WriteLine($"You listed {_responses.Count} items!");

    }
    public override void Display()
    {

        StartMessage();


        ResponseControl();
        DisplayResponseControl();

        EndMessage();
    }
}
