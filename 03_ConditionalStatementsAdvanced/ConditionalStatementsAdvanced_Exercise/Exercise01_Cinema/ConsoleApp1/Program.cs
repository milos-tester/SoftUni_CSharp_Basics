namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int size = rows * cols;
            double result = 0;

            if (type.Equals("Premiere")) result = size * 12.00;
            else if (type.Equals("Normal")) result = size * 7.50;
            else if (type.Equals("Discount")) result = size * 5.00;

            Console.WriteLine($"{result:F2} USD");
        }
    }
}