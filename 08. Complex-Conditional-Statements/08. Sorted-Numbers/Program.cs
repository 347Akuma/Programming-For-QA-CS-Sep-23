namespace _08._Sorted_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Ascending");
            }
            else if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }


        }
    }
}