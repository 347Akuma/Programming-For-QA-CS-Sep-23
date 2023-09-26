namespace _04._Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"Greater number: {n1}");
            }
            else
            {
                Console.WriteLine($"Greater number: {n2}");
            }
        }
    }
}