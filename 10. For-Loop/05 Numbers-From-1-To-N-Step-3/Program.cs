namespace _05_Numbers_From_1_To_N_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}