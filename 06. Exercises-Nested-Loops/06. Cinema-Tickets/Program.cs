namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                int seatsTaken = 0;

                string ticketType;
                while ((ticketType = Console.ReadLine()) != "End")
                {
                    seatsTaken++;
                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }
                    if (seatsTaken >= availableSeats)
                        break;
                }
                Console.WriteLine($"{input} - {seatsTaken * 100.0 / availableSeats:F2}% full.");
            }
            int totalTickets = studentTickets + standardTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets * 100.0 / totalTickets:F2}% student tickets.");
            Console.WriteLine($"{standardTickets * 100.0 / totalTickets:F2}% standard tickets.");
            Console.WriteLine($"{kidTickets * 100.0 / totalTickets:F2}% kids tickets.");
        }
    }
}