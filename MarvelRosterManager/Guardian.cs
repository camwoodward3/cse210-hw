public class Guardian : Superhero
{
    private string _uniqueTrait;

    public Guardian(string realName, string alias, string powerType, string uniqueTrait)
        : base(realName, alias, "Guardians", powerType)
    {
        _uniqueTrait = uniqueTrait;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Ability: {_uniqueTrait}");
    }
}