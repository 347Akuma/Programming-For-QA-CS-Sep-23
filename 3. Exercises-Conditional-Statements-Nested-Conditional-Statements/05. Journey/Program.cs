namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string holidayType = "";
            double stayPrice = 0;


            if (budget <= 100.00)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    stayPrice = budget * 0.30;
                } else
                {
                    holidayType = "Hotel";
                    stayPrice = budget * 0.70;
                }
            }
            else if (budget <= 1000.00)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    stayPrice = budget * 0.40;
                }
                else
                {
                    holidayType = "Hotel";
                    stayPrice = budget * 0.80;
                }
            } else
            {
                destination = "Europe";
                holidayType = "Hotel";
                stayPrice = budget * 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {stayPrice:F2}");
        } 
    }
}