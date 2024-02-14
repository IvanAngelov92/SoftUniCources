namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            double result = 0.0;

            if(city == "Sofia")
            {
                if(number > 0 && number <= 500)
                {
                    result = (number * 5) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if(number > 500 && number <= 1000)
                {
                    result = (number * 7) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 1000 && number <= 10000) {
                    result = (number * 8) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 10000)
                {
                    result = (number * 12) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(city == "Varna")
            {
                if (number > 0 && number <= 500)
                {
                    result = (number * 4.5) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 500 && number <= 1000)
                {
                    result = (number * 7.5) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 1000 && number <= 10000)
                {
                    result = (number * 10) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 10000)
                {
                    result = (number * 13) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(city == "Plovdiv")
            {
                if (number > 0 && number <= 500)
                {
                    result = (number * 5.5) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 500 && number <= 1000)
                {
                    result = (number * 8) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 1000 && number <= 10000)
                {
                    result = (number * 12) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else if (number > 10000)
                {
                    result = (number * 14.5) / 100;
                    Console.WriteLine($"{result:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}