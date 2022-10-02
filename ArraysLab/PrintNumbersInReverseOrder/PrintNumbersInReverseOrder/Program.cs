using System;

namespace PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arrNum = new int[number];

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                arrNum[i] = n;  
            }

            for (int i = arrNum.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arrNum[i]} ");
            }
        }
    }
}
