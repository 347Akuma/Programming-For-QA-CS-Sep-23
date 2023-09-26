namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());

            double totalGrades = 0;
            int gradesNum = 0;

            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                double totalPresGrades = 0;
                for (int i = 1; i <= juryMembers; i++)
                {
                    double currGrade = double.Parse(Console.ReadLine());
                    totalPresGrades += currGrade;
                    totalGrades += currGrade;
                    gradesNum++;
                }
                double presAvg = (double)totalPresGrades / juryMembers;
                Console.WriteLine($"{input} - {presAvg:F2}.");
            }
            double totalAvg = totalGrades / gradesNum;
            Console.WriteLine($"Student's final assessment is {totalAvg:F2}.");
        }
    }
}