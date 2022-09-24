using System;

namespace PoundToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = int.Parse(Console.ReadLine());

            pounds = pounds * (decimal)1.31;

            Console.WriteLine($"{pounds:f3}");
        }
    }
}
