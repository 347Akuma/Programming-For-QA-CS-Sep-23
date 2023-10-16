int n = int.Parse(Console.ReadLine());

string[] days = { 
    "Monday", // 0
    "Tuseday", // 1
    "Wednesday", // 2
    "Thursday", // 3
    "Friday", // 4 
    "Saturday", // 5 
    "Sunday" // 6
};


if (n >= 1 && n <= 7)
{
    Console.WriteLine(days[n - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}
