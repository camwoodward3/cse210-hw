using System;

public class Superhero
{
    private string _realName;
    private string _alias;
    private string _teamName;
    private string _powerType;

    public Superhero(string realName, string alias, string teamName, string powerType)
    {
        _realName = realName;
        _alias = alias;
        _teamName = teamName;
        _powerType = powerType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{_alias} (Real Name: {_realName})");
        Console.WriteLine($"Team: {_teamName}");
        Console.WriteLine($"Power Type: {_powerType}");
    }
}