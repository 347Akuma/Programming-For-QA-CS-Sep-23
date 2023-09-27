namespace _02._Vowels
{
    internal class Program
    {
        static int calculateVowelsCount(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'u':
                    case 'i':
                        count++;
                        break;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine() ?? "0";

            int vowelCount = calculateVowelsCount(input);

            Console.WriteLine(vowelCount);
        }
    }
}