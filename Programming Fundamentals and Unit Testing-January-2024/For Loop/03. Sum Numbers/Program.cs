int number = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= number; i++)
{
    double numbers = double.Parse(Console.ReadLine());
    sum += numbers;
}
Console.WriteLine(sum);