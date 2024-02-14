int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

if (balance > withdraw)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (limit < withdraw)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (balance < withdraw && balance < limit)
{
    Console.WriteLine("Insufficient availability.");
}
