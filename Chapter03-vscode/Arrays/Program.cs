// string[] names; // can reference any size array of strings
// // allocating memory for four strings in an array
// names = new string[4];
// // storing items at index positions
// names[0] = "Kate";
// names[1] = "Jack";
// names[2] = "Rebecca";
// names[3] = "Tom";
// // looping through the names
// for (int i = 0; i < names.Length; i++)
// {
// // output the item at index position i
// WriteLine(names[i]);
// }

string[,] grid1 = new[,] 
{
    {"Alpha", "Beta", "Gamma", "Delta"},
    {"Anne", "Ben", "Charlie", "Doug"},
    {"Aardvark", "Bear", "Cat", "Dog"}
};

// WriteLine(grid1.Length);

// WriteLine($"Lower bound of outer array - {grid1.GetLowerBound(0)}");
// WriteLine($"Upper bound of outer array - {grid1.GetUpperBound(0)}");
// WriteLine($"Lower bound of inner array - {grid1.GetLowerBound(1)}");
// WriteLine($"Upper bound of inner array - {grid1.GetUpperBound(1)}");


string[][] jagged = new[]
{
    new[]{"Alpha", "Beta", "Gamma"},
    new[]{"Anne", "Ben", "Charlie", "Doug"},
    new[]{"Aardvark", "Bear"}
};

WriteLine("Upper bound of outer array is: {0}",jagged.GetUpperBound(0));

for (int innerArray = 0; innerArray <= jagged.GetUpperBound(0); innerArray++)
{
    WriteLine($"Upperbound of inner array {innerArray} is {jagged[innerArray].GetUpperBound(0)}");
}
