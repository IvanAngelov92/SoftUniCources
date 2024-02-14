namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int termOfDeposite = int.Parse(Console.ReadLine());
            double percentForYear = double.Parse(Console.ReadLine());

            double interest = (depositSum * percentForYear) / 100;
            double interestForMonth = interest / 12;
            double allSum = depositSum + termOfDeposite * interestForMonth;
            Console.WriteLine(allSum);
            
        }
    }
}