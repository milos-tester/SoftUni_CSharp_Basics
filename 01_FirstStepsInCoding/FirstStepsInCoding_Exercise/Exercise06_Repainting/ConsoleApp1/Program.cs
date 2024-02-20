namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sum_for_nylon = (nylon + 2) * 1.50;
            double sum_for_paint = (paint * 1.10) * 14.50;
            double sum_for_detergent = detergent * 5.00;
            double sum_for_bags = 0.40;
            double total_sum = sum_for_nylon + sum_for_paint + sum_for_detergent + sum_for_bags;
            double sum_for_workers = (total_sum * 0.30) * hours;
            double result_sum = total_sum + sum_for_workers;

            Console.WriteLine(result_sum);
        }
    }
}