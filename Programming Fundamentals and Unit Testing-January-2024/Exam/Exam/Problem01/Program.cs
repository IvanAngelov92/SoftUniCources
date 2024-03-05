string text = Console.ReadLine();

int upperCount = 0;
int lowerCount = 0;
int spaceCount = 0;

foreach (char c in text)
{
    if (char.IsUpper(c))
    {
        upperCount++;
    }
    else if (char.IsLower(c))
    {
        lowerCount++;
    }
    else if (c == ' ')
    {
        spaceCount++;
    }
}

Console.WriteLine(upperCount);
Console.WriteLine(lowerCount);
Console.WriteLine(spaceCount);