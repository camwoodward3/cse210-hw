using System;

public class Breathing : Activity
{
    public Breathing(int duration)
        : base("Breathing", duration, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public override void Display()
    {
        StartMessage();
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine("\nBreathe in...");
            CountDown(4);
            Console.WriteLine("Now Breathe out...");
            CountDown(6);
        }
        EndMessage();
    }
}