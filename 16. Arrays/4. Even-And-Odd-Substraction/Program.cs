string integers = Console.ReadLine();

string[] arr = integers.Split(' ');

int[] ints = new int[arr.Length];

int evenSum = 0;
int oddSum = 0;

for (int i = 0; i < arr.Length; i++)
{
    ints[i] = int.Parse(arr[i]);
    
    if (ints[i] % 2 == 0)
    {
        evenSum += ints[i];
    }
    else
    {
        oddSum += ints[i];
    }
}
Console.WriteLine($"{evenSum - oddSum}");
