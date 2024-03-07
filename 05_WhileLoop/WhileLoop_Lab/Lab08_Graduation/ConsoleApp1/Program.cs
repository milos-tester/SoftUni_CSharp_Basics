namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            int grade_counter = 0;
            int bad_grade = 0;
            double sum = 0.00;

            while (true)
            {
                double input = double.Parse(Console.ReadLine());
                grade_counter++;

                if (input < 4.00) {
                bad_grade++;}

                if (bad_grade > 1) {
                    Console.WriteLine($"{student} has been excluded at {grade_counter - 1} grade");
                    break;
                }

                sum += input;
                if (grade_counter == 12) break;
            }

            if (grade_counter == 12) {
                Console.WriteLine($"{student} graduated. Average grade: {(sum / 12):F2}");
            }
        }
    }
}
