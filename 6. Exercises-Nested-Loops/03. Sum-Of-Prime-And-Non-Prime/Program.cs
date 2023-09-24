namespace _03._Sum_Of_Prime_And_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeNumCount = 0;
            int nonprimeNumCount = 0;
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                int num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                int divisors = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisors++;
                    }
                }
                if (divisors == 2)
                {
                    primeNumCount += num;
                }
                else
                {
                    nonprimeNumCount += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumCount}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeNumCount}");
        }
    }
}