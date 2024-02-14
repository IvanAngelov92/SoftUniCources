int NumberOfPackagesOfPens = int.Parse(Console.ReadLine());
int NumberOfPacketsOfMarkers = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double priceOfPackagesOfPens = NumberOfPackagesOfPens * 5.80;
double priceOfMarkerPackages = NumberOfPacketsOfMarkers * 7.20;
double priceOfTheBoardCleaner = litersOfBoardCleaner * 1.20;
double allPrice = priceOfPackagesOfPens + priceOfMarkerPackages + priceOfTheBoardCleaner;
double priceAfterDiscount = allPrice - (allPrice * discountPercentage) / 100;

Console.WriteLine($"{priceAfterDiscount}");