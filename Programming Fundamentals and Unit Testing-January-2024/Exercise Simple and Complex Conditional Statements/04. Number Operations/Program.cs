double numberOne = double.Parse(Console.ReadLine());
double numberTwo = double.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();

double result = 0;

switch (mathOperator)
{
    case "+":
        result = numberOne + numberTwo;
        break;
    case "-":
        result = numberOne - numberTwo;
        break;
    case "*":
        result = numberOne * numberTwo;
        break;
    case "/":
        result = numberOne / numberTwo;
        break;
}

Console.WriteLine($"{numberOne} {mathOperator} {numberTwo} = {result:f2}");
