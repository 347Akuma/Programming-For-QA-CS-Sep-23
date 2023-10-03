namespace _06._Exam_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());

            for (int i = d; i > 0; i--)
            {
                Console.WriteLine($"{i} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}