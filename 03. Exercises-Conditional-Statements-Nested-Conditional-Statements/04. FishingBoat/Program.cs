namespace _04._FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double boatRent = 0;


            switch (season)
            {
                case "Spring":
                    boatRent = 3000.00;
                    if (fishermenCount <= 6)
                        boatRent *= 0.90;
                    else if (fishermenCount >6 && fishermenCount <= 11)
                    {
                        boatRent *= 0.85;
                    } else if (fishermenCount > 11)
                    {
                        boatRent *= 0.75;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    boatRent = 4200.00;
                    if (fishermenCount <= 6)
                        boatRent *= 0.90;
                    else if (fishermenCount > 6 && fishermenCount <= 11)
                    {
                        boatRent *= 0.85;
                    }
                    else if (fishermenCount > 11)
                    {
                        boatRent *= 0.75;
                    }
                    break;
                case "Winter":
                    boatRent = 2600.00;
                    if (fishermenCount <= 6)
                        boatRent *= 0.90;
                    else if (fishermenCount > 6 && fishermenCount <= 11)
                    {
                        boatRent *= 0.85;
                    }
                    else if (fishermenCount > 11)
                    {
                        boatRent *= 0.75;
                    }
                    break;
            }
            if (season != "Autumn" && fishermenCount % 2 == 0)
            {
                boatRent *= 0.95;
                
                if (groupBudget >= boatRent)
                {
                    double moneyleft = groupBudget - boatRent;
                    Console.WriteLine($"Yes! You have {moneyleft:F2} leva left.");
                }
                else
                {
                    double moneyNeeded = boatRent - groupBudget;
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }

            }
            else
            {
                if (groupBudget >= boatRent)
                {
                    double moneyleft = groupBudget - boatRent;
                    Console.WriteLine($"Yes! You have {moneyleft:F2} leva left.");
                }
                else
                {
                    double moneyNeeded = boatRent - groupBudget;
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
            }
            
        }
    }
}