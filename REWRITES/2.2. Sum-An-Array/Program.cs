int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sum = 0;
for (int i = 0; i < integers.Length; i++)
{
    sum += integers[i];
}
Console.WriteLine(sum);
