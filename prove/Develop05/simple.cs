using System;

public class Simple : Goals
{

    public Simple(string name, string description, int score, bool isComplete)
        : base(name, description, score, isComplete)
    {
        
    }

    public override string SaveToFile()
    {
        return $"Simple|{_name}|{_description}|{_score}|{_isComplete}";
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
        return $"{status} {_name} - {_description} ({_score} pts)";
    }
}