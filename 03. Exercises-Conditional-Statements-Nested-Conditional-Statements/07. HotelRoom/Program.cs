namespace _07._HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPerNight = 0;
            double aptPerNight = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPerNight = 50.00;
                    aptPerNight = 65.00;
                    break;

                case "June":
                case "September":
                    studioPerNight = 75.20;
                    aptPerNight = 68.70;
                    break;

                case "July":
                case "August":
                    studioPerNight = 76.00;
                    aptPerNight = 77.00;
                    break;
            }
            double studioTotal = nightsCount * studioPerNight;
            double aptTotal = nightsCount * aptPerNight;

            if ((nightsCount > 7 && nightsCount < 14) && (month == "May" || month == "October"))
            {
                studioTotal *= 0.95;
            }
            else if (nightsCount > 14)
            {
                aptTotal *= 0.90;

                if (month == "May" || month == "October")
                {
                    studioTotal *= 0.70;
                }
                else if (month == "June" || month == "September")
                {
                    studioTotal *= 0.80;
                }
            }
            Console.WriteLine($"Apartment: {aptTotal:F2} lv.");
            Console.WriteLine($"Studio: {studioTotal:F2} lv");
            



        }
    }
}