using System.Text;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;
            double discountStudio = 0;
            double discountApartament = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApartment = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceApartment = 77;
                    break;
            }

            if (nights > 14 && (month == "May" || month == "October")) {
                discountStudio = 0.3;
            } else if (nights > 14 && (month == "June" || month == "September")) {
                discountStudio = 0.2;
            } else if (nights > 7 && (month == "May" || month == "October")) {
                discountStudio = 0.05;
            }

            if (nights > 14)
            {
                discountApartament = 0.1;
            }

            double finalStudioPrice = priceStudio * nights * (1 - discountStudio);
            double finalApartmentPrice = priceApartment * nights * (1 - discountApartament);

            Console.WriteLine($"Apartment: {finalApartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {finalStudioPrice:F2} lv.");
        }
    }
}