List<int> ints = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> gaussNums = new List<int>();

int last = ints.Count;

for (int i = 0; i < ints.Count / 2; i++)
{
    int numToAdd = ints[i] + ints[ints.Count - 1 - i];
    gaussNums.Add(numToAdd);
}

if (ints.Count % 2 != 0)
{
    gaussNums.Add(ints[last / 2]);
}
Console.WriteLine(string.Join(" ", gaussNums));


