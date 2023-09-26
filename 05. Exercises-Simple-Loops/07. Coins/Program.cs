namespace _07._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toReturn = double.Parse(Console.ReadLine());
            int coinsUsed = 0;
            double changeInSt = 2.00;


            while (toReturn != 0)
            {
                if (toReturn >= changeInSt)
                {
                    coinsUsed++;
                    toReturn = Math.Round(toReturn - changeInSt, 2);
                }
                else
                {
                    switch (changeInSt)
                    {
                        case 2.00: changeInSt = 1.00; break;
                        case 1.00: changeInSt = 0.50; break;
                        case 0.50: changeInSt = 0.20; break;
                        case 0.20: changeInSt = 0.10; break;
                        case 0.10: changeInSt = 0.05; break;
                        case 0.05: changeInSt = 0.02; break;
                        case 0.02: changeInSt = 0.01; break;
                        case 0.01: changeInSt = 0.00; break;

                    }
                }
            }
            Console.WriteLine(coinsUsed);
        }
    }
}