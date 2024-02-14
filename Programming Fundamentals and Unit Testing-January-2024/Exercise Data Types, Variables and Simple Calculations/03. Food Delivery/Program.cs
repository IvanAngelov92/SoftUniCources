int chickenMenus = int.Parse(Console.ReadLine());
int menusWithFish = int.Parse(Console.ReadLine());
int vegetarianMenus = int.Parse(Console.ReadLine());

double priceForChickenMenus = chickenMenus * 10.35;
double priceForTheMenusWithFish = menusWithFish * 12.40;
double priceForVegetarianMenus = vegetarianMenus * 8.15;
double totalCost = priceForChickenMenus + priceForTheMenusWithFish + priceForVegetarianMenus;
double priceOfDessert = (totalCost * 20) / 100;
double totalOrderPrice = totalCost + priceOfDessert + 2.50;

Console.WriteLine($"{totalOrderPrice}");