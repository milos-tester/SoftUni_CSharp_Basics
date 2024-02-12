using System.Security.Cryptography;
using System;

namespace Lab06_Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string first_name = Console.ReadLine();
            string second_name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {first_name} {second_name}, a {age}-years old person from {town}."); 
        }
    }
}