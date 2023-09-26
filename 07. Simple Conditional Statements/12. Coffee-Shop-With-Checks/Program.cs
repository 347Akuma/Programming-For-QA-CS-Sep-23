namespace _12._Coffee_Shop_With_Checks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();


            switch (drink)
            {
                case "coffee":
                    switch (extra)
                    {
                        case "sugar":
                            Console.WriteLine($"Final price: ${1.40:f2}");
                            break;
                        case "no":
                            Console.WriteLine($"Final price: ${1.00:f2}");
                            break;
                        default:
                            Console.WriteLine("Unknown extra");
                            break;
                    }
                    break;
                case "tea":
                    switch (extra)
                    {
                        case "sugar":
                            Console.WriteLine($"Final price: ${1.00:f2}");
                            break;
                        case "no":
                            Console.WriteLine($"Final price: ${0.60:f2}");
                            break;
                        default:
                            Console.WriteLine("Unknown extra");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Unknown drink");
                    break;


            }
        }
    }
}