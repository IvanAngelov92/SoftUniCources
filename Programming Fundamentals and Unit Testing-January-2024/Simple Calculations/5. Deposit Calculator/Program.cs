double depositedAmounth = double.Parse(Console.ReadLine());
double termOfTheDeposit = double.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double accumulatedInterest = (depositedAmounth * annualInterestRate) / 100;
double interestForMonth = accumulatedInterest / 12;
double totalAmounth = depositedAmounth + termOfTheDeposit * interestForMonth;

Console.WriteLine($"{totalAmounth}");