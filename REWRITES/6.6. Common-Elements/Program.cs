

int[] firstArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < firstArr.Length; i++)
{
    if (secondArr.Contains(firstArr[i]))
    {
        Console.Write(firstArr[i] + " ");
    }
}