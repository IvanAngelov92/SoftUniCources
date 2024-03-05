int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue;
int minNumber = int.MaxValue;

for (int i = startIndex; i <= endIndex; i++)
{
    if (numbers[i] > maxNumber)
        maxNumber = numbers[i];
    if (numbers[i] < minNumber)
        minNumber = numbers[i];
}

int sum = maxNumber + minNumber;

Console.WriteLine(sum);