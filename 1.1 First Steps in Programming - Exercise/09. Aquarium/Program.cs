namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeCm = lengthCm * widthCm * heightCm;

            double volumeInL = volumeCm / 1000;

            double occupiedVolume = volumeInL * (percentage / 100);

            double volumeNeeded = volumeInL - occupiedVolume;

            Console.WriteLine($"{volumeNeeded:F2}");
        }
    }
}