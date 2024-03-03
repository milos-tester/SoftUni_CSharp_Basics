using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int makalu = 0;
            int mont_blanc = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input <= 5) { 
                    makalu += input;
                }
                else if (input <= 12) {
                    mont_blanc += input; 
                }
                else if ((input <= 25)) {
                    kilimanjaro += input;
                }
                else if (input <= 40) {
                    k2 += input; 
                }
                else { 
                    everest += input; 
                }

                total += input;
                
            }
            double p1 = (double)makalu / total * 100;
            double p2 = (double)mont_blanc / total * 100;
            double p3 = (double)kilimanjaro / total * 100;
            double p4 = (double)k2 / total * 100;
            double p5 = (double)everest / total * 100;
            Console.WriteLine($"{p1:F2}%\n{p2:F2}%\n{p3:F2}%\n{p4:F2}%\n{p5:F2}%");
        }
    }
}
