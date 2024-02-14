string type = Console.ReadLine();
int countRows = int.Parse(Console.ReadLine());
int countSeats = int.Parse(Console.ReadLine());

double totalCount = 0;
double totalPrice = 0;

switch (type)
{
    case "Normal":
        totalCount = countRows * countSeats;
        totalPrice = totalCount * 7.50;
        break;
    case "Premiere":
        totalCount = countRows * countSeats;
        totalPrice = totalCount * 12.00;
        break;
    case "Discount":
        totalCount = countRows * countSeats;
        totalPrice = totalCount * 5.00;
        break;
}

Console.WriteLine($"{totalPrice:f2}");