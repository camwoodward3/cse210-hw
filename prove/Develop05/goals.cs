using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _score;
    protected bool _isComplete;
    public Goals(string name, string description, int score, bool isComplete)
    {
        _name = name;
        _description = description;
        _score = score;
        _isComplete = isComplete;
    }

    public abstract void RecordEvent();
    public abstract string SaveToFile();

    public abstract string List();

    public bool IsComplete() => _isComplete;
    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetScore() => _score;
}
