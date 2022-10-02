using System;
using System.Linq;
using System.Reflection;

namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int arr1SumOfNums = 0;
            int arr2SumOfNums = 0;

            int currentNumInArr1 = 0;
            int currentNumInArr2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            for (int k = 0; k < arr1.Length; k++)
            {
                currentNumInArr1 = arr1[k];
                currentNumInArr1 += arr1SumOfNums;
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                currentNumInArr2 = arr2[j];
                currentNumInArr2 += arr2SumOfNums;
            }

            int sumOfArrays = currentNumInArr1 + currentNumInArr2;
            Console.WriteLine($"Arrays are identical. Sum: {sumOfArrays}");
        }
    }
}
