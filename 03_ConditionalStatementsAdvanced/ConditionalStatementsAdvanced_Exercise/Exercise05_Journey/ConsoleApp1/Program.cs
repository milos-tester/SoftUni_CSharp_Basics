namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string type = "";

            if (budget <= 100)
            {
                if (season.Equals("summer"))
                {
                    budget *= 0.30;
                    destination = "Serbia";
                    type = "Camp";
                }
                else if (season.Equals("winter"))
                {
                    budget *= 0.70;
                    destination = "Serbia";
                    type = "Hotel";
                }
            }
            else if (budget <= 1000) {
                if (season.Equals("summer"))
                {
                    budget *= 0.40;
                    destination = "Balkans";
                    type = "Camp";
                }
                else if (season.Equals("winter"))
                {
                    budget *= 0.80;
                    destination = "Balkans";
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                if (season.Equals("summer"))
                {
                    budget *= 0.90;
                    destination = "Europe";
                    type = "Hotel";
                }
                else if (season.Equals("winter"))
                {
                    budget *= 0.90;
                    destination = "Europe";
                    type = "Hotel";
                }
            }

            Console.WriteLine($"Somewhere in {destination}\n{type} - {budget:F2}");
        }
    }
}
