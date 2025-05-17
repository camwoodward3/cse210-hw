using System;


public class Prompts
{
    static Random Generator = new Random();

    public static string GetRandomPrompt()
    {
        List<string> prompts = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        ];
        int number = Generator.Next(0, prompts.Count);
        string randomPrompt = prompts[number];
        return randomPrompt;
    }
}