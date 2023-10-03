namespace _05._Number_In_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;

            bool isFound = false;

            while (!isFound)
            {
                n = double.Parse(Console.ReadLine());

                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine(n);
                    isFound = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}