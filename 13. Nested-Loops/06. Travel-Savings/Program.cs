namespace _06._Travel_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    string destination = Console.ReadLine();

                    if (destination == "End")
                    {
                        break;
                    }

                    int minBudget = int.Parse(Console.ReadLine());
                    int saved = 0;

                    while (saved < minBudget)
                    {
                        int currAmount = int.Parse(Console.ReadLine());
                        saved += currAmount;
                        Console.WriteLine($"Collected: {saved:f2}");
                    }
                    Console.WriteLine($"Going to {destination}!");
                }
            }
        }
    }
}

