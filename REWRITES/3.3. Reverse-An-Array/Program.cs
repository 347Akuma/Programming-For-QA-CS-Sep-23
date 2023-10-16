int length = int.Parse(Console.ReadLine());

int[] numArr = new int[length];

for (int i = 0; i < length; i++)
{
    numArr[i] = int.Parse(Console.ReadLine());
}

for (int i = length - 1; i >= 0; i--)
{
    Console.Write(numArr[i] + " ");
}