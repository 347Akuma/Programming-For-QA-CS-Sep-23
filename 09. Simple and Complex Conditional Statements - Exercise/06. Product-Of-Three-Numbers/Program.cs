namespace _06._Product_Of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            string result = "";

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                result = "zero";
            }
            else
            {
                int negativeCount = 0;

                if (num1 < 0)
                {
                    negativeCount++;
                }

                if (num2 < 0)
                {
                    negativeCount++;
                }

                if (num3 < 0)
                {
                    negativeCount++;
                }

                // If the count of negative numbers is odd, the product is negative
                if (negativeCount % 2 == 1)
                {
                    result = "negative";
                }
                else
                {
                    result = "positive";
                }
            }

            // Print the sign of the product
            Console.WriteLine(result);
        }
    }

}

