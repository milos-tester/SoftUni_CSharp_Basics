namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("Stop")) break;
                else
                {
                    if (int.Parse(input) < min)
                    {
                        min = int.Parse(input);
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
