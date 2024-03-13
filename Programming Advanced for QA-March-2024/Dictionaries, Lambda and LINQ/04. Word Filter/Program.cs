List<string> strings = Console.ReadLine()
                        .Split()
                        .ToList();

List<string> filtered = new List<string>();

foreach (string str in strings)
{
    if (str.Length % 2 == 0)
    {
        filtered.Add(str);
    }
}

foreach (string str in filtered)
{
    Console.WriteLine(str);
}