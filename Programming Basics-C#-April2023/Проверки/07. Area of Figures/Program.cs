namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "square")
            {
                double number = double.Parse(Console.ReadLine());
                double sum = number * number;
                Console.WriteLine("{0:F3}", sum);
            }
            else if (type == "rectangle")
            {
                double numberOne = double.Parse(Console.ReadLine());
                double numberTwo = double.Parse(Console.ReadLine());
                double sum = numberOne * numberTwo;
                Console.WriteLine("{0:F3}", sum);
            }
            else if (type == "circle")
            {
                double number = double.Parse(Console.ReadLine());
                double sum = number * number * Math.PI;
                Console.WriteLine("{0:F3}", sum);
            }
            else if (type == "triangle")
            {
                double numberOne = double.Parse(Console.ReadLine());
                double numberTwo = double.Parse(Console.ReadLine());
                double sum = numberOne * numberTwo / 2;
                Console.WriteLine("{0:F3}", sum);
            }
        }
    }
}