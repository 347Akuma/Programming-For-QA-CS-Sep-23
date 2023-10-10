static void PrintingTriangle(int n)
{
    for (int i = 1; i <= n; i++) // first half of triangle
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }

    for (int i = n - 1; i >= 1; i--) // second half of triangle (top reversed)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }

}

int n = int.Parse(Console.ReadLine());
PrintingTriangle(n);


