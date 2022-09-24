using System;

namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine()); 

            pounds = pounds * (decimal)1.31;

            Console.WriteLine($"{pounds:f3}");
        }
    }
}
