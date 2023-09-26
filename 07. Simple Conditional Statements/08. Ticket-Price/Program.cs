namespace _08._Ticket_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            if (ticketType == "student")
            {               
                Console.WriteLine($"${1.00:f2}");
            }
            else if (ticketType == "regular")
            {
                Console.WriteLine($"${1.60:f2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}