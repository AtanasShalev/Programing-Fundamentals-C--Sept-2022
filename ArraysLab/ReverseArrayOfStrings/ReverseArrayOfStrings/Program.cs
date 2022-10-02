using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] chars = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string currentChar = string.Empty;
            for (int i = chars.Length; i > 0; i--)
            {
                currentChar = chars[i - 1];
                Console.Write(currentChar + " ");
            }
            

        }
    }
}
