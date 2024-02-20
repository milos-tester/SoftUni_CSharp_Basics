namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volume_in_liters = volume / 1000;
            double occupied_space = percentage / 100;
            double result = volume_in_liters * (1 - occupied_space);
            Console.WriteLine(result);
        }
    }
}