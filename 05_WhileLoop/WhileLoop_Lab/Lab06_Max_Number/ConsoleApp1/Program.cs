namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;

            while (true) {
                string input = Console.ReadLine();
                if (input.Equals("Stop")) break;
                else {
                    if (int.Parse(input) > max) {
                        max = int.Parse(input);
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
