namespace Lab03_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side_a = int.Parse(Console.ReadLine());
            int side_b = int.Parse(Console.ReadLine());
            int area = side_a * side_b;
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}