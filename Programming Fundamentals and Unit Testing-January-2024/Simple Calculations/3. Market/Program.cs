double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double tomatos = tomatoPrice * tomatoQuantity;
double cucumber = cucumberPrice * cucumberQuantity;
double totalCost = tomatos + cucumber;

Console.WriteLine($"{totalCost:f2}");