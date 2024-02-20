namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movie_budget = double.Parse(Console.ReadLine());
            int clothes = int.Parse(Console.ReadLine());
            double clothes_price = double.Parse(Console.ReadLine());

            double decor_sum = movie_budget * 0.10;
            double clothes_sum = clothes * clothes_price;
            if (clothes > 150) clothes_sum *= 0.90;

            double total_sum = decor_sum + clothes_sum;

            if (total_sum <= movie_budget) Console.WriteLine($"Action!\nWingard starts filming with {(movie_budget - total_sum):F2} USD left.");
            else Console.WriteLine($"Not enough money!\nWingard needs {(total_sum - movie_budget):F2} USD more.");
        }
    }
}