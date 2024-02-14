string product = Console.ReadLine();
string day = Console.ReadLine();

double result = 0;

switch (product)
{
    case "Banana":
        switch (day)
        {
            case "Weekday":
                result = 2.50;
                Console.WriteLine($"{result:f2}");
                break;
            case "Weekend":
                result = 2.70;
                Console.WriteLine($"{result:f2}");
                break;
        }
        break;
    case "Apple":
        switch (day)
        {
            case "Weekday":
                result = 1.30;
                Console.WriteLine($"{result:f2}");
                break;
            case "Weekend":
                result = 1.60;
                Console.WriteLine($"{result:f2}");
                break;
        }
        break;
    case "Kiwi":
        switch (day)
        {
            case "Weekday":
                result = 2.20;
                Console.WriteLine($"{result:f2}");
                break;
            case "Weekend":
                result = 3.00;
                Console.WriteLine($"{result:f2}");
                break;
        }
        break;
}