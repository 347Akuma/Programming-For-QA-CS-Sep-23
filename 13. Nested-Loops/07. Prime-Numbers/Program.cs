using System;

namespace _07._Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int primeCount = 0;

            for (int currNum = start; currNum <= end; currNum++)
            {
                int divisors = 0;

                for (int j = 1; j <= currNum; j++)
                {
                    if (currNum % j == 0)
                    {
                        divisors++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (divisors == 2)
                {
                    Console.Write(currNum + " ");
                    primeCount++;
                }               
            }
            if (primeCount == 0)
            {
                Console.WriteLine("No prime numbers found.");
            }
        }
    }
}