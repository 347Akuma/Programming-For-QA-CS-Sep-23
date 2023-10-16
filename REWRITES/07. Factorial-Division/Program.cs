static double CalculateFactorial(double n)
{
    double factorial = 1;
    for (double i = n; i > 0; i--)
    {
        factorial *= i;
    }
    return factorial;
}

double first = double.Parse(Console.ReadLine());
double second = double.Parse(Console.ReadLine());

double result = Math.Abs(CalculateFactorial(first) / CalculateFactorial(second));

Console.WriteLine(result);