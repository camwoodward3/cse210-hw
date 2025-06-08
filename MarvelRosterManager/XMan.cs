public class XMan : Superhero
{
    private string _mutationType;

    public XMan(string realName, string alias, string powerType, string mutationType)
        : base(realName, alias, "X-Men", powerType)
    {
        _mutationType = mutationType;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Mutation Type: {_mutationType}");
    }
}