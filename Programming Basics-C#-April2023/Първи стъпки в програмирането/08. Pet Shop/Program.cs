namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double foodFoorDog = dogFood * 2.50;
            double foodFoorCat = catFood * 4;

            double allSum = foodFoorDog + foodFoorCat;
            Console.WriteLine($"{allSum} lv.");
        }
    }
}