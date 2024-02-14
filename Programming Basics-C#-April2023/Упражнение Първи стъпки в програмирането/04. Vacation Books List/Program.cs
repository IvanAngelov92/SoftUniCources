namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PagesInBook = int.Parse(Console.ReadLine());
            int PagesForHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int allTimeForReading = PagesInBook / PagesForHour;
            int hours = allTimeForReading / days;
            Console.WriteLine(hours);
        }
    }
}