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
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.Write("Weekend");
                    break;
                default: Console.WriteLine("Error");
                    break;
            }
        }
    }
}