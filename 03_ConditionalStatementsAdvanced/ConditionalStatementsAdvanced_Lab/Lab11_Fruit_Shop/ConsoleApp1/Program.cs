﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit_input = Console.ReadLine();
            string day_input = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            double result = 0;
            switch (day_input)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit_input)
                    {
                        case "banana":
                            price = 2.50;
                            break;
                        case "apple":
                            price = 1.20;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "kiwi":
                            price = 2.70;
                            break;
                        case "pineapple":
                            price = 5.50;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;
                        default: Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit_input)
                    {
                        case "banana":
                            price = 2.70;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.90;
                            break;
                        case "grapefruit":
                            price = 1.60;
                            break;
                        case "kiwi":
                            price = 3.00;
                            break;
                        case "pineapple":
                            price = 5.60;
                            break;
                        case "grapes":
                            price = 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default : Console.WriteLine("error");
                    break;
            }
            if (price > 0) {
                result = price * quantity;
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}