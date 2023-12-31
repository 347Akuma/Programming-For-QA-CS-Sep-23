﻿namespace _09._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{TotalOrderValue(product, quantity):f2}");
        }

        static double TotalOrderValue(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee": price = quantity * 1.50; break;
                case "water": price = quantity * 1.00; break;
                case "coke": price = quantity * 1.40; break;
                case "snacks": price = quantity * 2.00; break;
            }
            return price;
        }
    }
}