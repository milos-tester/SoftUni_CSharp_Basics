namespace Lab04_Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch_input = double.Parse(Console.ReadLine());
            double centimeters = inch_input * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}