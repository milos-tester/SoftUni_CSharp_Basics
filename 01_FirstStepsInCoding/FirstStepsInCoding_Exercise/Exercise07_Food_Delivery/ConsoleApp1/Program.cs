namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int chicken_input = int.Parse(Console.ReadLine());
            int fish_input = int.Parse(Console.ReadLine());
            int vegetarian_input = int.Parse(Console.ReadLine());

            double price_for_food = chicken_input * 10.35 + fish_input * 12.40 + vegetarian_input * 8.15;
            double price_for_desert = price_for_food * 0.20;
            double result = price_for_food + price_for_desert + 2.50;
            Console.WriteLine(result);
        }
    }
}