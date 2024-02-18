namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;
            
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 200)
                {
                    count1+=1;
                }
                    else if (input >= 200 && input <= 399)
                {
                    count2+=1;
                }
                    else if (input > 399 && input <= 599)
                {
                    count3+=1;
                }
                    else if (input > 599 && input <= 799)
                {
                    count4+=1;
                }
                    else if (input > 799) 
                {
                    count5+=1;
                }
            }
            double percentage1 = count1 / n * 100;
            double percentage2 = count2 / n * 100;
            double percentage3 = count3 / n * 100;
            double percentage4 = count4 / n * 100;
            double percentage5 = count5 / n * 100;

            Console.WriteLine($"{percentage1:f2}%");
            Console.WriteLine($"{percentage2:f2}%");
            Console.WriteLine($"{percentage3:f2}%");
            Console.WriteLine($"{percentage4:f2}%");
            Console.WriteLine($"{percentage5:f2}%");
            Console.Read();
        }
    }
}