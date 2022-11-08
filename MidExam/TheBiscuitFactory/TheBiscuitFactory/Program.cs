using System;

namespace TheBiscuitFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfBiscuitsProdPerWorker = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int numOfBisProdByCompFactory = int.Parse(Console.ReadLine());

            double amountOfBisPerDay = amountOfBiscuitsProdPerWorker * countOfWorkers;
            double amountOfBisFor20DaysWithFullCap = amountOfBisPerDay * 20;
            double amountOfBisfor10DaysWith75PercProd = Math.Floor(amountOfBisPerDay * 10 * 0.75);

            double biscuitsProducedFor30Days = amountOfBisFor20DaysWithFullCap + amountOfBisfor10DaysWith75PercProd;

            double diffBetweenFactories = Math.Abs(biscuitsProducedFor30Days - numOfBisProdByCompFactory);

            double diffPercentage = diffBetweenFactories / numOfBisProdByCompFactory * 100;

            if (biscuitsProducedFor30Days > numOfBisProdByCompFactory)
            {
                Console.WriteLine($"You have produced {biscuitsProducedFor30Days} biscuits for the past month.");
                Console.WriteLine($"You produce {diffPercentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You have produced {biscuitsProducedFor30Days} biscuits for the past month.");
                Console.WriteLine($"You produce {diffPercentage:f2} percent less biscuits.");
            }
        }
    }
}
