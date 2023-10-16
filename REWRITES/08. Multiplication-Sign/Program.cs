static void VerifyProduct(int n1, int n2, int n3)
{
    if (n1 == 0 || n2 == 0 || n3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if (n1 > 0 && n2 > 0 && n3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (n1 < 0 && n2 < 0 && n3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (n1 < 0 && n2 > 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (n1 > 0 && n2 < 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

VerifyProduct(first, second, third);