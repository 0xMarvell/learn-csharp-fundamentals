namespace Packt.Shared;

public partial class Person : Object
{
    //fields
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavouriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    // constants
    public const string Species = "Homo Sapien";
    // read-only
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    // constructors
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    public void Deconstruct(
        out string? name, 
        out DateTime dob, 
        out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = DateOfBirth;
        fav = FavouriteAncientWonder;
    }
}

