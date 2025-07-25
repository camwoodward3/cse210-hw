using System;


public class Prompts
{
    static Random Generator = new Random();

    private static List<string> _questions = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    ];

    public Prompts(List<string> questions)
    {
        _questions = questions;
    }

    public static string GiveQuestion()
    {
        int number = Generator.Next(0, _questions.Count);
        string RandomQuestion = _questions[number];
        return RandomQuestion;
    }

}