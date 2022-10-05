using System;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] wagons = new int[int.Parse(Console.ReadLine())];

            int totalPplInWagons = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());

                totalPplInWagons += wagons[i];
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(totalPplInWagons);
        }
    }
}
