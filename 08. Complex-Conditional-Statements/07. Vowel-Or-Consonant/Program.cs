namespace _07._Vowel_Or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

           char myLetter = char.ToLower(letter);

            switch (myLetter)
            {
                case 'a':
                case 'o':
                case 'u':
                case 'e':
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}