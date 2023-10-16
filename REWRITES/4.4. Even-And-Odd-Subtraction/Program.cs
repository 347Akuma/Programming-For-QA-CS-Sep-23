int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int evenSum = 0;
int oddSum = 0; 

for (int i = 0; i < integers.Length; i++)
{
    if (integers[i] % 2 == 0)
    {
        evenSum += integers[i];
    }
    else
    {
        oddSum += integers[i];
    }
}

Console.WriteLine($"{evenSum - oddSum}");