using System;

public class Lecture : Event
{
    private string _speaker;
    private int _canfit;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int canfit)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _canfit = canfit;
    }

    public string GetFullDescription()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}, {_speaker}, {_canfit}";
    }
}