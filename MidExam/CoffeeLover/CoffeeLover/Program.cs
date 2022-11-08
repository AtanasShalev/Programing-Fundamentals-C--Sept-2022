using System;
using System.Collections.Generic;
using System.Linq;


namespace CoffeeLover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine()
                .Split(' ')
                .ToList();
            int numOfCoffees = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfCoffees; i++)
            {

                string[] command = Console.ReadLine()
                .Split(' ');
                string cmdArgs = command[0];

                if (cmdArgs == "Include")
                {
                    string coffeeName = command[1];
                    coffees.Add(coffeeName);
                }
                else if (cmdArgs == "Remove")
                {
                    string firstOrLast = command[1];
                    int indexToRemove = int.Parse(command[2]);

                    if (firstOrLast == "first")
                    {
                        if (indexToRemove > coffees.Count)
                        {
                            continue;
                        }

                        coffees.RemoveRange(0, indexToRemove);
                    }
                    else if (firstOrLast == "last")
                    {
                        if (indexToRemove > coffees.Count)
                        {
                            continue;
                        }

                        coffees.RemoveRange(coffees.Count - indexToRemove, indexToRemove);
                    }

                }
                else if (cmdArgs == "Prefer")
                {
                    int indexToPrefer = int.Parse(command[1]);
                    int indexToReplace = int.Parse(command[2]);

                    if (indexToPrefer > coffees.Count || indexToReplace > coffees.Count
                        || indexToPrefer < coffees.Count || indexToReplace < coffees.Count)
                    {
                        continue;
                    }

                    var temp = coffees[indexToReplace];
                    coffees[indexToReplace] = coffees[indexToPrefer];
                    coffees[indexToPrefer] = temp;


                }
                else if (cmdArgs == "Reverse")
                {
                    coffees.Reverse();

                }

            }
                Console.WriteLine("Coffees:");
                Console.WriteLine(string.Join(" ", coffees));
        }
    }
}
