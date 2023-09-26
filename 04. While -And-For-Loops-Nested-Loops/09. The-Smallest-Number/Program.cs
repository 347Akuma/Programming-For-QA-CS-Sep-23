namespace _09._The_Smallest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            string input;

            while((input = Console.ReadLine()) != "Stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber < min)
                {
                    min = currentNumber;
                }
            }
            Console.WriteLine(min);
        }
    }
}