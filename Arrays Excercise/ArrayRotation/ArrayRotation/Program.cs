using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotationCount = int.Parse(Console.ReadLine());

            int timesToRotate = rotationCount % nums.Length;
            for (int j = 0; j < timesToRotate; j++)
            {
                int firstElement = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i - 1] = nums[i];
                }
                nums[nums.Length - 1] = firstElement;
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
