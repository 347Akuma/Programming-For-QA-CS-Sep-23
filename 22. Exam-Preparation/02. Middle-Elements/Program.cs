List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();


int firstMiddle = numbers[(numbers.Count / 2) - 1];
int secondMiddle = numbers[numbers.Count / 2];


double avgTotal = (double)(firstMiddle + secondMiddle) / 2;

Console.WriteLine($"{avgTotal:f2}");