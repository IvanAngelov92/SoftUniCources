double foodForDog = double.Parse(Console.ReadLine());
double foodForCat = double.Parse(Console.ReadLine());

double sumFoodForDog = foodForDog * 2.50;
double sumFoodForCat = foodForCat * 4;
double sumAllFood = sumFoodForDog + sumFoodForCat;
Console.WriteLine($"{sumAllFood:f2} lv.");