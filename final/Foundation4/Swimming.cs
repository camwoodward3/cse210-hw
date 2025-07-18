using System;

public class Swimming : Activity
{
    private double _swimLaps;

    public Swimming(string date, int duration, double swimLaps)
        : base(date, duration)
    {
        _swimLaps = swimLaps;
    }
    public override string GetActivityName()
    {
        return "Swimming";
    }
    public override double GetDistanceKm()
    {
        return _swimLaps * 50 / 1000;
    }

    public override double GetDistanceMiles()
    {
        return _swimLaps * 50 / 1000 * 0.62;
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