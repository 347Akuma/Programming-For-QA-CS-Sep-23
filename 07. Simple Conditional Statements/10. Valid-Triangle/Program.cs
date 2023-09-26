namespace _10._Valid_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                Console.WriteLine("Valid Triangle");
            }
            else
            {
                Console.WriteLine("Invalid Triangle");
            }
        }
    }
}