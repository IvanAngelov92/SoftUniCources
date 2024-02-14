namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberProcessors = int.Parse(Console.ReadLine());
            int numberRams = int.Parse(Console.ReadLine());

            int sumVideoCards = numberVideoCards * 250;
            
            double priceForProcesor = sumVideoCards * 0.35;
            double sumForProcessors = numberProcessors * priceForProcesor;

            double priceForRam = sumVideoCards * 0.10;
            double sumForRam = numberRams * priceForRam;

            double allSum = sumVideoCards + sumForProcessors + sumForRam;
            
            if(numberVideoCards > numberProcessors)
            {
                allSum = allSum * 0.85;
            }

            if(allSum <= budget)
            {
                double diff = budget - allSum;
                Console.WriteLine($"You have {diff:F2} leva left!");
            }
            else
            {
                double diff = allSum - budget;
                Console.WriteLine($"Not enough money! You need {diff:F2} leva more!");
            }
        }
    }
}