using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double validNum1 = 0.1;
            double validNum2 = 0.2;
            double validNum3 = 0.5;
            double validNum4 = 1.0;
            double validNum5 = 2.0;

            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;

            double moneyBox = 0;

            while (true)
            {

                string command = Console.ReadLine();

                while (command == "Start")
                {
                    string command2 = Console.ReadLine();

                    if (moneyBox >= nutsPrice)
                    {
                        moneyBox -= nutsPrice;
                        Console.WriteLine("Purchased nuts");
                    }
                    else if (moneyBox >= waterPrice)
                    {
                        moneyBox -= waterPrice;
                        Console.WriteLine("Purchased water");
                    }
                    else if (moneyBox >= crispsPrice)
                    {
                        moneyBox -= crispsPrice;
                        Console.WriteLine("Purchased crisps");
                    }
                    else if (moneyBox >= sodaPrice)
                    {
                        moneyBox -= sodaPrice;
                        Console.WriteLine("Purchased soda");
                    }
                    else if (moneyBox >= cokePrice)
                    {
                        moneyBox -= cokePrice;
                        Console.WriteLine("Purchased coke");
                    }

                    if (command2 == "End")
                    {
                        Console.WriteLine($"Change: {moneyBox:f2}");
                        break;
                    }

                    double command1 = double.Parse(command);

                if (command1 != validNum1 || command1 != validNum2 || command1 != validNum3 
                    || command1 != validNum4 || command1 != validNum5)
                {

                }
                else
                {
                    Console.WriteLine($"Cannot accept {command1}");
                }

                    moneyBox += command1;

                }

            }
        }
    }
}
