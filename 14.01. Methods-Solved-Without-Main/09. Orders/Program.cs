static double CalculateOrderTotal(string product, int quantity)
{
    double price = 0;
    switch (product)
    {
        case "coffee": price = 1.50 * quantity; break;
        case "water": price = 1.00 * quantity; break;
        case "coke": price = 1.40 * quantity; break;
        case "snacks": price = 2.00 * quantity; break;
    }
    return price;
}

string product = Console.ReadLine().ToLower();
int quantity = int.Parse(Console.ReadLine());

Console.WriteLine($"{CalculateOrderTotal(product, quantity):f2}");