namespace _09._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            double price = 0;
            switch (movieType)
            {
                case "Premiere": price += 12.00; break;
                case "Normal": price += 7.50; break;
                case "Discount": price += 5.00; break;
            }

            double totalTicket = price * (rows * seats);
            Console.WriteLine($"{totalTicket:f2}");
        }
    }
}