namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city_input = Console.ReadLine();
            double sales_input = double.Parse(Console.ReadLine());
            bool checker = true;

            switch (city_input)
            {
                case "London":
                    if (sales_input >= 0 && sales_input <= 500) sales_input *= 0.05;
                    else if (sales_input > 500 && sales_input <= 1000) sales_input *= 0.07;
                    else if (sales_input > 1000 && sales_input <= 10000) sales_input *= 0.08;
                    else if (sales_input > 10000) sales_input *= 0.12;
                    else { 
                        checker = false;
                        Console.Write("error"); 
                    }
                    break;
                case "Paris":
                    if (sales_input >= 0 && sales_input <= 500) sales_input *= 0.045;
                    else if (sales_input > 500 && sales_input <= 1000) sales_input *= 0.075;
                    else if (sales_input > 1000 && sales_input <= 10000) sales_input *= 0.10;
                    else if (sales_input > 10000) sales_input *= 0.13;
                    else
                    {
                        checker = false;
                        Console.Write("error");
                    }
                    break;
                case "Rome":
                    if (sales_input >= 0 && sales_input <= 500) sales_input *= 0.055;
                    else if (sales_input > 500 && sales_input <= 1000) sales_input *= 0.08;
                    else if (sales_input > 1000 && sales_input <= 10000) sales_input *= 0.12;
                    else if (sales_input > 10000) sales_input *= 0.145;
                    else
                    {
                        checker = false;
                        Console.Write("error");
                    }
                    break;
                default:
                    {
                        checker = false;
                        Console.Write("error");
                    }
                    break;
            }

            if (checker) {
                Console.WriteLine($"{sales_input:F2}");
            }
        }
    }
}