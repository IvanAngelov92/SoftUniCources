string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

Dictionary<int, int> frequency = new Dictionary<int, int>();

foreach (int number in numbers)
{
    if (frequency.ContainsKey(number))
    {
        frequency[number]++;
    }
    else
    {
        frequency[number] = 1;
    }
}

var sortedFrequency = frequency.OrderBy(pair => pair.Key);

foreach (var pair in sortedFrequency)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}