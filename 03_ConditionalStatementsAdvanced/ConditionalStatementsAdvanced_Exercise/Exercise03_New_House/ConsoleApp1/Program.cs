namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower_type = Console.ReadLine();
            int flowers_number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.00;
            if (flower_type.Equals("Roses"))
            {
                price = flowers_number * 5.00;
                if (flowers_number > 80) price *= 0.90;
            }
            else if (flower_type.Equals("Dahlias"))
            {
                price = flowers_number * 3.80;
                if (flowers_number > 90) price *= 0.85;
            }
            else if (flower_type.Equals("Tulips"))
            {
                price = flowers_number * 2.80;
                if (flowers_number > 80) price *= 0.85;
            }
            else if (flower_type.Equals("Narcissus"))
            {
                price = flowers_number * 3.00;
                if (flowers_number < 120) price *= 1.15;
            }
            else if (flower_type.Equals("Gladiolus")) {
                price = flowers_number * 2.50;
                if (flowers_number < 80) price *= 1.20;
            }

            if (budget >= price) Console.WriteLine($"Hey, you have a great garden with {flowers_number} {flower_type} and {(budget - price):F2} USD left.");
            else Console.WriteLine($"Not enough money, you need {(price - budget):F2} USD more.");
        }
    }
}
