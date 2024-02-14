string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

Orders(product, quantity);

static void Orders(string product, int quantity)
{
    double result = 0;
    switch (product)
    {
        case "coffee":
            result = quantity * 1.50;
            break;
        case "water":
            result = quantity * 1.00;
            break;
        case "coke":
            result = quantity * 1.40;
            break;
        case "snacks":
            result = quantity * 2.00;
            break;
    }

    Console.WriteLine($"{result:f2}");
}
