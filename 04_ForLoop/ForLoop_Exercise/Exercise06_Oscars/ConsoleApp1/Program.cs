namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academy_points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string accessor_name = Console.ReadLine();
                double accessor_points = double.Parse(Console.ReadLine());

                academy_points += (accessor_name.Length * accessor_points) / 2;

                if (academy_points > 1250.5) {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {academy_points:F1}!");
                    break;
                }
            }
            if (academy_points <= 1250.5) {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5-academy_points):F1} more!");
            }
        }
    }
}