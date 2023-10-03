namespace _11._While_Loop_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            while ((n = int.Parse(Console.ReadLine())) % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(n);
        }
    }
}