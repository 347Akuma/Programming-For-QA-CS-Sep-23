namespace _09._SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string assessment = Console.ReadLine();

            double nights = days - 1;
            double price = 0;
            double discountedStay = 0;

            switch (roomType)
            {
                case "room for one person":
                    discountedStay = 118 * nights;
                    break;
                case "apartment":
                    discountedStay = nights * 155;
                    if (nights < 10)
                    {
                        discountedStay = (155 * nights) * 0.7;

                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        discountedStay = (155 * nights) * 0.65;
                    }
                    else //if (nights > 15)
                    {
                        discountedStay = (155 * nights) * 0.5;
                    }
                    break;
                case "president apartment":
                    discountedStay = nights * 235;
                    if (nights < 10)
                    {
                        discountedStay = (235 * nights) * 0.9;

                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        discountedStay = (235 * nights) * 0.85;
                    }
                    else //if (nights > 15)
                    {
                        discountedStay = (235 * nights) * 0.8;
                    }
                    break;
            }

            if (assessment == "positive")
            {
                price = discountedStay * 1.25;
            }
            else if (assessment == "negative")
            {
                price = discountedStay * 0.9;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}