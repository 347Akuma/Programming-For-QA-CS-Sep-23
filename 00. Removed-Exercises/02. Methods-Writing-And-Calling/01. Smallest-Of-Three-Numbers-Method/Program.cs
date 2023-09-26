namespace _01._Smallest_Of_Three_Numbers_Method
{
    internal class Program
    {
        static int SmallestOfThreeNumbers(int num1, int num2, int num3)
        {
            return Math.Min(Math.Min(num1, num2), num3);
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine()); 
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int smallest = SmallestOfThreeNumbers(num1, num2, num3);

            Console.WriteLine(smallest);

        }
    }
}