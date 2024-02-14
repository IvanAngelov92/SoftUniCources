namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumForNylon = (nylon + 2) * 1.50;
            double sumForPaint = (paint * 1.10) * 14.50;
            double sumForThinner = thinner * 5;
            double sumForAllMaterials = sumForPaint + sumForNylon + sumForThinner + 0.40;
            double sumForWorkers = (sumForAllMaterials * 0.30) * hours;
            double finalSum = sumForAllMaterials + sumForWorkers;
            Console.WriteLine($"{finalSum}");
        }
    }
}