double depositedAmount = double.Parse(Console.ReadLine());
int termOfTheDeposit = int.Parse(Console.ReadLine());
double rate = double.Parse(Console.ReadLine());

double interest = (depositedAmount * rate) / 100;
double interestForMonth = interest / 12;
double total = depositedAmount + (termOfTheDeposit * interestForMonth);

Console.WriteLine($"{total}");