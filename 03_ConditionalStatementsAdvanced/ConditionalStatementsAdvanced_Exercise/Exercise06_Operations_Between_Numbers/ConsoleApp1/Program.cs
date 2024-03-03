using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            string type = "";
            double finalResult = 0.00;

            switch (operation)
            {
                case "+":
                    int result = numberOne + numberTwo;
                    if (result % 2 == 0) type = "even";
                    else type = "odd";
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {type}");
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    if (result % 2 == 0) type = "even";
                    else type = "odd";
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {type}");
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    if (result % 2 == 0) type = "even";
                    else type = "odd";
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {type}");
                    break;
                case "/":
                    if (numberTwo == 0) {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                        break;
                    }
                    else {
                        finalResult = numberOne / (double)numberTwo;
                        Console.WriteLine($"{numberOne} {operation} {numberTwo} = {finalResult:F2}");
                    }
                    break;
                case "%":
                    if (numberTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                        break;
                    }
                    finalResult = numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {finalResult}");
                    break;
            }
        }
    }
}