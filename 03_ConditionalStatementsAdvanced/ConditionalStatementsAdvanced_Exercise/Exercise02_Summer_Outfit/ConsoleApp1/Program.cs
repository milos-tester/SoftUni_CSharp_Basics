namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string day_time = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (day_time.Equals("Morning"))
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (day_time.Equals("Afternoon"))
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degrees > 24)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (day_time.Equals("Evening")) {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}