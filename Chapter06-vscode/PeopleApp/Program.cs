using System.Collections;
using Packt.Shared;

Person grundy = new()
{
    Name = "Solomon Grundy",
    DateOfBirth = new(year: 2023, month: 7, day: 31)
};

grundy.WriteToConsole();

// Dictionary<int, string> lookupObject = new();
// lookupObject.Add(key: 1, value: "Alpha");
// lookupObject.Add(key: 2, value: "Beta");
// lookupObject.Add(key: 3, value: "Gamma");
// lookupObject.Add(key: 4, value: "Delta");

grundy.Shout += Grundy_Shout;
grundy.Shout += Grundy_Shout2;
grundy.Poke();
grundy.Poke();
grundy.Poke();
grundy.Poke();