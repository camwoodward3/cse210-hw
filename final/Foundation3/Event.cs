using System;

public abstract class Event
{
    public string _title;
    public string _description;
    public DateTime _startTime;
    public DateTime _endTime;
    public string _time;
    public Address _address;

    public Event(string title, string description, DateTime startTime, DateTime endTime, Address address)
    {
        _title = title;
        _description = description;
        _startTime = startTime;
        _endTime = endTime;
        _address = address;
    }

    public string get_address()
    {
        return _address.AllTogether();
    }
    public string GetGeneralInfo()
    {
        return $"{_title}, {_description}, {_startTime}, {_endTime}, {_address}";
    }

    public string GetGeneralDescription()
    {
        return $"{_title}, {_time}";
    }

    public abstract void GetFullDescription();
}