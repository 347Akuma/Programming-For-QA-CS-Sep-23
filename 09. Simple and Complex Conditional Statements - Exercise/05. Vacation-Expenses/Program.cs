namespace _05._Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string acomType = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            double pricePerNight = 0;        
            switch (season)
            {
                case "Spring":
                    switch (acomType)
                    {
                        case "Hotel":
                            pricePerNight = ((pricePerNight + 30.00) * daysCount) * 0.80;
                            break;
                        case "Camping":
                            pricePerNight = ((pricePerNight + 10.00) * daysCount) * 0.80;
                            break;                       
                    }
                    break;
                case "Summer":
                    switch (acomType)
                    {
                        case "Hotel":
                            pricePerNight = ((pricePerNight + 50.00) * daysCount);
                            break;
                        case "Camping":
                            pricePerNight = ((pricePerNight + 30.00) * daysCount);
                            break;
                    }
                    break;
                case "Autumn":
                    switch (acomType)
                    {
                        case "Hotel":
                            pricePerNight = ((pricePerNight + 20.00) * daysCount) * 0.70;
                            break;
                        case "Camping":
                            pricePerNight = ((pricePerNight + 15.00) * daysCount) * 0.70;
                            break;
                    }
                    break;
                case "Winter":
                    switch (acomType)
                    {
                        case "Hotel":
                            pricePerNight = ((pricePerNight + 40.00) * daysCount) * 0.90;
                            break;
                        case "Camping":
                            pricePerNight = ((pricePerNight + 10.00) * daysCount) * 0.90;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"{pricePerNight:f2}");
        }
    }
}