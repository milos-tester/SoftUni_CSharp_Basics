namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int points = int.Parse(Console.ReadLine());
            int tournament = 0;
            int counter = 0;

            for (int i = 0; i < n; i++) {
                string input = Console.ReadLine();

                if (input.Equals("W"))
                {
                    points += 2000;
                    tournament += 2000;
                    counter++;
                }
                else if (input.Equals("F"))
                {
                    points += 1200;
                    tournament += 1200;
                }
                else if (input.Equals("SF"))
                {
                    points += 720;
                    tournament += 720;
                }
            }

            double percentage = (double)counter / n * 100;

            Console.WriteLine($"Final points: {points}\nAverage points: {tournament / n}\n{percentage:F2}%");
        }
    }
}
