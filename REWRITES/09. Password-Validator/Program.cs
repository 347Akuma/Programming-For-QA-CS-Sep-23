static bool VerifyPassLength(string pass)
{
    bool validLength = true;
    if (pass.Length < 6 || pass.Length > 10)
    {
        validLength = false;
    }
    return validLength;
}
static bool VerifyPassChars(string pass)
{
    bool validChars = true;
    for (int i = 0; i < pass.Length; i++)
    {
        if (!char.IsLetterOrDigit(pass[i]))
        {
            validChars = false;
            break;
        }
    }
    return validChars;
}
static bool VerifyPassDigits(string pass)
{
    bool atLeastTwo = true;
    int numCount = 0;

    for (int i = 0; i < pass.Length; ++i)
    {
        char current = pass[i];
        if (char.IsDigit(current))
        {
            numCount++;
        }
    }
    if (numCount < 2)
    {
        atLeastTwo = false;
    }
    return atLeastTwo;
}

string password = Console.ReadLine();

if (VerifyPassLength(password) == true && 
    VerifyPassChars(password) == true &&
    VerifyPassDigits(password) == true)
{
    Console.WriteLine("Password is valid");
}

if (VerifyPassLength(password) == false)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (VerifyPassChars(password) == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (VerifyPassDigits(password) == false)
{
    Console.WriteLine("Password must have at least 2 digits");
}