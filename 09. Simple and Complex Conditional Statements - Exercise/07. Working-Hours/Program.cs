namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfDay = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            if ((hourOfDay >= 10 && hourOfDay <= 18) && dayOfTheWeek != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}