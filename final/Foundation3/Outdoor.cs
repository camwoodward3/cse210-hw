using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullDescription()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}, {_weather}";
    }
}

