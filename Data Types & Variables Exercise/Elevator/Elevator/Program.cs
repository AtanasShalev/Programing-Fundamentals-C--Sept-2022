using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPpl = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPpl / capacityOfElevator);
            
            Console.WriteLine(courses);
        }
    }
}
