namespace _04_Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                string input = letter.ToString();
                string transform = input.ToLower();

                switch (transform)
                {
                    case "a": sum += 1; break;
                    case "e": sum += 2; break;
                    case "i": sum += 3; break;
                    case "o": sum += 4; break;
                    case "u": sum += 5; break;
                    default: break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}