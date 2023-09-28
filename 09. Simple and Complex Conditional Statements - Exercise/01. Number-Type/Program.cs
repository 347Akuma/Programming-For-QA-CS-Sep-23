namespace _09._Complex_Conditional_Statements_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("zero");
            } else if (number > 0)
            {
                Console.WriteLine("positive");
            } else
            {
                Console.WriteLine("negative");
            }
        }
    }
}