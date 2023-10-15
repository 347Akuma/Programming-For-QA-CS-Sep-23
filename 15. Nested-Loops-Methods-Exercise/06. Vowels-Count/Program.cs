static int VowelsCounter(string text)
{
    int vowels = 0;

    for (int i = 0; i < text.Length; i++)
    {
        switch (text[i])
        {
            case 'a':
            case 'e':
            case 'o':
            case 'u':
            case 'i':
                vowels++;
                break;
        }
    }
    return vowels;
}
string text = Console.ReadLine().ToLower();
Console.WriteLine(VowelsCounter(text));