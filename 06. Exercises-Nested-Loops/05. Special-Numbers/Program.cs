namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int digit = 1111; digit <= 9999; digit++)
            {
                String digits = digit.ToString();
                bool isSpecial = true;

                for (int digitIndex = 0; digitIndex < digits.Length; digitIndex++)
                {
                    int currDigit = int.Parse(digits[digitIndex].ToString());
                    if (currDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    if (n % currDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                {
                    Console.Write(digit + " ");
                }
            }
            Console.WriteLine();
        }
    }
}