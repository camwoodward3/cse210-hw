using System;

public class Check : Goals
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public Check(string name, string description, int score, bool isComplete, int timesCompleted, int targetCount, int bonus)
        : base(name, description, score, isComplete)
    {
        _timesCompleted = timesCompleted;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override string SaveToFile()
    {
        return $"Simple|{_name}|{_description}|{_score}|{_isComplete}|{_timesCompleted}|{_targetCount}|{_bonus}";
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
    }

    public override string List()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} - {_description} ({_timesCompleted}/{_targetCount} times, {_score})";

    }  
}