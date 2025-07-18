using System;

public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, DateTime startTime, DateTime endTime, Address address, string rsvp)
        : base(title, description, startTime, endTime, address)
    {
        _rsvp = rsvp;
    }
    
    public override void GetFullDescription()
    {
        Console.WriteLine($"{_title}, {_description}, {_startTime}, {_endTime}, {get_address()}, {_rsvp}");
    }

}