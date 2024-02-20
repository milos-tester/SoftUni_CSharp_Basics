namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password_input = Console.ReadLine();
            string strong_password = "s3cr3t!P@ssw0rd";
            if (password_input.Equals(strong_password)) Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}