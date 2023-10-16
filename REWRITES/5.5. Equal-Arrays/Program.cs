int[] firstArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int matches = 0;
for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i].Equals(secondArr[i]))
    {
        matches++;
    }
    else
    {
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}
if (matches == firstArr.Length)
{
    Console.WriteLine("Arrays are identical.");
}