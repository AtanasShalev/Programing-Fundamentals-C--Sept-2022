using System;

namespace TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                char firstCh = (char)('a' + i);

                for (int j = 0; j < num; j++)
                {
                    char secondCh = (char)('a' + j);
                    
                    for (int k = 0; k < num; k++)
                    {
                        char thirdCh = (char)('a' + k);
                        Console.WriteLine($"{firstCh}{secondCh}{thirdCh}");
                    }
                }
            }
        }
    }
}
