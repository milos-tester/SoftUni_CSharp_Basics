namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip_price = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talking_dolls = int.Parse(Console.ReadLine());
            int teddy_bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total_price = puzzles * 2.60 + talking_dolls * 3.00 + teddy_bears * 4.10 + minions * 8.20 + trucks * 2.00;
            int toys_number = puzzles + talking_dolls + teddy_bears + minions + trucks;

            if (toys_number >= 50) total_price *= 0.75;

            double result = total_price * 0.90;

            if (result >= trip_price) Console.WriteLine($"Yes! {(result - trip_price):F2} USD left.");
            else Console.WriteLine($"Not enough money! {(trip_price - result):F2} USD needed.");
        }
    }
}