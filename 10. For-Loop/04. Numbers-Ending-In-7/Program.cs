namespace _04._Numbers_Ending_In_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 7; i <= range; i+=10)
            {
                Console.WriteLine(i);
            }
        }
    }
}