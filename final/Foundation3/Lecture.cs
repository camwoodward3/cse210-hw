using System;

public class Lecture : Event
{
    private string _speaker;
    private int _canfit;

    public Lecture(string title, string description, DateTime startTime, DateTime endTime, Address address, string speaker, int canfit)
        : base(title, description, startTime, endTime, address)
    {
        _speaker = speaker;
        _canfit = canfit;
    }

    public override void GetFullDescription()
    {
        Console.WriteLine($"{_title}, {_description}, {_startTime}, {_endTime}, {get_address()}, {_speaker}, {_canfit}");
    }
}