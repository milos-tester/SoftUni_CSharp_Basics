namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantitiy = double.Parse(Console.ReadLine());
            double price = 0;
            double result = 0;
            /*
             city / product	coffee	water	beer	sweets	peanuts
                    London	0.50	0.80	1.20	1.45	1.60
                    Rome	0.40	0.70	1.15	1.30	1.50
                    Paris	0.45	0.70	1.10	1.35	1.55

             */
            switch (city)
            {
                case "London":
                    if (product.Equals("coffee")) price = 0.50;
                    else if (product.Equals("water")) price = 0.80;
                    else if (product.Equals("beer")) price = 1.20;
                    else if (product.Equals("sweets")) price = 1.45;
                    else if (product.Equals("peanuts")) price = 1.60;
                    break;
                case "Rome":
                    if (product.Equals("coffee")) price = 0.40;
                    else if (product.Equals("water")) price = 0.70;
                    else if (product.Equals("beer")) price = 1.15;
                    else if (product.Equals("sweets")) price = 1.30;
                    else if (product.Equals("peanuts")) price = 1.50;
                    break;
                case "Paris":
                    if (product.Equals("coffee")) price = 0.45;
                    else if (product.Equals("water")) price = 0.70;
                    else if (product.Equals("beer")) price = 1.10;
                    else if (product.Equals("sweets")) price = 1.35;
                    else if (product.Equals("peanuts")) price = 1.55;
                    break;
            }

            result = price * quantitiy;
            Console.WriteLine(result);
        }
    }
}