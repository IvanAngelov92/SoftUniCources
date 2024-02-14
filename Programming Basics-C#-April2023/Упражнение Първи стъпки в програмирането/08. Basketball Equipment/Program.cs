namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double sneakers = tax * 0.60;
            double team = sneakers * 0.80;
            double ball = team / 4;
            double accessories = ball / 5;
            double allPrice = tax + sneakers + team + ball + accessories;
            Console.WriteLine(allPrice);
        }
    }
}