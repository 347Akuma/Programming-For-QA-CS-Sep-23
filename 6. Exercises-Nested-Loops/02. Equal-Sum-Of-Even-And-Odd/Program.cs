namespace _02._Equal_Sum_Of_Even_And_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smol = int.Parse(Console.ReadLine());
            int big = int.Parse(Console.ReadLine());

            for (int i = smol; i <= big; i++)
            {
                string values = i.ToString();

                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < values.Length; j++)
                {
                    int digit = int.Parse(values[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}