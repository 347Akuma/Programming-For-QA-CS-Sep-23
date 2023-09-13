namespace _3._DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depAmt = double.Parse(Console.ReadLine());
            int depTerm = int.Parse(Console.ReadLine());
            double intrsRate = double.Parse(Console.ReadLine());

            double accIntrs = depAmt * (intrsRate / 100);

            double intrsPerMonth = accIntrs / 12;

            double totalAmount = depAmt + depTerm * intrsPerMonth;

            Console.WriteLine(totalAmount);
        }
    }
}