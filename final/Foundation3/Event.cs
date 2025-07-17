using System;

public class Event
{
    public string _title;
    public string _description;
    public DateTime _date;
    public string _time;
    public Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetGeneralInfo()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }

    public string GetGeneralDescription()
    {
        return $"{_title}, {_time}";
    }
}