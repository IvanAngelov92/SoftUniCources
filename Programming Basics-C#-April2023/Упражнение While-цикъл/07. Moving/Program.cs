namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int sum = width * length * height;

            while (sum >= 0)
            {
                string numbers = Console.ReadLine();

                if (numbers != "Done")
                {
                    sum -= int.Parse(numbers);
                }
                else
                {
                    break;
                }
            }

            if (sum >= 0)
            {
                Console.WriteLine($"{sum} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(sum)} Cubic meters more.");
            }
        }
    }
}