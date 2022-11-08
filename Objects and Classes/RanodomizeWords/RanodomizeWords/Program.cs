using System;
using System.Collections.Generic;
using System.Linq;


namespace RanodomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            

            for (int i = 0; i < input.Length; i++)
            {
                Random random = new Random();
                int rndNum = random.Next(0, input.Length);

                string currentWord = input[i];
                string rndWord = input[rndNum];

                input[i] = rndWord;
                input[rndNum] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
                
        }
    }
}
