namespace _08._BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basketballFeePerYear = int.Parse(Console.ReadLine());

            double sneakersPrice = basketballFeePerYear - (basketballFeePerYear * 0.40);
            double teamPrice = sneakersPrice - (sneakersPrice * 0.20);
            double ballPrice = teamPrice / 4;
            double accesoriesPrice = ballPrice / 5;

            double totalPrice = basketballFeePerYear + sneakersPrice + teamPrice + ballPrice + accesoriesPrice;

            Console.WriteLine(totalPrice);

        }
    }
}