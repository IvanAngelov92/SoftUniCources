string ticketType = Console.ReadLine();
double price = 0;

switch (ticketType)
{
    case "student":
        price = 1;
        Console.WriteLine($"${price:f2}");
        break;
    case "regular":
        price = 1.60;
        Console.WriteLine($"${price:f2}");
        break;
    default:
        Console.WriteLine("Invalid ticket type!");
        break;
}