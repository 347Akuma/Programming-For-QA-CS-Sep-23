namespace _04._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int m;

            while (n > 0)
            {
                m = n % 10;
                sum += m;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}