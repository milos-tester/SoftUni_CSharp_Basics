namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMin;
            int arriveTime = arriveHour * 60 + arriveMin;

            int diff;

            if (arriveTime == examTime) Console.WriteLine("On time");
            else if (arriveTime < examTime)
            {
                diff = examTime - arriveTime;
                if (diff <= 30)
                {
                    Console.WriteLine($"On time\n{diff} minutes before the start");
                }
                else if (diff < 60)
                {
                    Console.WriteLine($"Early\n{diff} minutes before the start");
                }
                else
                {
                    int printHours = diff / 60;
                    int printMin = diff % 60;

                    if (printMin < 10)
                    {
                        Console.WriteLine($"Early\n{printHours}:0{printMin} hours before the start");
                    }
                    else Console.WriteLine($"Early\n{printHours}:{printMin} hours before the start");
                }
            }
            else {
                diff = arriveTime - examTime;
                if (diff < 60) Console.WriteLine($"Late\n{diff} minutes after the start");

                else
                {
                    int printHours = diff / 60;
                    int printMin = diff % 60;
                    if (printMin < 10)
                    {
                        Console.WriteLine($"Late\n{printHours}:0{printMin} hours after the start");
                    }
                    else Console.WriteLine($"Late\n{printHours}:{printMin} hours after the start");

                }
            }
        }
    }
}
