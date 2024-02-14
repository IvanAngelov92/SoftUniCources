namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSantimeters = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double fixedDistance = Math.Floor(distanceInMeters / 15);

            double neededDistance = distanceInMeters * timeInSeconds;
            double every15Meters = fixedDistance * 12.5;
            double allTime = neededDistance + every15Meters;

            if (recordInSantimeters > allTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:F2} seconds.");
            }
            else
            {
                double diff = allTime - recordInSantimeters;
                Console.WriteLine($"No, he failed! He was {diff:F2} seconds slower.");
            }
        }
    }
}