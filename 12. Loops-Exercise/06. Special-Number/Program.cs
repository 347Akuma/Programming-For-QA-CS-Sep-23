namespace _06._Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = n; // initial number which will not change
            bool isSpecial = true; // flag, we assume it's special from the start as it takes less checks

            while (n > 0) // loop until no digits remain
            {
                int lastDigit = n % 10; // get last digit from input

                if (start % lastDigit != 0) // if initial is not divisible by the last digit, condition is not met -> end
                {
                    isSpecial = false;
                    break;
                }
                n /= 10; // if the above is not the case, remove the last digit, take the next digit
                         // we work with integers, so dividing a number by 10 will cut out the digit after ","
            }
            if (isSpecial == true)
            {
                Console.WriteLine($"{start} is special");
            }
            else
            {
                Console.WriteLine($"{start} is not special");
            }
        }
    }
}