namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_input = int.Parse(Console.ReadLine());
            if (number_input % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}