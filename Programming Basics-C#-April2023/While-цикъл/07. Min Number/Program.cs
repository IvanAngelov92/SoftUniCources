namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int numbers = int.Parse(input);

                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}