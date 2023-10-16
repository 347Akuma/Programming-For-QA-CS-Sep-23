int n = int.Parse(Console.ReadLine());

for (int first = 2; first <= n; first += 2)
{
    for (int second = 1; second <= n; second += 2)
    {
        Console.Write($"{first}{second}{first*second} ");
    }
}