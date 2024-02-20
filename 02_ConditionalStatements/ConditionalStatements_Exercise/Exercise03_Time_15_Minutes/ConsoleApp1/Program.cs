namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int total_time = hours * 60 + minutes + 15;

            int total_hours = total_time / 60;
            int total_minutes = total_time % 60;

            if (total_hours >= 24) total_hours = 0;

            if (total_minutes < 10) Console.WriteLine($"{total_hours}:0{total_minutes}");
            else Console.WriteLine($"{total_hours}:{total_minutes}");
        }
    }
}