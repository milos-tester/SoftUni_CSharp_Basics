namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double records = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double seconds_per_meter = double.Parse(Console.ReadLine());

            double swim_time = meters * seconds_per_meter;

            double added_time = Math.Floor(meters / 15) * 12.5;
            double result = swim_time + added_time;

            if (result < records) Console.WriteLine($"Yes, he succeeded! The new world record is {result:F2} seconds.");
            else Console.WriteLine($"No, he failed! He was {(result - records):F2} seconds slower.");
        }
    }
}