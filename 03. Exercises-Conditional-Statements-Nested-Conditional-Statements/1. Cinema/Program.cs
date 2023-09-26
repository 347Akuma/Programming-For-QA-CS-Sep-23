namespace _1._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string screeningType = Console.ReadLine();
            int rowsNum = int.Parse(Console.ReadLine());
            int columnsNum = int.Parse(Console.ReadLine());

            double ticketPrice = 0.0;

            if (screeningType == "Premiere")
            {
                ticketPrice = 12.00;
            }
            else if (screeningType == "Normal")
            {
                ticketPrice = 7.50;
            }
            else if (screeningType == "Discount")
            {
                ticketPrice = 5.00;
            } else
            {
                Console.WriteLine("Invalid Input");
            }
            
            int fullHall = rowsNum * columnsNum;
            double totalIncome = fullHall * ticketPrice;
            Console.WriteLine($"{totalIncome:F2} leva");
        }
    }
}