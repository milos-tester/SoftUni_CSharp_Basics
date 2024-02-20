namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double amountInterest = deposit * interest / 100;
            double monthInterest = amountInterest / 12;
            double amount = deposit + term * monthInterest;

            Console.WriteLine(amount);
        }
    }
}