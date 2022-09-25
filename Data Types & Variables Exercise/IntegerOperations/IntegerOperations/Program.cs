using System;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());   
            int fourthNum = int.Parse(Console.ReadLine());

            int firstResult = firstNum + secondNum;
            int secondResult = firstResult / thirdNum;
            int finalResult = secondResult * fourthNum;

            Console.WriteLine(finalResult);
        }
    }
}
