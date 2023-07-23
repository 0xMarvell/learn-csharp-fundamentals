Console.Write("Enter any key combo: ");
ConsoleKeyInfo key = Console.ReadKey();

Console.WriteLine();

Console.WriteLine($"Key: {key.Key}\nChar: {key.KeyChar}\nModifiers:{key.Modifiers}");

