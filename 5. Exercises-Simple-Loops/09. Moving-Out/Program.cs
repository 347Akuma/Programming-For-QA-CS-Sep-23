namespace _09._Moving_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int totalSpace = width * length * height;

            while (totalSpace >= 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                    break;

                totalSpace -= int.Parse(input);
            }
            if (totalSpace >= 0)
            {
                Console.WriteLine($"{totalSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {-totalSpace} Cubic meters more.");
            }
        }
    }
}