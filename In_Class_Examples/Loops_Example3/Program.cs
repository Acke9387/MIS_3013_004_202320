for (int i = 1; i <= 900; i++)
{

    //see if it's divisible by 3 and 5 - 'Fizzbuzz'
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Fizzbuzz");
    }
    //see if it's divisible by 3 - 'Fizz'
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    //see if it's divisible by 5 - 'Buzz'
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    //output the number
    else
    {
        Console.WriteLine(i.ToString("N0"));
    }
}