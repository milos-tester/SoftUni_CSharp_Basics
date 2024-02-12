namespace Lab07_Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string architect_name = Console.ReadLine();
            int number_of_projects = int.Parse(Console.ReadLine());
            int result = number_of_projects * 3;
            Console.WriteLine($"The architect {architect_name} will need {result} hours to complete {number_of_projects} project/s.");
        }
    }
}