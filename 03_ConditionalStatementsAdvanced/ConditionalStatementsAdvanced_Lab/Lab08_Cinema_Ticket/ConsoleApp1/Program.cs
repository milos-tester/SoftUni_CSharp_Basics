namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day_input = Console.ReadLine();

            switch (day_input)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}