using System.Data;

namespace _06._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;

            int stepsTaken = 0;
            bool isFinished = false;

            string input;

            while (!isFinished && stepsTaken < goal)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    isFinished = true;
                    input = Console.ReadLine();
                }
                stepsTaken += int.Parse(input);
            }

            if (stepsTaken < goal)
            {
                Console.WriteLine($"{goal - stepsTaken} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsTaken - goal} steps over the goal!");
            }
        }
    }
}