namespace _10._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //FOR LOOP:
            //string studentName = Console.ReadLine();
            //int currentGrade = 1;
            //int failCount = 0;
            //bool isExpelled = false;
            //double totalMarks = 0;

            //for (int i = 1; i <= 12; i++)
            //{
            //    double currentMark = double.Parse(Console.ReadLine());

            //    if (currentMark < 4.00)
            //    {
            //        failCount++;

            //        if (failCount > 1)
            //        {
            //            isExpelled = true;                       
            //            break;
            //        } 

            //    }
            //    else if (currentMark >= 4.00)
            //    {
            //        totalMarks += currentMark;
            //        currentGrade++;
            //    }
            //}

            //if (isExpelled == false)
            //{
            //    double avg = (totalMarks / 12);
            //    Console.WriteLine($"{studentName} graduated. Average grade: {avg:F2}");
            //}
            //else
            //{
            //    Console.WriteLine($"{studentName} has been excluded at {currentGrade} grade");
            //}


            // WHILE-LOOP:
            string studentName = Console.ReadLine();
            int currentYear = 1;
            double totalGrades = 0;
            bool isExpelled = false;
            int failures = 0;

            while (currentYear <= 12)
            {
                double currentMark = double.Parse(Console.ReadLine());

                if (currentMark < 4.00)
                {
                    failures++;

                    if (failures > 1)
                    {
                        isExpelled = true;
                        break;
                    }
                }
                else if (currentMark >= 4.00)
                {
                    totalGrades += currentMark;
                    currentYear++;
                }
            }

            if (isExpelled == false)
            {
                double avg = totalGrades / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {avg:F2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {currentYear} grade");
            }
           
        }
    }
}