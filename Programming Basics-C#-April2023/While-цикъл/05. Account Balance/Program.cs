namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;

            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);
                
                if(money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += money;
                Console.WriteLine($"Increase: {money:F2}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}