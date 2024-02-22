namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_input = int.Parse(Console.ReadLine());
            if (number_input >= 100 && number_input <= 200 || number_input == 0)
            {
            }
            else Console.WriteLine("invalid");
        }
    }
}