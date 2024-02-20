namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string geoFigura = Console.ReadLine();
            double p;

            if (geoFigura == "square")
            {
                double a = Double.Parse(Console.ReadLine());
                p = a * a;
                Console.WriteLine($"{p:F3}");
            }

            else if (geoFigura == "rectangle")
            {
                double a = Double.Parse(Console.ReadLine());
                double b = Double.Parse(Console.ReadLine());
                p = a * b;
                Console.WriteLine($"{p:F3}");


            }

            else if (geoFigura == "circle")
            {
                double r = Double.Parse(Console.ReadLine());
                p = r * r * Math.PI;
                Console.WriteLine($"{p:F3}");
            }

            else if (geoFigura == "triangle")
            {
                double a = Double.Parse(Console.ReadLine());
                double b = Double.Parse(Console.ReadLine());
                p = (a * b) / 2;
                Console.WriteLine($"{p:F3}");
            }
        }
    }
}