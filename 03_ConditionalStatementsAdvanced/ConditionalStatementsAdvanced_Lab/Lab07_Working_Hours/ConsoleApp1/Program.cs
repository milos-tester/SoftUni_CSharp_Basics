namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour_input = int.Parse(Console.ReadLine());
            string day_input = Console.ReadLine();

            if (hour_input >= 10 && hour_input <= 18) {
                if (day_input.Equals("Monday") || day_input.Equals("Tuesday") || day_input.Equals("Wednesday") || day_input.Equals("Thursday") || day_input.Equals("Friday") || day_input.Equals("Saturday")) {
                    Console.WriteLine("open");
                }
                else Console.WriteLine("closed");
            }
            else Console.WriteLine("closed");
        }
    }
}