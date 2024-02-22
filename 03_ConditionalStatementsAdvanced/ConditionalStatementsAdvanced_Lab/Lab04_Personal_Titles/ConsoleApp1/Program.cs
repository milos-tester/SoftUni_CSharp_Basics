namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age_input = double.Parse(Console.ReadLine());
            string gender_input = Console.ReadLine();

            if (gender_input.Equals("m")) {
                if (age_input < 16) Console.WriteLine("Master");
                else Console.WriteLine("Mr.");
            }
            else if (gender_input.Equals("f")) {
                if (age_input < 16) Console.WriteLine("Miss");
                else Console.WriteLine("Ms.");
            }
        }
    }
}