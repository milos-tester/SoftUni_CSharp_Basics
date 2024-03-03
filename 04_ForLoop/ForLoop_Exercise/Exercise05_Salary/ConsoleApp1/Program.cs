namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input.Equals("Facebook")) salary -= 150;
                else if (input.Equals("Instagram")) salary -= 100;
                else if (input.Equals("Reddit")) salary -= 50;

                if (salary <= 0) {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0) Console.WriteLine(salary);
        }
    }
}