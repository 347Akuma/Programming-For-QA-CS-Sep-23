namespace _05._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toRepeat = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());

            RepeatString(toRepeat, repeatTimes);
        }

        static void RepeatString(string toRepeat, int repeatTimes)
        {
            for (int i = 1; i <= repeatTimes; i++)
            {
                Console.Write(toRepeat); 
            }
        }
    }
}