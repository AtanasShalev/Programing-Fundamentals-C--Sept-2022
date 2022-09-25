using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timesPouringWater = int.Parse(Console.ReadLine());

            int waterTankCapacity = 255;
            int litersPoured = 0;

            for (int i = 1; i <= timesPouringWater; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                litersPoured += liters;

                if (litersPoured > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersPoured -= liters;
                }

            }

            Console.WriteLine(litersPoured);
        }
    }
}
