namespace _04._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int poorGradesCounter = 0;
            int solvedProblems = 0;
            double totalGrades = 0;
            bool hasFailed = false;
            string lastProblem = "";

            int poorGradesMax = int.Parse(Console.ReadLine());
            string currentProblem;

            while ((currentProblem = Console.ReadLine()) != "Enough")
            {
                int currentGrade = int.Parse(Console.ReadLine());

                if (currentGrade <= 4)
                {
                    poorGradesCounter++;
                    if (poorGradesCounter == poorGradesMax)
                    {
                        hasFailed = true;
                        break;
                    }
                }
                lastProblem = currentProblem;
                totalGrades += currentGrade;
                solvedProblems++;
            }
            if (hasFailed == true)
            {
                Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");
            }
            else
            {
                double avg = totalGrades / solvedProblems;
                Console.WriteLine($"Average score: {avg:F2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }
        }
    }
}