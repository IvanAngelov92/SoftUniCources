namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            double result = 0.0;
            if (city == "Sofia")
            {
                if(product == "coffee")
                {
                    result = number * 0.50;
                }
                else if (product == "water")
                {
                    result = number * 0.80;
                }
                else if (product == "beer")
                {
                    result = number * 1.20;
                }
                else if (product == "sweets")
                {
                    result = number * 1.45;
                }
                else if (product == "peanuts")
                {
                    result = number * 1.60;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    result = number * 0.40;
                }
                else if (product == "water")
                {
                    result = number * 0.70;
                }
                else if (product == "beer")
                {
                    result = number * 1.15;
                }
                else if (product == "sweets")
                {
                    result = number * 1.30;
                }
                else if (product == "peanuts")
                {
                    result = number * 1.50;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    result = number * 0.45;
                }
                else if (product == "water")
                {
                    result = number * 0.70;
                }
                else if (product == "beer")
                {
                    result = number * 1.10;
                }
                else if (product == "sweets")
                {
                    result = number * 1.35;
                }
                else if (product == "peanuts")
                {
                    result = number * 1.55;
                }
            }

            Console.WriteLine(result);
        }
    }
}