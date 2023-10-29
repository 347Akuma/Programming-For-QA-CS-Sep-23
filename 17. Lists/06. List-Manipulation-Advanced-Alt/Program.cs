using System.Data;

List<int> numbers = Console.ReadLine()
.Split(" ")
.Select(int.Parse)
.ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{


    if (command.StartsWith("Contains"))
    //1. command = "Contains {num}"
    {
        int numContained = int.Parse(command.Split(" ")[1]);
        // create arr of 'command', take second index turn it into int - this is the number to check

        if (numbers.Contains(numContained))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    //2. command = "PrintEven"
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); // new line after the even list
    }
    else if (command == "PrintOdd")
    //3. command = "PrintOdd"
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); // new line after the odd list
    }
    else if (command == "GetSum")
    //5. command = "GetSum"
    {
        Console.WriteLine(numbers.Sum()); // "<list>.Sum" sums all elements for us
    }
    else if (command.StartsWith("Filter"))
    //5. command = "Filter <cond> {num}"
    {
        string operation = command.Split(" ")[1];
        int num = int.Parse(command.Split(' ')[2]);

        switch (operation)
        {
            case "<":
                numbers.RemoveAll(numberInList => numberInList >= num);
                break;
            case ">":
                numbers.RemoveAll(numberInList => numberInList <= num);
                break;
            case "<=":
                numbers.RemoveAll(numberInList => numberInList > num);
                break;
            case ">=":
                numbers.RemoveAll(numberInList => numberInList < num);
                break;
        }
    }
    Console.WriteLine(string.Join(" ", numbers));
}