
static int GetSumOfEvenDigits(int n)
{
    int evenSum = 0;

    for (int i = Math.Abs(n); i > 0; i /= 10)
    {
        int lastDigit = Math.Abs(i % 10);

        if (lastDigit % 2 == 0)
        {
            evenSum += Math.Abs(lastDigit);
        }
        else
        {
            continue;
        }
    }
    return evenSum;

}

static int GetSumOfOddDigits(int n)
{
    int oddSum = 0;

    for (int i = Math.Abs(n); i > 0; i /= 10)
    {
        int lastDigit = Math.Abs(i % 10);

        if (lastDigit % 2 != 0)
        {
            oddSum += Math.Abs(lastDigit);
        }
        else
        {
            continue;
        }

    }
    return oddSum;
}
static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
{
    return evenSum * oddSum;
}


int n = int.Parse(Console.ReadLine());

int result = GetMultipleOfEvenAndOdds(GetSumOfOddDigits(n), GetSumOfEvenDigits(n));
Console.WriteLine(result);