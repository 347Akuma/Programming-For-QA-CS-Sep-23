static void FirstSol(int x, int y)
{

    int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


    bool areEqual = true;

    for (int i = 0; i < firstArr.Length; i++)
    {
        if (firstArr[i] != secondArr[i])
        {
            areEqual = false;
            break;
        }
    }
    if (areEqual)
    {
        Console.WriteLine("Arrays are identical.");
    }
    else
    {
        Console.WriteLine("Arrays are not identical.");
    }
}

static void SecondSol(int x, int y)
{
    int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    bool areEqual = firstArr.SequenceEqual(secondArr);

    if (areEqual)
    {
        Console.WriteLine("Arrays are identical.");
    }
    else
    {
        Console.WriteLine("Arrays are not identical.");
    }
}