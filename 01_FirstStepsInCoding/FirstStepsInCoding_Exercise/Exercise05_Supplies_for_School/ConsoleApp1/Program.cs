namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           ⦁	Package of pens- 5.80 USD. 
⦁	Package of markers - 7.20 USD. 
⦁	Detergent- 1.20 USD (for liter)


             */
            int pens_input = int.Parse(Console.ReadLine());
            int markers_input = int.Parse(Console.ReadLine());
            int detergent_input = int.Parse(Console.ReadLine());
            int percentage_discount = int.Parse(Console.ReadLine());

            double price_for_products = pens_input * 5.80 + markers_input * 7.20 + detergent_input * 1.20;
            double result = price_for_products - (price_for_products * percentage_discount / 100);
            Console.WriteLine(result);
        }
    }
}