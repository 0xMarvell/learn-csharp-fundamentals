try
{
    Write("Enter a number between 0 and 255: ");
    string? a = ReadLine();
    Write("Enter another number between 0 and 255: ");
    string? b = ReadLine();

    int c = Int32.Parse(a!);
    int d = Int32.Parse(b!);

    WriteLine
    (
        format: "{0} divided by {1} is {2}",
        arg0: c,
        arg1: d,
        arg2: c / d
    );
}
catch (FormatException)
{
    WriteLine("Format Exception: Input string was not in a correct format.");
}