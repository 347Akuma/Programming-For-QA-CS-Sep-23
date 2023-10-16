int n = int.Parse(Console.ReadLine());

for (int a = 1; a <= 9; a++)
{
    for (int b = 1; b <= 9; b++)
    {
        for (int c = 9; c >= 0; c--)
        {
            if (a * b * c == n)
            {
                Console.Write($"{a}{b}{c} ");
            }
        }
    }
}