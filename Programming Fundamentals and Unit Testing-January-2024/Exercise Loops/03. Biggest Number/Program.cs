int number = int.Parse(Console.ReadLine());
int maxNumber = int.MinValue;

for (int i = 1; i <= number; i++)
{
    int value = int.Parse(Console.ReadLine());

    if (value > maxNumber)
    {
        maxNumber = value;
    }
}
Console.WriteLine(maxNumber);