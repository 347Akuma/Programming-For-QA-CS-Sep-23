namespace _07._Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stop = int.Parse(Console.ReadLine());

            int curr;
            int last = 0;
            while ((curr = int.Parse(Console.ReadLine())) != stop)
            {
                last = curr;
            }
            Console.WriteLine($"{last * 1.2}");
        }
    }
}