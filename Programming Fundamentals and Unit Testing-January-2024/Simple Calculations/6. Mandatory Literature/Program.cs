int numberOfPages = int.Parse(Console.ReadLine());
int readeingPagesForHour = int.Parse(Console.ReadLine());
int daysToFinishBook = int.Parse(Console.ReadLine());

int totalTime = numberOfPages / readeingPagesForHour;
int hoursPerDay = totalTime / daysToFinishBook;

Console.WriteLine($"{hoursPerDay}");