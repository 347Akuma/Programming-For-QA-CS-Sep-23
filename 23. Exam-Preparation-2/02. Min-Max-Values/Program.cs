List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int index = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;
for (int i = 0; i <= index - 1; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    
    if (numbers[i] < min)
    {
        min = numbers[i];
    }    
}
Console.WriteLine(max);
Console.WriteLine(min);