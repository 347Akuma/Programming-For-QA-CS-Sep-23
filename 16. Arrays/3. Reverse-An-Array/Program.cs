int length = int.Parse(Console.ReadLine()); // read the length of the array we're about to create

int[] newArr = new int[length]; // create new array with the received length

for (int i = 0; i < length; i++) // loop through the length from the start
{
    newArr[i] = int.Parse(Console.ReadLine()); // read each new array element from the console
}
for (int j = length - 1; j >= 0; j--) // loop through the received length in reverse
{
    Console.Write(newArr[j] + " "); // print the current element from the created array, starting from the last index
}
