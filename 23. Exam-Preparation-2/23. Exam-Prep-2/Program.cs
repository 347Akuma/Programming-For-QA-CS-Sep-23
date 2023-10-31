int n = int.Parse(Console.ReadLine());


bool noMatch = true;

for (int currNum = 1; currNum <= n; currNum++)
{
    int numContainer = currNum;
    int digitSum = 0;

    bool areAllDigitsPrime = true;

    while (numContainer > 0)
    {
        int digit = numContainer % 10; // take last digit
        numContainer = numContainer / 10; // remove last digit

        bool digitIsPrime = digit == 2 || digit == 3 || digit == 5 || digit == 7;

        if (digitIsPrime)
        {
            digitSum += digit;
        }
        else
        {
            areAllDigitsPrime = false;
            break;
        }
    }
    if (areAllDigitsPrime && digitSum % 2 == 0)
    {
        Console.Write(currNum + " ");
        noMatch = false;
    }
    else
    {
        
    }
}

if (noMatch == true)
{
    Console.WriteLine("no");
}