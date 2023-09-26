namespace _08._OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            double minutesEarly = 0;
            double minutesLate = 0;


            int finalArrival = arrivalHour * 60 + arrivalMinute;
            int finalExam = examHour * 60 + examMinute;

            if (finalArrival > finalExam)
            {
                Console.WriteLine("Late");
                minutesLate = finalArrival - finalExam;
                if (minutesLate < 60)
                {
                    Console.WriteLine($"{minutesLate} minutes after the start");
                }
                else
                {
                    double hours = minutesLate / 60;
                    //double formattedHours = Math.Floor(hours);
                    double minutes = minutesLate % 60;
                    //string formattedMinutes = $"{minutes:D2}";

                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
            }
            else if (finalArrival < finalExam && finalExam - finalArrival > 30)
            {
                Console.WriteLine("Early");
                minutesEarly = finalExam - finalArrival;
                if (minutesEarly < 60)
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
                else
                {
                    double hours = minutesEarly / 60;
                    //double formattedHours = Math.Floor(hours);
                    double minutes = minutesEarly % 60;
                    //string formattedMinutes = $"{minutes:D2}";

                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
            }
            else if (finalArrival <= finalExam)
            {
                Console.WriteLine("On time");
                minutesEarly = finalExam - finalArrival;
                if (minutesEarly <= 30)
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
            }
        }
    }
}