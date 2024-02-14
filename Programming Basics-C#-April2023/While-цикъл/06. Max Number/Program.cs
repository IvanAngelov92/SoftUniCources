using System.Security.Cryptography.X509Certificates;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNumber = int.MinValue;
            
            while(input != "Stop")
            {
                int numbers = int.Parse(input);

                if (maxNumber < numbers)
                {
                    maxNumber = numbers;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}