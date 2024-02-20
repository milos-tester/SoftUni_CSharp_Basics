namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_number = int.Parse(Console.ReadLine());
            int second_number = int.Parse(Console.ReadLine());
            if (first_number > second_number) Console.WriteLine(first_number);
            else Console.WriteLine(second_number);
        }
    }
}