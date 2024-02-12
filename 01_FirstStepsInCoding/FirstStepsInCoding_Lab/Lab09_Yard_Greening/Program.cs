namespace Lab09_Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters_input = double.Parse(Console.ReadLine());
            double full_price = meters_input * 7.61;
            double discount = full_price * 0.18;
            double final_price = full_price - discount;

            Console.WriteLine($"The final price is: {final_price} USD.\nThe discount is: {discount} USD.");
        }
    }
}