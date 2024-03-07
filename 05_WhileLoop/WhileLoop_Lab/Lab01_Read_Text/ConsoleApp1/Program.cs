namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("Stop")) break;
                Console.WriteLine(input);
            }
        }
    }
}
