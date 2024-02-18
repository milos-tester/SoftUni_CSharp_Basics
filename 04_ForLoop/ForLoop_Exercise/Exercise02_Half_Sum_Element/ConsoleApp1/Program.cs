namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_of_inputs = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < number_of_inputs; i++) {
                int input = int.Parse(Console.ReadLine());
                sum += input;
                if (input > max) {
                    max = input;
                }
            }

            int diff = sum - max;

            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max - diff));
            }
        }
    }
}