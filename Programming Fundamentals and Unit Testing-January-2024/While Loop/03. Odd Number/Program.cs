int number = int.Parse(Console.ReadLine());

while (true)
{
    if (number % 2 == 0)
    {
        number = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine($"{number}");
        break;
    }
}
