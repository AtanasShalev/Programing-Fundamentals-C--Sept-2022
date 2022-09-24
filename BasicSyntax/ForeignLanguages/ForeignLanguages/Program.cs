using System;

namespace ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                int result = num * multiplier;
                Console.WriteLine($"{num} X {multiplier} = {result}");
                return;
            }

            for (int m = multiplier; m <= 10; m++)
            {
                int result = num * m;

                Console.WriteLine($"{num} X {m} = {result}");
            }
        }
    }
}
