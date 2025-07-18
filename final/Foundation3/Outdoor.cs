using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, DateTime startTime, DateTime endTime, Address address, string weather)
        : base(title, description, startTime, endTime, address)
    {
        _weather = weather;
    }

    public override void GetFullDescription()
    {
        Console.WriteLine($"{_title}, {_description}, {_startTime}, {_endTime}, {get_address()}, {_weather}");
    }
}

