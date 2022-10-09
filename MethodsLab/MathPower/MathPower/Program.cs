using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());

            NumberCalculator(number, powerNumber);
        }

        static void NumberCalculator(double number, int powerNumber)
        {
            double result = 1;

            result = Math.Pow(number, powerNumber);

            Console.WriteLine(result);
        }
    }
}
