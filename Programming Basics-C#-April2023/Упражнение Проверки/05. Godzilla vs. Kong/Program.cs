namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistCount = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;
            double priceForAllStatists = statistCount * clothesPrice;

            if(statistCount > 150)
            {
                priceForAllStatists = priceForAllStatists * 0.9;
            }

            double total = priceForAllStatists + decorPrice;

            if(total > budget)
            {
                double diff = total - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diff:F2} leva more.");
            }
            else
            {
                double diff = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:F2} leva left.");
            }
        }
    }
}