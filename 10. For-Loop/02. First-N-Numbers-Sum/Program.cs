namespace _02._First_N_Numbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                if (i == n)
                {                
                    Console.Write(i + "=");
                    break;
                }
                else
                {
                    Console.Write(i + "+");
                }
            }
            Console.Write(sum);
        }
    }
}