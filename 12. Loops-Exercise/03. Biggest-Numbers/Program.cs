namespace _03._Biggest_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                if (curr > max)
                    max = curr;
            }
            Console.WriteLine(max);
        }
    }
}