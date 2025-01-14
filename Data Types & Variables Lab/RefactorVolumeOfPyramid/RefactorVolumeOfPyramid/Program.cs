﻿using System;

namespace RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double pyramidVolume = 0;

            pyramidVolume = (length * width * height) / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {pyramidVolume:f2}");
        }
    }
}
