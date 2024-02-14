namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinute = int.Parse(Console.ReadLine());

            int totalMinutesExam = (examHour * 60) + examMinute;
            int totalMinutesStudent = (studentHour * 60) + studentMinute;
            double difference = 0;
            double hours = 0;
            double minute = 0;

            if (totalMinutesExam > totalMinutesStudent)
            {
                difference = totalMinutesExam - totalMinutesStudent;
                if (difference >= 1 && difference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference > 30 && difference <= 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start`");
                }
                else if (difference >= 60)
                {
                    hours = Math.Floor(difference / 60);
                    minute = (difference % 60);
                    if (minute < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:0{minute} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:{minute} hours before the start");
                    }
                }
            }
            else if (totalMinutesExam < totalMinutesStudent)
            {
                difference = totalMinutesStudent - totalMinutesExam;
                if(difference >= 1 && difference <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else if (difference >= 60)
                {
                    hours = Math.Floor(difference / 60);
                    minute = (difference % 60);
                    if (minute < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:0{minute} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{minute} hours after the start");
                    }
                }
            }
            else if (totalMinutesExam == totalMinutesStudent)
            {
                Console.WriteLine("On time");
            }

        }
    }
}