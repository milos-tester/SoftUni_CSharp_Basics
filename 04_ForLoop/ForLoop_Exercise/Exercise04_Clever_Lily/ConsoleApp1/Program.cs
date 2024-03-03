namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lily_age = int.Parse(Console.ReadLine());
            double washing_machine = double.Parse(Console.ReadLine());
            int toy_price = int.Parse(Console.ReadLine());

            double money_count = 0;
            int toy_count = 0;
            int brother_count = 0;

            for (int i = 1; i <= lily_age; i++)
            {
                if (i % 2 == 0)
                {
                    money_count += 10 * i / 2;
                    brother_count++;
                }
                else toy_count++;
            }

            double sell_toys = toy_count * toy_price;
            double result = (money_count + sell_toys) - brother_count;

            if (result >= washing_machine) Console.WriteLine($"Yes! {result - washing_machine:F2}");
            else Console.WriteLine($"No! {washing_machine - result:F2}");

        }
    }
}