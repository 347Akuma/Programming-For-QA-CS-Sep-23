static double FindFactorial(double firstNum)
{
    double result = 1;

        for (double j = firstNum; j > 0; j--)
        {
            result *= j;
        }
    
    return result;
}

double firstNum = double.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine());

double result = FindFactorial(firstNum) / FindFactorial(secondNum);

Console.WriteLine(result);