static void CalculateRectangleArea(int width, int length)
{
    int area = width * length;
    Console.WriteLine(area);
}

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

CalculateRectangleArea(width, length);