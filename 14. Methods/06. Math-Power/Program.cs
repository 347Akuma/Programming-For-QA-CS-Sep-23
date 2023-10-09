namespace _06._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNum = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnPower(baseNum, pow));
        }

        static int ReturnPower(int baseNum, int pow)
        {
            int result = 1;

            for (int i = 1; i <= pow; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}