// idea - solve with list input + foreach


int result = int.Parse(Console.ReadLine());

int total = 0;

while (result != 0)
{
    int digit = result % 10;

    if (digit % 2 == 0)
    {
        int resultFactorial = CalculateFactorial(digit);
        total += resultFactorial;
    }
    result = result / 10;
}

Console.WriteLine(total);

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