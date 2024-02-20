namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade_input = double.Parse(Console.ReadLine());
            if (grade_input >= 5.5) Console.WriteLine("Excellent!");
        }
    }
}