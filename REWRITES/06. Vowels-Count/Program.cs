string text = Console.ReadLine().ToLower();
Console.WriteLine(CalculateVowels(text));

static int CalculateVowels(string text)
{
    int vowels = 0;
    char[] chars = { 'a', 'e', 'o', 'u', 'i' };

    for (int i = 0; i < text.Length; i++)
    {
        char c = text[i];

        if (chars.Contains(c))
        {
            vowels++;
        }
    }
    return vowels;
}