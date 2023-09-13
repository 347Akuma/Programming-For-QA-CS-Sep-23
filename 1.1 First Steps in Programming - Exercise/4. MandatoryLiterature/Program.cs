namespace _4._MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPages = int.Parse(Console.ReadLine());
            int hourPages = int.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            int totalReadingTime = numPages / hourPages;

            int totalHours = totalReadingTime / numDays;

            Console.WriteLine(totalHours);
        }
    }
}