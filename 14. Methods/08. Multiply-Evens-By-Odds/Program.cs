namespace _08._Multiply_Evens_By_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToOperate = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(numberToOperate), GetSumOfOddDigits(numberToOperate));
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int numberToOperate)
        {
            int evenSum = 0;

            for (int i = Math.Abs(numberToOperate); i > 0; i /= 10)
            {
                int lastNum = Math.Abs(i % 10);

                if (lastNum % 2 == 0)
                {
                    evenSum = Math.Abs(evenSum + lastNum);
                }
                else
                {
                    continue;
                }
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int numberToOperate)
        {
            int oddSum = 0;

            for (int i = Math.Abs(numberToOperate); i > 0; i /= 10)
            {
                int lastNum = Math.Abs(i % 10);

                if (lastNum % 2 != 0)
                {
                    oddSum = Math.Abs(oddSum + lastNum);
                }
                else
                {
                    continue;
                }
            }
            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int oddSum, int evenSum)
        {
            return oddSum * evenSum;
        }
    }
}