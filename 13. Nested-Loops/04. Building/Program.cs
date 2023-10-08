namespace _04._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            for (int currFloor = floors; currFloor >= 1; currFloor--) // go through each floor desc
            {
                for (int currApart = 0; currApart < apartments; currApart++) //goto through each apart desc
                {
                    if (currFloor == floors)
                    {
                        Console.Write($"L{currFloor}{currApart} ");
                    }
                    else if (currFloor % 2 == 0)
                    {
                        Console.Write($"O{currFloor}{currApart} ");
                    }
                    else
                    {
                        Console.Write($"A{currFloor}{currApart} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}