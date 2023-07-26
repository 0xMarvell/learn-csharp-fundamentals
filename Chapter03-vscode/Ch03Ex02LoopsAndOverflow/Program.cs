checked
{
    try
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }
    catch (System.Exception ex)
    {
        WriteLine($"{ex.GetType()} says {ex.Message}");
    }
}

