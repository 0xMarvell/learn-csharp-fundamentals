using Packt.Shared;

Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-NG");

Person marv = new()
{
    Name = "Marvellous Chimaraoke",
    DateOfBirth = new(1999, 4, 14),
    FavouriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza,
};

WriteLine(format: "{0} was born on {1:d MMMM yyyy} and his favourite wonder of the world is {2} with the integer {3}",
    marv.Name,
    marv.DateOfBirth,
    marv.FavouriteAncientWonder,
    (int)marv.FavouriteAncientWonder
);

marv.Children.Add(new() { Name = "Rose Chimaraoke", DateOfBirth = new(2032, 5, 12) });
marv.Children.Add(new() { Name = "Lily Chimaraoke", DateOfBirth = new(2032, 5, 12) });

WriteLine($"{marv.Name} has {marv.Children.Count} children:");

marv.Children.ForEach(delegate (Person child)
{
    WriteLine($"{child.Name}");
});

WriteLine($"{marv.Name} is a {Person.Species}");

BankAccount.InterestRate = 0.012M; // store a shared value

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
arg0: gerrierAccount.AccountName,
arg1: gerrierAccount.Balance * BankAccount.InterestRate);


Person blankPerson = new();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: blankPerson.Name,
arg1: blankPerson.HomePlanet,
arg2: blankPerson.Instantiated);

Person wunna = new(initialName: "Wunna", homePlanet: "Mars");
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: wunna.Name,
arg1: wunna.HomePlanet,
arg2: wunna.Instantiated);

marv.WriteToConsole();
WriteLine(marv.GetOrigin());

var fruitNamed = marv.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

var (name, birth, faveWonder) = marv;
WriteLine($"{name}\n{birth}\n{faveWonder}");