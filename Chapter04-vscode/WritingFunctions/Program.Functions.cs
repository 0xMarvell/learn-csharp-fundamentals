partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows");
        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }

        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = 0.0M;
        switch (twoLetterRegionCode)
        {
            case "CH": // Switzerland
                rate = 0.08M;
                break;
            case "DK": // Denmark
            case "NO": // Norway
                rate = 0.25M;
                break;
            case "GB": // United Kingdom
            case "FR": // France
                rate = 0.2M;
                break;
            case "HU": // Hungary
                rate = 0.27M;
                break;
            case "OR": // Oregon
            case "AK": // Alaska
            case "MT": // Montana
                rate = 0.0M;
                break;
            case "ND": // North Dakota
            case "WI": // Wisconsin
            case "ME": // Maine
            case "VA": // Virginia
                rate = 0.05M;
                break;
            case "CA": // California
                rate = 0.0825M;
                break;
            default: // most US states
                rate = 0.06M;
                break;
        }
        return amount * rate;
    }

    static long Factorial(long number)
    {
        if ( number < 0)
        {
            throw new ArgumentException(
                message:$"The factorial function is defined for non-negative integers only. Input: { number }", 
                paramName: nameof(number));
        }
        else if (number ==0)
        {
            return 1;
        }
        else
        checked
        {
            return number * Factorial(number - 1);
        }

    }
}
