namespace _04._Number_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2:f2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2:f2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2:f2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2:f2}");
                    break;

            }
        }
    }
}