int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

int sumFirstAndSecond = numberOne + numberTwo;
int sumFirstAndThree = numberOne + numberThree;
int sumSecondAndThree = numberTwo + numberThree;

if (numberOne < sumSecondAndThree && numberTwo < sumFirstAndThree && numberThree < sumFirstAndSecond)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}
