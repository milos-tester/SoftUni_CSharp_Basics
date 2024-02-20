namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed_input = Double.Parse(Console.ReadLine());
            if (speed_input <= 10) Console.WriteLine("slow");
            else if (speed_input <= 50) Console.WriteLine("average");
            else if (speed_input <= 150) Console.WriteLine("fast");
            else if (speed_input <= 1000) Console.WriteLine("ultra fast");
            else Console.WriteLine("extremely fast");
        }
    }
}