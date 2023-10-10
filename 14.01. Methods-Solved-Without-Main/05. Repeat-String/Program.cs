string text = Console.ReadLine();
int repetition = int.Parse(Console.ReadLine());

Console.Write(RepeatString(text, repetition));
static string RepeatString(string text, int repetition)
{
    string newString = "";
    for (int i = 0; i < repetition; i++)
    {
        newString += text;
    }
    return newString;
}
