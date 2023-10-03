namespace _03._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            int max = int.Parse(Console.ReadLine());

            while (num <= max)
            {

                num = (num * 2) + 1;
                if (num >= max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}