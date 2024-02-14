int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

int operation = numberOne * numberTwo * numberThree;

if (operation > 0)
{
    Console.WriteLine("positive");
}
else if (operation < 0)
{
    Console.WriteLine("negative");
}
else
{
    Console.WriteLine("zero");
}
