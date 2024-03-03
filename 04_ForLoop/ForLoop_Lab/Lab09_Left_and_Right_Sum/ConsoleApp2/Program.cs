namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left_sum = 0;
            int right_sum = 0;

            for (int i = 0; i < n; i++)
            {
                left_sum += int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < n; i++) {
                right_sum += int.Parse(Console.ReadLine());
            }

            if (left_sum == right_sum) Console.WriteLine($"Yes, Sum = {left_sum}");
            else Console.WriteLine($"No, Diff = {Math.Abs(left_sum - right_sum)}");
        }
    }
}