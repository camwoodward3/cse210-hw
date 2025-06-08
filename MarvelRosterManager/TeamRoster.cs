using System;
using System.Collections.Generic;

public class TeamRoster
{
    private List<Superhero> _roster;

    public TeamRoster()
    {
        _roster = new List<Superhero>();
    }

    public void AddHero(Superhero hero)
    {
        _roster.Add(hero);
    }

    public void DisplayAll()
    {
        foreach (Superhero hero in _roster)
        {
            hero.DisplayInfo();
            Console.WriteLine("-------------------------");
        }
    }
}