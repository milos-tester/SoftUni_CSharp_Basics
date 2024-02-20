namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());
            double basketballSneakers = annualFee - (annualFee * 0.40);
            double basketballOutfit = basketballSneakers - (basketballSneakers * 0.20);
            double ball = basketballOutfit * 0.25;
            double basketballAccessories = ball * 0.20;
            double result = annualFee + basketballSneakers + basketballOutfit + ball + basketballAccessories;
            Console.WriteLine(result);
        }
    }
}