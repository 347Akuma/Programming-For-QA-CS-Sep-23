static int IntMethod(int i1, int i2)
{
    if (i1 > i2)
    {
        return i1;
    }
    else
    {
        return i2;
    }
}

static char CharMethod(char ch1, char ch2)
{
    if (ch1 > ch2)
    {
        return ch1;
    }
    else
    {
        return ch2;
    }
}

static string StringMethod(string s1, string s2)
{
    if (s1.CompareTo(s2) > 0)
    {
        return s1;
    }
    else
    {
        return s2;
    }
}

string input = Console.ReadLine().ToLower();

switch (input)
{
    case "int":
        int i1 = int.Parse(Console.ReadLine());
        int i2 = int.Parse(Console.ReadLine());
        Console.WriteLine(IntMethod(i1, i2));
        break;
    case "char":
        char ch1 = char.Parse(Console.ReadLine());
        char ch2 = char.Parse(Console.ReadLine());
        Console.WriteLine(CharMethod(ch1, ch2));
        break;
    case "string":
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        Console.WriteLine(StringMethod(s1, s2));
        break;
    default:
        break;
}
