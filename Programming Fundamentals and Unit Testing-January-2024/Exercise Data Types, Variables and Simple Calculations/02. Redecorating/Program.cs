int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int quantity = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonAmount = (nylon + 2) * 1.50;
double amounForPaint = (paint * 1.10) * 14.50;
double amountForThinner = quantity * 5;
double totalAmountForMaterials = nylonAmount + amounForPaint + amountForThinner + 0.40;
double amounthForCraftsmen = (totalAmountForMaterials * 0.30) * hours;
double totalAmounth = totalAmountForMaterials + amounthForCraftsmen;

Console.WriteLine($"{totalAmounth}");
