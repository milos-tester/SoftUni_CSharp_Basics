namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_of_pages = int.Parse(Console.ReadLine());
            int pages_per_hour = int.Parse(Console.ReadLine());
            int number_of_days = int.Parse(Console.ReadLine());
            int total_read_time = number_of_pages / pages_per_hour;
            int result = total_read_time / number_of_days;
            Console.WriteLine(result);
        }
    }
}