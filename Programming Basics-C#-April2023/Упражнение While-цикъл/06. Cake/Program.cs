namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int sum = length * width;
            
            while (sum >= 0)
            {
                string numbers = Console.ReadLine();

                if (numbers != "STOP")
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
                Console.WriteLine($"{sum} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {-sum} pieces more.");
            }
        }
    }
}