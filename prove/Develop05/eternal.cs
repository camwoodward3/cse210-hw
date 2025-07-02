using System;

public class Eternal : Goals
{
    public Eternal(string name, string description, int score, bool isComplete) : base(name, description, score, isComplete)
    {
    }

    public override string SaveToFile()
    {
        return $"Eternal|{_name}|{_description}|{_score}|{_isComplete}";
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
    return $"[∞] {_name} - {_description} ({_score} pts)";
}

}
