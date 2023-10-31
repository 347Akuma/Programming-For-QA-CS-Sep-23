List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int sum = 0;
foreach (int num in numbers)
{
    if (num % 2 == 0)
    {
        int factorialResult = CalculateFactorial(num);
        sum += factorialResult;
    }
}
Console.WriteLine(sum);

int CalculateFactorial(int number) // calc factorial
{
    int result = 1;

    while (number > 0)
    {
        result *= number;
        number -= 1;
    }
    return result;
}