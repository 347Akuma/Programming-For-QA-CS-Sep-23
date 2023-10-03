namespace _06._Number_Processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Inc": number += 1; break;
                    case "Dec": number -= 1; break;
                }
            }
            Console.WriteLine(number);
        }
    }
}