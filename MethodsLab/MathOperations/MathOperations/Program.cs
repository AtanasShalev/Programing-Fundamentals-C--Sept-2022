﻿using System;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            Calculate(firstNum, operators, secondNum);
            Console.WriteLine(Calculate(firstNum, operators, secondNum));
        }

        private static double Calculate(int a, string @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
