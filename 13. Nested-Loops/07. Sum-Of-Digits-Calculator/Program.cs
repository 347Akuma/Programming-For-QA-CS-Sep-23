namespace _07._Sum_Of_Digits_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                int num = int.Parse(input);
                int sum = 0;              

                while (num > 0)
                {
                    int currNum = num % 10;
                    sum += currNum;
                    num /= 10;
                }
                Console.WriteLine($"Sum of digits = {sum}");
            }
            Console.WriteLine("Goodbye");
        }
    }
}