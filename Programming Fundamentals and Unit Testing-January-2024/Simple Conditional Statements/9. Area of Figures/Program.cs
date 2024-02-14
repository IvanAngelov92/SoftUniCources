string type = Console.ReadLine();
double area = 0;

switch (type)
{
    case "square":
        double side = double.Parse(Console.ReadLine());
        area = side * side;
        break;
    case "rectangle":
        double width = double.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        area = width * length;
        break;
    case "circle":
        double radius = double.Parse(Console.ReadLine());
        area = Math.PI * radius * radius;
        break;
}

Console.WriteLine($"{area:f2}");
