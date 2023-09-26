namespace _02._SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempDegrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            if (tempDegrees >= 10 && tempDegrees <= 18)
            {
                switch (timeOfDay)
                {
                    case "Morning": clothing = "Sweatshirt"; shoes = "Sneakers"; break;
                    case "Afternoon":
                    case "Evening": clothing = "Shirt"; shoes = "Moccasins"; break;
                    default: break;
                }
            }
            else if (tempDegrees > 18 && tempDegrees <= 24)
            {
                switch (timeOfDay)
                {
                    case "Morning": clothing = "Shirt"; shoes = "Moccasins"; break;
                    case "Afternoon": clothing = "T-Shirt"; shoes = "Sandals"; break;
                    case "Evening": clothing = "Shirt"; shoes = "Moccasins"; break;
                    default: break;
                }
            }
            else if (tempDegrees >= 25)
            {
                switch (timeOfDay)
                {
                    case "Morning": clothing = "T-Shirt"; shoes = "Sandals"; break;
                    case "Afternoon": clothing = "Swim Suit"; shoes = "Barefoot"; break;
                    case "Evening": clothing = "Shirt"; shoes = "Moccasins"; break;
                    default: break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine($"It's {tempDegrees} degrees, get your {clothing} and {shoes}.");
        }
    }
}