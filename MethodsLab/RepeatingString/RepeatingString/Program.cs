using System;

namespace RepeatingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int timesRepeated = int.Parse(Console.ReadLine());

            RepeatString(input, timesRepeated);
        }

        static void RepeatString(string input, int timesRepeated)
        {
            for (int i = 0; i < timesRepeated; i++)
            {
                Console.Write(input);
            }
        }
    }
}
