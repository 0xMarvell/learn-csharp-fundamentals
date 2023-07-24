// int x = 0;
// while (x <= 10) {
//     WriteLine(x);
//     x++;
// }

// string? password;
// int attempts = 0;
// do
// {
//     Write("Enter your password: ");
//     password = ReadLine();
//     attempts++;
// } while (password != "pa$$word" && attempts < 10);
// if (attempts >= 10)
// {
//     WriteLine("Too many attempts");
// }
// else
// {
//     WriteLine("Correct!");
// }

// for (int i = 0; i <= 10; i++)
// {
//     WriteLine(i);
// }

int[] nums = {2,44,5,1,6};
foreach (int num in nums)
{
    WriteLine(num);
}

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
WriteLine($"{name} has {name.Length} characters.");
}