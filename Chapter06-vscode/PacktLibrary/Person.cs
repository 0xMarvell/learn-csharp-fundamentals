namespace Packt.Shared;

public class Person : object
{
    // properties
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    // event handler
    public event EventHandler? Shout;
    public int AngerLevel;

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            // if something is listening..
            if (Shout != null)
            {
                // then call the delegate
                Shout(this, EventArgs.Empty);
            }
        }
    }
}
