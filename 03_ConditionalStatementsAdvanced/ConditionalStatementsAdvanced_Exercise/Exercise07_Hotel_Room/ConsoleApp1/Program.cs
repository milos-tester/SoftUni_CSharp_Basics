using System.Runtime;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            switch(month)
            {
                case "May":
                case "October":
                    studio = 50.00;
                    apartment = 65.00;
                    if (nights > 7 && nights <= 14) studio *= 0.95;
                    else if (nights > 14)
                    {
                        studio *= 0.70;
                        apartment *= 0.90;
                    }
                    break;
                case "June":
                case "September":
                    studio = 75.20;
                    apartment = 68.70;
                    if (nights > 14) 
                    { 
                        studio *= 0.80;
                        apartment *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                    studio = 76.00;
                    apartment = 77.00;
                    if (nights > 14) apartment *= 0.90;
                    break;
            }

            studio = studio * nights;
            apartment = apartment * nights;

            Console.WriteLine($"Apartment: {apartment:F2} USD.\nStudio: {studio:F2} USD.");
        }
    }
}
