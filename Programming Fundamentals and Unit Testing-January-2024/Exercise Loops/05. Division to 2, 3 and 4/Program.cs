int number = int.Parse(Console.ReadLine());

int numberDivisibleBy2 = 0;
int numberDivisibleBy3 = 0;
int numberDivisibleBy4 = 0;

for (int i = 1; i <= number; i++)
{
    int value = int.Parse(Console.ReadLine());
    if (value % 2 == 0)
    {
        numberDivisibleBy2++;
    }

    if (value % 3 == 0)
    {
        numberDivisibleBy3++;
    }

    if (value % 4 == 0)
    {
        numberDivisibleBy4++;
    }
}
double fixedNumberBy2 = numberDivisibleBy2 * 1.0 / number * 100;
double fixedNumberBy3 = numberDivisibleBy3 * 1.0 / number * 100;
double fixedNumberBy4 = numberDivisibleBy4 * 1.0 / number * 100;

Console.WriteLine($"{fixedNumberBy2:f2}%");
Console.WriteLine($"{fixedNumberBy3:f2}%");
Console.WriteLine($"{fixedNumberBy4:f2}%");