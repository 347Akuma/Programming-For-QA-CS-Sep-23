List<int> numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] command = input.Split(" ");

    if (command[0] == "Contains")
    {
        int numToCheck = int.Parse(command[1]);

        if (numbers.Contains(numToCheck))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command[0] == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
    }
    else if (command[0] == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
    }
    else if (command[0] == "GetSum")
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine(sum);
    }
    else if (command[0] == "Filter")
    {
        int toCompare = int.Parse(command[2]);
        string cond = command[1];
        List<int> filteredNums = new List<int>();
        foreach (int number in numbers)
        {
            switch (cond)
            {
                case "<":
                    if (number < toCompare)
                        filteredNums.Add(number);
                    break;
                case ">":
                    if (number > toCompare)
                        filteredNums.Add(number);
                    break;
                case ">=":
                    if (number >= toCompare)
                        filteredNums.Add(number);
                    break;
                case "<=":
                    if (number <= toCompare)
                        filteredNums.Add(number);
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", filteredNums));
    }
}
Console.WriteLine(string.Join(" ", numbers));