namespace _09._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finish1 = int.Parse(Console.ReadLine());
            int finish2 = int.Parse(Console.ReadLine());
            int finish3 = int.Parse(Console.ReadLine());

            int total = finish1 + finish2 + finish3;


            int minutes = total / 60;
            int seconds = total % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");

        }
    }
}