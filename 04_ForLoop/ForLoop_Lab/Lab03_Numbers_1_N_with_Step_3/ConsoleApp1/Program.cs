﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i+=3) {
                Console.WriteLine(i);
            }
        }
    }
}
