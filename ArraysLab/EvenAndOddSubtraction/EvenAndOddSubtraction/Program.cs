using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int evenNumsBox = 0;
            int oddNumsBox = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumsBox += currentNumber;
                }
                else
                {
                    oddNumsBox += currentNumber;
                }
            }

            int result = evenNumsBox - oddNumsBox;  
            Console.WriteLine(result);
        }
    }
}
