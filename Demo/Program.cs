using System;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int Age);
            switch (Age)
            {
                case 22:
                    Console.WriteLine("Your Age is Greater than 22");
                    break;
                case 23:
                    Console.WriteLine("Your Age is Less than 22");
                    break;
                default:
                    Console.WriteLine("Your Age equals 22");
                    break;
            }
        }
    }
}
