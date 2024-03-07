namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.00;
            while (true)
            {
                string input = (Console.ReadLine());
                if (input.Equals("NoMoreMoney")) {
                    Console.WriteLine($"Total: {sum:F2}");
                    break;
                }
                else {
                    if (double.Parse(input) < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        Console.WriteLine($"Total: {sum:F2}");
                        break;
                    }
                    sum += double.Parse(input);
                    Console.WriteLine($"Increase: {double.Parse(input):F2}");

                }
                
            }
        }
    }
}