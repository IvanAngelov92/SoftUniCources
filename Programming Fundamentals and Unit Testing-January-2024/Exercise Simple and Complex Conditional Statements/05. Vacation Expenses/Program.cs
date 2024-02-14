string season = Console.ReadLine();
string type = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double result = 0;

switch (season)
{
    case "Spring":
        switch(type)
        {
            case "Hotel":
                result = days * 30 * 0.80;
                break;
            case "Camping":
                result = days * 10 * 0.80;
                break;
        }
        break;
    case "Summer":
        switch (type)
        {
            case "Hotel":
                result = days * 50;
                break;
            case "Camping":
                result = days * 30;
                break;
        }
        break;
    case "Autumn":
        switch (type)
        {
            case "Hotel":
                result = days * 20 * 0.70;
                break;
            case "Camping":
                result = days * 15 * 0.70;
                break;
        }
        break;
    case "Winter":
        switch (type)
        {
            case "Hotel":
                result = days * 40 * 0.90;
                break;
            case "Camping":
                result = days * 10 * 0.90;
                break;
        }
        break;
}

Console.WriteLine($"{result:f2}");
