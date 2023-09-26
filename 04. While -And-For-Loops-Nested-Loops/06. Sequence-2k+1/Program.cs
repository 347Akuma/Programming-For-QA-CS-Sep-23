using System;

namespace _06._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());

            int counter = 1;

            while (counter <= targetNum)
            {
                Console.WriteLine(counter);

                counter *= 2;
                counter++;
            }
        }
    }
}