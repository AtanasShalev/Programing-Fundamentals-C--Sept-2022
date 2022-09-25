using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            int sumOfDigits = 0;
            int sum = 0;

            while (num > 0)
            {
                sumOfDigits = num % 10;
                sum += sumOfDigits;

                num /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
