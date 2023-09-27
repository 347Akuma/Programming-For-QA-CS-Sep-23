namespace _08._Complex_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (product == "Banana")
            {
                if (day == "Weekday")
                {
                    price += 2.50;
                }
                else if (day == "Weekend")
                {
                    price += 2.70;
                }
            }
            else if (product == "Apple")
            {
                if (day == "Weekday")
                {
                    price += 1.30;
                }
                else if (day == "Weekend")
                {
                    price += 1.60;
                }
            }
            else if (product == "Kiwi")
            {
                if (day == "Weekday")
                {
                    price += 2.20;
                }
                else if (day == "Weekend")
                {
                    price += 3.00;
                }
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}