using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());  

            double biggestKeg = double.MinValue;
            string biggestKegModel = string.Empty;
            for (int i = 1; i <= numOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = (Math.PI * (Math.Pow(radius, 2) * height));

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
