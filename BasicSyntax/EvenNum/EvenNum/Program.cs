﻿using System;

namespace EvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {num}");
                }
                else
                {
                    Console.WriteLine("Please write even number");
                    continue;
                }
            }
        }
    }
}
