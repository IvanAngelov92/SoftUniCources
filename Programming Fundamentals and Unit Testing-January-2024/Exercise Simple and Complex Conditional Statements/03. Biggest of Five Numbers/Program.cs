int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());
int numberFour = int.Parse(Console.ReadLine());
int numberFive = int.Parse(Console.ReadLine());

if (numberOne > numberTwo && numberOne > numberThree && numberOne > numberFour && numberOne > numberFive)
{
    Console.WriteLine($"{numberOne}");
}
else if (numberTwo > numberOne && numberTwo > numberThree && numberTwo > numberFour && numberTwo > numberFive)
{
    Console.WriteLine($"{numberTwo}");
}
else if (numberThree > numberOne && numberThree > numberTwo && numberThree > numberFour && numberThree > numberFive)
{
    Console.WriteLine($"{numberThree}");
}
else if (numberFour > numberOne && numberFour > numberTwo && numberFour > numberThree && numberFour > numberFive)
{
    Console.WriteLine($"{numberFour}");
}
else if (numberFive > numberOne && numberFive > numberTwo && numberFive > numberThree && numberFive > numberFour)
{
    Console.WriteLine($"{numberFive}");
}