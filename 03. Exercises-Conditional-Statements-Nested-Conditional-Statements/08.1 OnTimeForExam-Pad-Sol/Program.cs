namespace _08._1_OnTimeForExam_Pad_Sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int minutesEarly = 0;

            int finalArrival = arrivalHour * 60 + arrivalMinute;
            int finalExam = examHour * 60 + examMinute;

            if (finalArrival > finalExam)
            {
                Console.WriteLine("Late");
                minutesEarly = finalArrival - finalExam;
                if (minutesEarly < 60)
                {
                    Console.WriteLine($"{minutesEarly} minutes after the start");
                }
                else
                {
                    int hours = minutesEarly / 60;
                    int minutes = minutesEarly % 60;
                    string formattedMinutes = minutes.ToString().PadLeft(2, '0');
                    Console.WriteLine($"{hours}:{formattedMinutes} hours after the start");
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
                    int hours = minutesEarly / 60;
                    int minutes = minutesEarly % 60;
                    string formattedMinutes = minutes.ToString().PadLeft(2, '0');
                    Console.WriteLine($"{hours}:{formattedMinutes} hours before the start");
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

