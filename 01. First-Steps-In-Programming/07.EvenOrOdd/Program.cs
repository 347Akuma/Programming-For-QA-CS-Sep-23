namespace _07.EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            } 
            else if (number % 2 == 1)
            {
                Console.WriteLine("odd");
            }
        }
    }
}