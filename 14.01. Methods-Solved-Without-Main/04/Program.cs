int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int area = CalculateRectArea(width, length);

Console.WriteLine(area);

static int CalculateRectArea(int width, int length)
{
    return width * length;
}