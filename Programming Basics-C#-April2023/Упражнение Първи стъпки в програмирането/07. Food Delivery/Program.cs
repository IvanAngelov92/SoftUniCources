namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double priceForChickenMenus = chickenMenus * 10.35;
            double priceForFishMenus = fishMenus * 12.40;
            double priceForVegetarianMenus = vegetarianMenus * 8.15;
            double allPriceForMenus = priceForChickenMenus + priceForFishMenus + priceForVegetarianMenus;
            double priceForDesert = allPriceForMenus * 0.20;
            double allPriceForOrder = allPriceForMenus + priceForDesert + 2.50;
            Console.WriteLine($"{allPriceForOrder}");
        }
    }
}