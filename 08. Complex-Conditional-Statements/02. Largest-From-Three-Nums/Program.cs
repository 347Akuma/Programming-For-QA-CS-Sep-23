namespace _02._Largest_From_Three_Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num3 < num1)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num3 && num1 < num2)
            {
                Console.WriteLine(num2);
            }
            else
            {
                 Console.WriteLine(num3);
            }
        }
    }
}