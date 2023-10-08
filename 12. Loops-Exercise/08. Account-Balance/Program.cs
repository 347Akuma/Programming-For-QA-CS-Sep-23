namespace _08._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                double currAmount = double.Parse(input);

                if (currAmount > 0)
                {                  
                    Console.WriteLine($"Increase: {currAmount:f2}");
                    balance += currAmount;
                }
                else
                {                  
                    Console.WriteLine($"Decrease: {(Math.Abs(currAmount)):f2}");
                    balance -= Math.Abs(currAmount);
                }
            }
            Console.WriteLine($"Balance: {balance:f2}");
        }
    }
}