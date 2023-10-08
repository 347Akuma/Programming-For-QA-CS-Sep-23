namespace _05._Division_To_2_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int divTwo = 0;
            int divThree = 0;
            int divFour = 0;

            for (int i = 1; i <= n; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                if (curr % 2 == 0)
                {
                    divTwo++;
                }
                
                if (curr % 3 == 0)
                {
                    divThree++;
                }
                
                if (curr % 4 == 0)
                {
                    divFour++;
                }
            }
            Console.WriteLine($"{divTwo * 100.0 / n:f2}%");
            Console.WriteLine($"{divThree * 100.0 / n:f2}%");
            Console.WriteLine($"{divFour * 100.0 / n:f2}%");
        }
    }
}