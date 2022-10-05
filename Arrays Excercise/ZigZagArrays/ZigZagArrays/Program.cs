using System;
using System.Linq;

namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfColumns = int.Parse(Console.ReadLine());

            int[] arr1 = new int[numOfColumns];

            int[] arr2 = new int[numOfColumns];

            for (int i = 1; i <= numOfColumns; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = nums[0];
                int secondNum = nums[1];

                if (i % 2 == 0)
                {
                    arr1[i - 1] = secondNum;
                    arr2[i - 1] = firstNum;
                }
                else
                {
                    arr1[i - 1] = firstNum;
                    arr2[i - 1] = secondNum;
                }

            }

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
