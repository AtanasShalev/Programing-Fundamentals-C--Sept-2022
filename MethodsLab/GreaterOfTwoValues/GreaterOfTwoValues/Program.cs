using System;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (type == "int")
            {
                int firsInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);

                int result = GetMax(firsInt, secondInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);

                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if(type == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
                
            return secondNumber;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
                
            return secondChar;
        }

        static string GetMax(string firstString, string secondString)
        {
            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i < firstString.Length; i++)
            {
                sumA += firstString[i];
            }

            for (int i = 0; i < secondString.Length; i++)
            {
                sumB += secondString[i];
            }

            if (sumA > sumB)
            {
                return firstString;
            }
            
            return secondString;
        }
    }
}
