namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int numberPuzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numberTruckers = int.Parse(Console.ReadLine());

            double sum = numberPuzzles * 2.60 + talkingDolls * 3 + teddyBears * 4.10 + numberMinions * 8.20 + numberTruckers * 2;
            int numberToys = numberPuzzles + talkingDolls + teddyBears + numberMinions + numberTruckers;
            
            if (numberToys >= 50)
            {
                sum = sum * 0.75;
            }

            double rent = sum * 0.90;
            
            if (rent >= priceTrip)
            {
                double diff = rent - priceTrip;
                Console.WriteLine($"Yes! {diff:F2} lv left.");
            }
            else if (rent < priceTrip)
            {
                double diff = priceTrip - rent;
                Console.WriteLine($"Not enough money! {diff:F2} lv needed.");
            }
        }
    }
}