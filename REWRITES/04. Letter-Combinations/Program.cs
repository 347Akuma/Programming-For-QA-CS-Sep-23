char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char exclude = char.Parse(Console.ReadLine());

int combCount = 0;

for (char first = start; first <= end; first++)
{
    for (char second = start; second <= end; second++)
    {
        for (char third = start; third <= end; third++)
        {
            if (first != exclude && second != exclude && third != exclude)
            {
                Console.Write($"{first}{second}{third} ");
                combCount++;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(combCount);