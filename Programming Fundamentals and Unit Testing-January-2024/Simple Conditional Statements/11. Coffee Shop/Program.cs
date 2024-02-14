string drink = Console.ReadLine();
string extra = Console.ReadLine();

double finalPrice = 0;

switch (drink)
{
    case "coffee":
        switch (extra)
        {
            case "sugar":
                finalPrice = 1.00 + 0.40;
                break;
            case "no":
                finalPrice = 1;
                break;
        }
        break;
    case "tea":
        switch (extra)
        {
            case "sugar":
                finalPrice = 0.60 + 0.40;
                break;
            case "no":
                finalPrice = 0.60;
                break;
        }
        break;
}

Console.WriteLine($"Final price: ${finalPrice:f2}");