namespace _08._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            // store total cake pieces from start
            int totalCakePieces = cakeWidth * cakeLength;

            while (totalCakePieces >= 0) // loop until no more pieces left
            {
                string input = Console.ReadLine(); //read input

                if (input == "STOP") // check if input is stop
                {
                    break;
                }
                totalCakePieces -= int.Parse(input); // if input is a number substract it from total cake pieces
            }
            if (totalCakePieces > 0) // check if there are remaining pieces
            {
                Console.WriteLine($"{totalCakePieces} pieces are left."); // print remainder
            }
            else // not enough pieces 
            {
                Console.WriteLine($"No more cake left! You need {-totalCakePieces} pieces more."); // print outstanding pieces
            }
        }
    }
}