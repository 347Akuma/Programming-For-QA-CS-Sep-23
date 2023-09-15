namespace _03._NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowerPrice = 0;
           

            if (flowerType == "Roses")
            {
                flowerPrice = 5.00 * flowerCount;

                if (flowerCount > 80)
                    flowerPrice = flowerPrice * 0.9;
            } 
            else if (flowerType == "Dahlias")
            {
                flowerPrice = 3.80 * flowerCount;

                if (flowerCount > 90)
                    flowerPrice = flowerPrice * 0.85;
            }
            else if (flowerType == "Tulips")
            {
                flowerPrice = 2.80 * flowerCount;

                if (flowerCount > 80)
                    flowerPrice = flowerPrice * 0.85;
            }
            else if (flowerType == "Narcissus")
            {
                flowerPrice = 3.00 * flowerCount;

                if (flowerCount < 120)
                    flowerPrice = flowerPrice * 1.15;
            }
            else if (flowerType == "Gladiolus")
            {
                flowerPrice = 2.50 * flowerCount;

                if (flowerCount < 80)
                    flowerPrice = flowerPrice * 1.20;
            }
            else
            {
            }

            if (flowerPrice <= budget)
            {
                double sumLeft = budget - flowerPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {sumLeft:F2} leva left.");
            }
            else if (flowerPrice > budget)
            {
                double sumNeeded = flowerPrice - budget;
                Console.WriteLine($"Not enough money, you need {sumNeeded:F2} leva more.");
            } 
        }
    }
}