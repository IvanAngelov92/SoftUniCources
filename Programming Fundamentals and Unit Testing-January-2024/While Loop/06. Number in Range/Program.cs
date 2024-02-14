int number = int.Parse(Console.ReadLine());

while (true)
{
    if (number >= 1 && number <= 100)
    {
        Console.WriteLine($"{number}");
        break;
    }
    else
    {
        number = int.Parse(Console.ReadLine());
    }
}
