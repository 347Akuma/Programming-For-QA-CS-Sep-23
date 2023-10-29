List<int> numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] command = input.Split(" ");

    if (command[0] == "Add")
    {
        int numToAdd = int.Parse(command[1]);
        numbers.Insert(numbers.Count, numToAdd);
    }
    else if (command[0] == "Remove")
    {
        int numToRemove = int.Parse(command[1]);
        numbers.Remove(numToRemove);
    }
    else if (command[0] == "RemoveAt")
    {    
        int indexToRemove = int.Parse(command[1]);       
        numbers.RemoveAt(indexToRemove);
    }
    else if (command[0] == "Insert")
    {
        int numToAdd = int.Parse(command[1]);
        int indexToAdd = int.Parse(command[2]);

        numbers.Insert(indexToAdd, numToAdd);
    }
}

Console.WriteLine(string.Join(" ", numbers));