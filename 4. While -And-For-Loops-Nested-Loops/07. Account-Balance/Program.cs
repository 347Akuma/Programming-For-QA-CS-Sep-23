namespace _07._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            string command;

            while ((command = Console.ReadLine()) != "NoMoreMoney")
            {

                double operation = double.Parse(command);

                if (operation < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {operation:f2}");
                    balance += operation;
                    continue;
                }    
            }
            Console.WriteLine($"Total: {balance}");
        }
    }
}