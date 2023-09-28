namespace _10._Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            if (temp >= 10 && temp <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";                  
                }
                else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }               
            } 
            else if (temp >= 18 && temp <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temp >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}