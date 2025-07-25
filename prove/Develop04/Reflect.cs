using System;

public class Reflect : Activity
{
    static Random rand = new Random();
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflect(int duration)
        : base("Reflect", duration, "This activity will help you reflect on times in your life when you shown strength and resilience. This will help you have and how you can use it in other aspects of your life.")
    {
            
    }

    public string GetRandomPrompt()
    {
        int number = rand.Next(0, _prompts.Count);
        string RandomPrompt = _prompts[number];
        return RandomPrompt;
    }

    public string GetRandomQuestion()
    {
        int number = rand.Next(0, _questions.Count);
        string RandomQuestion = _questions[number];
        return RandomQuestion;
    }
    public override void Display()
    {
        StartMessage();
        DisplayRandomPrompt();
        DisplayRandomQuestion();
        EndMessage();

    }


    public void DisplayRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayRandomQuestion()
    {
        Console.WriteLine("Now ponder on each of the following question as they are related to this experience.");
        Console.WriteLine("You may begin in: ");
        CountDown(5);
        Console.Clear();
        Console.WriteLine($"> {GetRandomQuestion()}");
        Spinner(10);
        Console.WriteLine($"> {GetRandomQuestion()}");
        Spinner(10);
    }
}