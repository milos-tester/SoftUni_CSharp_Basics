namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_of_inputs = int.Parse(Console.ReadLine());

            int left_sum = 0;
            int right_sum = 0;

            for (int i = 0; i < number_of_inputs; i++) { 
                left_sum += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number_of_inputs; i++) { 
                right_sum += int.Parse(Console.ReadLine());
            }

            if (left_sum == right_sum) Console.WriteLine($"Yes, sum = {left_sum}");
            else Console.WriteLine($"No, diff = {Math.Abs(left_sum - right_sum)}");
        }
    }
}