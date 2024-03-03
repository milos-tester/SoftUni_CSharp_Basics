namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;

            double result = 0;

            switch (room) {
                case "room for one person":
                    result = nights * 18.00;
                    break;
                case "apartment":
                    result = nights * 25.00;
                    if (days < 10)
                    {
                        result *= 0.70;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        result *= 0.65;
                    }
                    else result *= 0.50;
                    break;
                case "president apartment":
                    result = nights * 35.00;
                    if (days < 10)
                    {
                        result *= 0.90;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        result *= 0.85;
                    }
                    else result *= 0.80;
                    break;
            }
            if (grade.Equals("positive")) result *= 1.25;
            else result *= 0.90;

            Console.WriteLine($"{result:F2}");
        }
    }
}