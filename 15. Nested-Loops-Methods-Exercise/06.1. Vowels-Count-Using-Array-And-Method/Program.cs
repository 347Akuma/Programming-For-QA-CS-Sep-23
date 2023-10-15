static int VowelsCounter(string text)
{
    int vowels = 0;
    char[] target = { 'a', 'e', 'o', 'u', 'i' };

    for (int i = 0; i < text.Length; i++)
    {
        char curr = text[i];

        for (int j = 0; j < target.Length; j++)
        {
            if (curr == target[j])
            {
                vowels++;
                break; 
            }
        }
    }
    return vowels;
}
string text = Console.ReadLine().ToLower();
Console.WriteLine(VowelsCounter(text));
