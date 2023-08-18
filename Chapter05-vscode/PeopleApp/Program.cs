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

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1969, 6, 25)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavouriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavouriteIceCream}.");
string color = "Red";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.
    FavoritePrimaryColor}.");
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}",
    nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

// Book book = new()
// {
//     Isbn = "978-1803237800",
//     Title = "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"
// };

Book book = new(
    isbn: "978-1803237800",
    title: "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"
    )
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine(
    "{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book.Title, book.Author, book.PageCount
    );

sam.Children.Add(new()
{
    Name = "Charlie",
    DateOfBirth = new(2010, 3, 18)
});
sam.Children.Add(new()
{
    Name = "Ella",
    DateOfBirth = new(2020, 12, 24)
});
// get using Children list
WriteLine($"Sam's first child is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");

// get using integer position indexer

WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");
// get using name indexer
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");


int number = 5; // change to -1 to make the exception handling code
try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}

Passenger[] passengers = {
new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
new BusinessClassPassenger { Name = "Janice" },
new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};
foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _
        => 2000M,
        BusinessClassPassenger _
        => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _
        => 650M,
        _
        => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}