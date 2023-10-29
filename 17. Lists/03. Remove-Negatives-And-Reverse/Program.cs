List<int> numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

for (int i = 0; i <= numbers.Count - 1; i++)
{
    int curr = numbers[i];
    if (curr < 0)
    {
        numbers.Remove(curr);
        i--;
    }    
    else
    {
        continue;
    }
}

if (numbers.Count > 0)
{
    numbers.Reverse();
    Console.WriteLine(string.Join(" ", numbers));
}
else
{
    Console.WriteLine("empty");
}