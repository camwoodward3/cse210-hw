public class Avenger : Superhero
{
    private string _specialWeapon;

    public Avenger(string realName, string alias, string powerType, string specialWeapon)
        : base(realName, alias, "Avengers", powerType)
    {
        _specialWeapon = specialWeapon;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Special Weapon: {_specialWeapon}");
    }
}