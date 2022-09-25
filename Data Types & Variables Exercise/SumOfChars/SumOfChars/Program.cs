using System;

namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            int sumOfChars = 0;
            for (int i = 1; i <= numOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sumOfChars += (int)letter;
            }

            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
