namespace _05._TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackagesNum = int.Parse(Console.ReadLine());
            int markerPackagesNum = int.Parse(Console.ReadLine());
            int boardCleanerLiters = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double penPackagePrice = 5.80 * penPackagesNum;
            double markerPackagePrice = 7.20 * markerPackagesNum;
            double boardCleanerPrice = 1.20 * boardCleanerLiters;

            double totalMaterials = penPackagePrice + markerPackagePrice + boardCleanerPrice;

            double totalPriceDiscount = totalMaterials - (totalMaterials * discountPercent / 100); 

            Console.WriteLine(totalPriceDiscount);
            
        }
    }
}