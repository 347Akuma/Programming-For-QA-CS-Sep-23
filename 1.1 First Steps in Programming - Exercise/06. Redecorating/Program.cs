namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonAmount = int.Parse(Console.ReadLine());
            int paintAmount = int.Parse(Console.ReadLine());
            int thinnerAmount = int.Parse(Console.ReadLine());
            int hoursWorkNeeded = int.Parse(Console.ReadLine());

            double nylonPrice = 1.50 * (nylonAmount + 2);
            double paintPrice = 14.50 * (paintAmount + paintAmount * 0.10);
            double thinnerPrice = 5.00 * thinnerAmount;
            double bagsPrice = 0.40;

            double totalMaterials = nylonPrice + paintPrice + thinnerPrice + bagsPrice;

            double amountForCraftsmen = (totalMaterials * 0.30) * hoursWorkNeeded;

            double toPay = totalMaterials + amountForCraftsmen;

            Console.WriteLine(toPay);
        }
    }
}