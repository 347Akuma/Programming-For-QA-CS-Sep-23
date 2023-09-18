namespace _08._The_Greatest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int currentNumber = int.Parse(input);

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine(max);
        }
    }
}