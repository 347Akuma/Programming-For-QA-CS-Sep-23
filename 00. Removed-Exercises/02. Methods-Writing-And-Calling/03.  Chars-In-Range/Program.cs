namespace _03.__Chars_In_Range
{
    internal class Program
    {
        // Method to print characters between two characters based on ASCII
        static void Main()
        {
            char firstChar = Console.ReadLine()[0]; // Read the first character            
            char secondChar = Console.ReadLine()[0]; // Read the second character

            PrintCharactersInRange(firstChar, secondChar); // Call the method
        }

        static void PrintCharactersInRange(char start, char end)
        {
            // Swap characters if end < start
            if (end < start)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            // Print characters from start to end
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); // Print a newline after all characters are printed
        }
    }
}