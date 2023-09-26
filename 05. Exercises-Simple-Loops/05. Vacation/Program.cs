namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int totalDays = 0;
            int spendDays = 0;

            bool cannotSave = false; // flag

            while (availableMoney < moneyNeeded && spendDays < 5)
            {
                totalDays++;

                string action = Console.ReadLine();
                double givenAmount = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    availableMoney = Math.Abs(availableMoney - givenAmount);
                    spendDays++;
                    if (spendDays == 5)
                    {
                        cannotSave = true;
                        break;
                    }
                }
                else if (action == "save")
                {
                    availableMoney += givenAmount;
                    spendDays--;
                    if (availableMoney >= moneyNeeded)
                    {
                        break;
                    }
                }
            }
            if (cannotSave == true)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }

}
