using System;

namespace LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();

            bool letterIsUpper = Char.IsUpper(letter, 0);
            bool letterIsLower = Char.IsLower(letter, 0);

            if (letterIsUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
