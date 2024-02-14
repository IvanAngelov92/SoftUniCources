double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double addingResult = firstNumber + secondNumber;
double subtractionResult = firstNumber - secondNumber;
double multiplicationResult = firstNumber * secondNumber;
double divisionResult = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:f2} + {secondNumber:f2} = {addingResult:f2}");
Console.WriteLine($"{firstNumber:f2} - {secondNumber:f2} = {subtractionResult:f2}");
Console.WriteLine($"{firstNumber:f2} * {secondNumber:f2} = {multiplicationResult:f2}");
Console.WriteLine($"{firstNumber:f2} / {secondNumber:f2} = {divisionResult:f2}");