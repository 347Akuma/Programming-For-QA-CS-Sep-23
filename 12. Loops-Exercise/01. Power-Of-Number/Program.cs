namespace _12._Loops_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            int curr = n;

            for (int i = 1; i < pow; i++)
            {
                curr *= n;               
            }
            Console.WriteLine(curr);
        }
    }
}