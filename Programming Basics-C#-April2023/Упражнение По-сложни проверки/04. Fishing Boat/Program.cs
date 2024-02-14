namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherCounter = int.Parse(Console.ReadLine());

            double rentPrice = 0;

            if (season == "Spring")
            {
                rentPrice = 3000;
            }
            else if (season == "Summer")
            {
                rentPrice = 4200;
            }
            else if (season == "Autumn")
            {
                rentPrice = 4200;
            }
            else if (season == "Winter")
            {
                rentPrice = 2600;
            }

            if (fisherCounter <= 6)
            {
                rentPrice = rentPrice * 0.90;
            }
            else if (fisherCounter >= 7 && fisherCounter <= 11)
            {
                rentPrice = rentPrice * 0.85;
            }
            else if (fisherCounter >= 12)
            {
                rentPrice = rentPrice * 0.75;
            }

            if (fisherCounter % 2 == 0 && season != "Autumn") {
                rentPrice = rentPrice * 0.95;
            }

            if (rentPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - rentPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rentPrice - budget:F2} leva.");
            }
        }
    }
}