namespace _05._Sum_Of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());

            int numbersSum = 0;

            while (numbersSum < targetSum)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbersSum += currentNumber;

            }
            Console.WriteLine(numbersSum);
        }
    }
}
//FOR - LOOP SOLUTION(RETARDED BUT IT WORKS)
//int targetSum = int.Parse(Console.ReadLine());

//int numbersSum = 0; // we will get this sum without the max

//for (int i = 1; i <= targetSum; i++)
//{
//    int currentNumber = int.Parse(Console.ReadLine());

//    numbersSum += currentNumber;

//    if (numbersSum >= targetSum)
//    {
//        Console.WriteLine(numbersSum);
//        break;
//    }
//    else
//    {
//        continue;
//    }
//}