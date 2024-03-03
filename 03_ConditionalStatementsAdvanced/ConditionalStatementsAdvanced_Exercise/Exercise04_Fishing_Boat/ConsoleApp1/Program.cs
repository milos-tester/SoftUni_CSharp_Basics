namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;

            if (season.Equals("Spring"))
            {
                price = 3000;
                if (fishermen <= 6)
                {
                    price *= 0.90;
                }
                else if (fishermen > 6 && fishermen <= 11)
                {
                    price *= 0.85;
                }
                else if (fishermen > 11)
                {
                    price *= 0.75;
                }
            }
            else if (season.Equals("Summer") || season.Equals("Autumn"))
            {
                price = 4200;
                if (fishermen <= 6)
                {
                    price *= 0.90;
                }
                else if (fishermen > 6 && fishermen <= 11)
                {
                    price *= 0.85;
                }
                else if (fishermen > 11)
                {
                    price *= 0.75;
                }
            }
            else if (season.Equals("Winter")) {
                price = 2600;
                if (fishermen <= 6)
                {
                    price *= 0.90;
                }
                else if (fishermen > 6 && fishermen <= 11)
                {
                    price *= 0.85;
                }
                else if (fishermen > 11)
                {
                    price *= 0.75;
                }
            }

            if (fishermen % 2 == 0 && !season.Equals("Autumn")) {
                price *= 0.95;
            }

            if (budget >= price) Console.WriteLine($"Yes! You have {(budget - price):F2} USD left.");
            else Console.WriteLine($"Not enough money! You need {(price - budget):F2} USD.");
        }
    }
}