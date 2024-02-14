namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double fixPercent = percent / 100;

            double capacity = length * width * height;
            double capacityInLeters = capacity / 1000;
            double neededLeters = capacityInLeters * (1 - fixPercent);
            Console.WriteLine(neededLeters);
        }
    }
}