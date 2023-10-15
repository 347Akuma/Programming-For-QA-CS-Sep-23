string numbers = Console.ReadLine();

string[] arr = numbers.Split(" ");

int[] newArr = new int[arr.Length];

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    int curr = int.Parse(arr[i]);
    sum += curr;
}
Console.WriteLine(sum);