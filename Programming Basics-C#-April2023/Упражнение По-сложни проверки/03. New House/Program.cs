namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCounter = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double finalSum = 0.0;

            switch (flowerType)
            {
                case "Roses":
                    finalSum = flowerCounter * 5;
                    if (flowerCounter > 80)
                    {
                        finalSum *= 0.9;
                    }
                    break;
                case "Dahlias":
                    finalSum = flowerCounter * 3.80;
                    if (flowerCounter > 90)
                    {
                        finalSum *= 0.85;
                    }
                    break;
                case "Tulips":
                    finalSum = flowerCounter * 2.80;
                    if (flowerCounter > 80)
                    {
                        finalSum *= 0.85;
                    }
                    break;
                case "Narcissus":
                    finalSum = flowerCounter * 3;
                    if (flowerCounter < 120)
                    {
                        finalSum *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    finalSum = flowerCounter * 2.50;
                    if (flowerCounter < 80)
                    {
                        finalSum *= 1.20;
                    }
                    break;
            }

            if (budget >= finalSum)
            {
                double diff = budget - finalSum;
                Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {flowerType} and {diff:F2} leva left.");
            }
            else
            {
                double diff = finalSum - budget;
                Console.WriteLine($"Not enough money, you need {diff:F2} leva more.");
            }
        }
    }
}