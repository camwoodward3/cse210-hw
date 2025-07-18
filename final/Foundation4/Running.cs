using System;

public class Running : Activity
{
    private double _runLaps;

    public Running(string date, int duration, double runLaps)
        : base(date, duration)

    {
        _runLaps = runLaps;
    }


    public override string GetActivityName()
    {
        return "Running";
    }
    public override double GetDistanceKm()
    {
        return _runLaps * 50 / 1000;

    }

    public override double GetDistanceMiles()
    {
        return _runLaps * 50 / 1000 * 0.62;
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