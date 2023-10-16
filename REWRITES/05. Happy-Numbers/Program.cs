int n = int.Parse(Console.ReadLine());

for (int first = 1; first <= n; first++)
{
    for (int second = n - 1; second >= 0; second--)
    {
        for (int third = 0; third <= n; third++)
        {
            for (int fourth = n; fourth >= 0; fourth--)
            {
                if (first + second == n && third + fourth == n)
                {
                    Console.Write($"{first}{second}{third}{fourth} ");
                }
            }
        }
    }
}
