namespace _07._FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenusNum = int.Parse(Console.ReadLine());
            int fishMenusNum = int.Parse(Console.ReadLine());
            int veggieMenusNum = int.Parse(Console.ReadLine());

            double deliveryPrice = 2.50;

            double chickenMenusPrice = 10.35 * chickenMenusNum;
            double fishMenusPrice = 12.40 * fishMenusNum;
            double veggieMenusPrice = 8.15 * veggieMenusNum;

            double totalMenusPrice = chickenMenusPrice + fishMenusPrice + veggieMenusPrice;

            double dessertPrice = totalMenusPrice * 0.20;

            double totalTakeawayPrice = totalMenusPrice + dessertPrice + deliveryPrice;

            Console.WriteLine(totalTakeawayPrice);


        }
    }
}