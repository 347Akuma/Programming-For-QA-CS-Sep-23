static bool CheckPassLength(string pass)
{
    bool validLength = true;
    if (pass.Length < 6 || pass.Length > 10)
    {
        validLength = false;
    }
    return validLength;
}

static bool CheckSpecialChars(string pass)
{
    bool noSpecialChars = true;

    for (int i = 0; i < pass.Length; i++)
    {
        char c = pass[i];

        if (!char.IsLetterOrDigit(c))
        {
            noSpecialChars = false;
            break;
        }
    }
    return noSpecialChars;
}

static bool CheckMinDigits(string pass)
{
    bool atLeastTwo = false;
    int numCount = 0;

    for (int i = 0; i < pass.Length; i++)
    {
        char current = pass[i];

        if (char.IsDigit(current))
        {
            numCount++;
        }
    }
    if (numCount >= 2)
    {
        atLeastTwo = true;
    }
    else
    {
        atLeastTwo = false;
    }
    return atLeastTwo;
}

string password = Console.ReadLine().ToLower();

if (CheckPassLength(password) == true && CheckMinDigits(password) == true && CheckSpecialChars(password) == true)
{
    Console.WriteLine("Password is valid");
}

if (CheckPassLength(password) == false)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (CheckSpecialChars(password) == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (CheckMinDigits(password) == false)
{
    Console.WriteLine("Password must have at least 2 digits");
}

