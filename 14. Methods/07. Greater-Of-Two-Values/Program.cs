namespace _07._Greater_Of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(CaseInt(a, b));
                    break;
                case "char":
                    char one = char.Parse(Console.ReadLine());
                    char two = char.Parse(Console.ReadLine());
                    Console.WriteLine(CaseChar(one, two));
                    break;
                case "string":
                    string first = Console.ReadLine();
                    string second = Console.ReadLine();
                    Console.WriteLine(CaseString(first, second));
                    break;
                default:
                    break;
            }
        }

        static int CaseInt(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }

        static char CaseChar(char one, char two)
        {
            if (one > two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }

        static string CaseString(string first, string second)
        {
            if (first.Length > second.Length)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}