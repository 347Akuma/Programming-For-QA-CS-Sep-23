using System;

namespace _07._Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int currNum = start; currNum <= end; currNum++)
            {
                bool isPrime = true;
                int divisors = 2;

                while (divisors < end)
                {
                    if (currNum == divisors)
                    {
                        divisors++;
                        continue;
                    }

                    if (currNum % divisors == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divisors++;
                }
                if (isPrime)
                {
                    Console.Write($"{currNum} ");
                }
            }
        }
    }
}