namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < min) min = input;
                if (input > max) max = input;

            }
            Console.WriteLine($"Max number: {max}\nMin number: {min}");
        }
    }
}
