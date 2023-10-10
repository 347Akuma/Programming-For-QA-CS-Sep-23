int MathPower(int baseNum, int powerNum)
{
    int sum = baseNum;
    for (int i = 0; i < powerNum - 1; i++)
    {
        sum *= baseNum;
    }
    return sum;
}

int baseNum = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());

int result = MathPower(baseNum,powerNum);
Console.WriteLine(result);

