// FizzBuzz
for (int num = 1; num <= 100; num++)
{
    if (num % 15 == 0)
    {
        Write("FizzBuzz, ");
    }
    else if (num % 5 == 0)
    {
        Write("Fizz, ");
    }
    else if (num % 3 == 0)
    {
        Write("Buzz, ");
    }
    else
    {
        Write($"{num}, ");
    }
}