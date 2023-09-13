namespace weatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read town

            string town = Console.ReadLine();
           
            // read degrees

            int degrees = int.Parse(Console.ReadLine());

            // print in the format

            Console.WriteLine($"Today in {town} it is {degrees} degrees.");




        }
    }
}