using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();

        activity.Add(new Running("14 Jul 2025", 40, 3));
        activity.Add(new Bike("10 Jul 2025", 30, 4));
        activity.Add(new Swimming("17 Jul 2025", 90, 5));

        Console.WriteLine("===Activities===");
        foreach (var act in activity)
        {
            act.GetSummary();
            Console.WriteLine();
        }
    }
    
}