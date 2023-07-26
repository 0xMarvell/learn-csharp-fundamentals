using static System.Convert;

// double g = 9.8;
// int h = ToInt32(g);
// WriteLine($"g is {g} and h is {h}");

// double[] doubles = new[]{9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

// foreach (double d in doubles)
// {
//     // WriteLine($"ToInt32(d) is {ToInt32(d)}");
//     WriteLine
//     (
//         format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
//         arg0: d,
//         arg1: Math.Round(d, mode: MidpointRounding.AwayFromZero)
//     );
// }

// int num = 12;
// string v = num.ToString();
// WriteLine(v.GetType());

// DateTime now = DateTime.Now;
// WriteLine(now.ToString());


// int count = int.Parse("108");
// WriteLine(count);
Write("How old are you? ");
string? age = ReadLine();

if (int.TryParse(age, out int years))
{
    WriteLine($"You are {years} years old");
}
else 
{
    WriteLine("Could not parse input");
}