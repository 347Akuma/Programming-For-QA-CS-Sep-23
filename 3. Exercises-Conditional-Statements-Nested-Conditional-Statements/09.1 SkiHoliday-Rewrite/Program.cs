namespace _09._1_SkiHoliday_Rewrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string ass = Console.ReadLine();

            int nights = daysToStay - 1;
            double roomPrice = 0;
            double totalPrice = 0;

            if (roomType == "room for one person")
            {
                roomPrice = nights * 118.00;
            }
            else if (roomType == "apartment")
            {
                roomPrice = nights * 155.00;
                if (daysToStay < 10)
                {
                    roomPrice *= 0.7;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    roomPrice *= 0.65;
                }
                else
                {
                    roomPrice *= 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                roomPrice = nights * 235.00;
                if (daysToStay < 10)
                {
                    roomPrice *= 0.90;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    roomPrice *= 0.85;
                }
                else
                {
                    roomPrice *= 0.80;
                }
            }

            if (ass == "positive")
            {
                totalPrice = roomPrice * 1.25;
            }
            else
            {
                totalPrice = roomPrice * 0.90;
            }

            Console.WriteLine($"{totalPrice}");
        }


    }
}