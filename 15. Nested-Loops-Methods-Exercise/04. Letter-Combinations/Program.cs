char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char xcluded = char.Parse(Console.ReadLine());

int combCount = 0;

for (char letter1 = start; letter1 <= end; letter1++)
{
    for (char letter2 = start; letter2 <= end; letter2++)
    {
        for (char letter3 = start; letter3 <= end; letter3++)
        {
            if (letter1 != xcluded && letter2 != xcluded && letter3 != xcluded)
            {
                combCount++;
                Console.Write($"{letter1}{letter2}{letter3} ");               
            }        
        }
    }    
}
Console.WriteLine();
Console.WriteLine(combCount);
