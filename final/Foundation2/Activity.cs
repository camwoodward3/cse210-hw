using System;

public class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public virtual double GetDistance()
    {

    }

    public virtual double GetSpeed()
    {

    }

    public virtual double GetPace()
    {

    }

    public virtual string GetSummary()
    {
        
    }
}