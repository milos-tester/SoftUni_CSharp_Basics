namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd_input = double.Parse(Console.ReadLine());
            double bgn_result = 1.79549 * usd_input;
            Console.WriteLine(bgn_result);
        }
    }
}