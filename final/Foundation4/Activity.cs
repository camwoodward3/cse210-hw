using System;

public abstract class Activity
{
    public string _date;
    public int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual string GetActivityName()
    {
        return "Activity";
    }
    public abstract double GetDistanceKm();

    public abstract double GetDistanceMiles();

    public virtual double GetSpeedMiles() {
        return GetDistanceMiles() / _duration * 60;
    }

    public virtual double GetSpeedKm()
    {
        return GetDistanceKm() / _duration * 60;
    }


    public virtual double GetPaceMiles()
    {
        return _duration / GetDistanceMiles();
    }

    public virtual double GetPaceKm()
    {
        return _duration / GetDistanceKm();
        
    }

    public virtual void GetSummary()
    {
        string activityName = GetActivityName();

        Console.WriteLine($"{_date} {activityName} ({_duration} min) - Distance: {Math.Round(GetDistanceMiles(), 2)} miles, Speed: {Math.Round(GetSpeedMiles(), 2)} mph, Pace: {Math.Round(GetPaceMiles(), 2)} min per mile");

        Console.WriteLine($"{_date} {activityName} ({_duration} min) - Distance: {Math.Round(GetDistanceKm(), 2)} km, Speed: {Math.Round(GetSpeedKm(), 2)} kph, Pace: {Math.Round(GetPaceKm(), 2)} min per km");

    }
}