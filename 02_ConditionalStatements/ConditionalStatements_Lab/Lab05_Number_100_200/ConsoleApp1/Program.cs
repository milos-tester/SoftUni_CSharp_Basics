namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_input = int.Parse(Console.ReadLine());

            if (number_input < 100) Console.WriteLine("Less than 100");
            else if (number_input > 200) Console.WriteLine("Greater than 200");
            else Console.WriteLine("Between 100 and 200");
        }
    }
}