using System;
using System.Linq;

namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));

            int sumOfEvenNums = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddNums = GetSomeOfOddDigits(absValue.ToString());

            int result = sumOfEvenNums * sumOfOddNums;

            Console.WriteLine(result);
        }

        static int GetSomeOfOddDigits(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = Math.Abs(int.Parse(input[i].ToString()));

                if (currentNumber % 2 == 1)
                {
                    sum += currentNumber;
                }
            }

            return sum;
        }

        static int GetSumOfEvenDigits(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i].ToString());

                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }

            return sum;
        }
    }
}
