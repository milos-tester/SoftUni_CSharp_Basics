namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int video_cards = int.Parse(Console.ReadLine());
            int cpus = int.Parse(Console.ReadLine());
            int rams = int.Parse(Console.ReadLine());

            double video_cards_price = video_cards * 250;
            double cpus_price = (video_cards_price * 0.35) * cpus;
            double rams_price = (video_cards_price * 0.10) * rams;

            double total_price = video_cards_price + cpus_price + rams_price;

            if (video_cards > cpus) total_price *= 0.85;

            if (total_price <= budget) Console.WriteLine($"You have {(budget - total_price):F2} USD left!");
            else Console.WriteLine($"Not enough money! You need {(total_price - budget):F2} USD more!");
        }
    }
}