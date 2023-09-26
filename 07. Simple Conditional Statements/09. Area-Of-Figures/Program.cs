namespace _09._Area_Of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double size = double.Parse(Console.ReadLine());

            switch (figureType)
            {
                case "square":
                    Console.WriteLine($"{size * size:f2}");
                    break;
                case "rectangle":
                    double size2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{size * size2:f2}");
                    break;
                case "circle":
                    Console.WriteLine($"{Math.PI * Math.Pow(size, 2):f2}");
                    break;
                default:
                    Console.WriteLine("Invalid figure.");
                    break;
            }
        }
    }
}