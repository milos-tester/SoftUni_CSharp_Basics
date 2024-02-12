namespace Lab08_Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog_packages = int.Parse(Console.ReadLine());
            int cat_packages = int.Parse(Console.ReadLine());
            double result = dog_packages * 2.50 + cat_packages * 4.00;
            Console.WriteLine($"{result} USD.");
        }
    }
}