using System;

namespace ReverseArrayOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] currentCh = Console.ReadLine()
                .ToCharArray();

            for (int i = 0; i > currentCh.Length; i--)
            {
                Console.Write($"{currentCh[i]} ");
            }
        }
    }
}
