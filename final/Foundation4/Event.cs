using System;
using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _des;
    private DateTime _date;
    private string _time;
    private Address _address;
    public Event(string title, string des, DateTime date, string time, Address address)
    {
        _title = title;
        _des = des;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetGeneralInfo()
    {

    }

    public string GetAllInfo()
    {

    }

    public string GetGeneralDescription()
    {
        return _des;
    }
}
