
int[] firstArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int i in firstArr)
{
    if (secondArr.Contains(i))
    {
        Console.Write(i + " ");
    }
}