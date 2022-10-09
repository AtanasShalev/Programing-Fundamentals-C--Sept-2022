using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculationOfProducts(product, quantity);
        }

        private static void CalculationOfProducts(string product, double quantity)
        {
            double productPrice = 0;

            if (product == "coffee")
            {
                productPrice = 1.50;
            }
            else if (product == "water")
            {
                productPrice = 1.00;
            }
            else if (product == "coke")
            {
                productPrice = 1.40;
            }
            else if (product == "snacks")
            {
                productPrice = 2.00;
            }

            double result = productPrice * quantity;

            Console.WriteLine($"{result:f2}");
        }
    }
}
