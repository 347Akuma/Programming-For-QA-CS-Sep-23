List<int> integers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse) // read the List from the initial input
    .ToList();

string command; // declare command

while ((command = Console.ReadLine()) != "end") // read command from input
{
    string[] tokens = command.Split(); // take each space of input in an array

    if (tokens[0] == "Delete")
    {
        int elementToDelete = int.Parse(tokens[1]); // take expected number (element) after the command
        integers.RemoveAll(number => number == elementToDelete); // take each number in the list, check if it matches the one to delete, remove it from the list altogether
    }
    else if (tokens[0] == "Insert") 
    {
        int elementToInsert = int.Parse(tokens[1]); // take first expected number (element)
        int indexToInsert = int.Parse(tokens[2]); // take second expected number (index)

        integers.Insert(indexToInsert, elementToInsert); // insert the number to the index
    }    
}
Console.WriteLine(string.Join(" ", integers)); // printer