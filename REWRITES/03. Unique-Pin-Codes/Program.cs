int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int first = 2; first <= max1; first += 2)
{
    for (int second = 2; second <= max2; second++)
    {
        for (int third = 2; third <= max3; third += 2)
        {
            if (second == 2 || second == 3 || second == 5 || second == 7)
            {
                Console.WriteLine($"{first}{second}{third}");
            }
        }
    }
}