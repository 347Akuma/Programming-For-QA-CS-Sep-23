namespace Exercises_Simple_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}