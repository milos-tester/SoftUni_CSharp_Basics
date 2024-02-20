namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series_name = Console.ReadLine();
            int episode_duration = int.Parse(Console.ReadLine());
            int break_duration = int.Parse(Console.ReadLine());

            double lunch_time = break_duration / 8.0;
            double rest_time = break_duration / 4.0;

            double remaining_time = break_duration - lunch_time - rest_time;

            int needed_time = (int)Math.Ceiling(episode_duration - remaining_time);
            int remain_time = (int)Math.Ceiling(remaining_time - episode_duration);

            if (remaining_time >= episode_duration) Console.WriteLine($"You have enough time to watch {series_name} and left with {remain_time} minutes free time.");
            else Console.WriteLine($"You don't have enough time to watch {series_name}, you need {needed_time} more minutes.");
        }
    }
}