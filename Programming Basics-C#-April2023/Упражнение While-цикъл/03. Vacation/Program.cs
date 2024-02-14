namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            int counterDays = 0;
            int counterDaysSpending = 0;

            while (money < neededMoney && counterDaysSpending < 5)
            {
                string opportunity = Console.ReadLine();
                double moneyForTheDay = double.Parse(Console.ReadLine());
                counterDays += 1;

                switch (opportunity)
                {
                    case "spend":
                        counterDaysSpending
                        if (money - moneyForTheDay < 0)
                        {
                            money = 0;
                        }
                        else
                        {
                            money -= moneyForTheDay;
                        }
                        break;
                    case "save":
                        money += moneyForTheDay;
                        counterDaysSpending = 0;
                        break;
                }
                
                if (counterDaysSpending == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(counterDays);
                }

                if (money >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {counterDays} days.");
                }
            }
        }
    }
}