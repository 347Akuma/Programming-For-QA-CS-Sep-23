static void SignOfIntegerNum(int num)
{
    if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else if (num < 0)
    {
        Console.WriteLine($"The number {num} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {num} is zero.");
    }
}

SignOfIntegerNum(int.Parse(Console.ReadLine()));