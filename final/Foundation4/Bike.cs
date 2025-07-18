using System;

public class Bike : Activity
{
    private double _bikeLaps;

    public Bike(string date, int duration, double bikeLaps)
        : base(date, duration)
    {
        _bikeLaps = bikeLaps;
    }   

    public override string GetActivityName()
    {
        return "Biking";
    }
    public override double GetDistanceKm()
    {
        return _bikeLaps * 50 / 1000;
    }

    public override double GetDistanceMiles()
    {
        return _bikeLaps * 50 / 1000 * 0.62;
    }

    public override double GetSpeedMiles()
    {
        return base.GetSpeedMiles();
    }

    public override double GetSpeedKm()
    {
        return base.GetSpeedKm();
    }

    public override double GetPaceMiles()
    {
        return base.GetPaceMiles();
    }

    public override double GetPaceKm()
    {
        return base.GetPaceKm();
    }

    public override void GetSummary()
    {
        base.GetSummary();
    }
}