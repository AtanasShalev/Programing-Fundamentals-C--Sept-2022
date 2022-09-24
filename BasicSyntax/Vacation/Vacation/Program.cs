using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPpl = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();  
            string dayOfWeek = Console.ReadLine();

            double priceForStay = 0;
            double discount = 0;
            double totalPrice = 0;

            if (dayOfWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    priceForStay = 8.45;
                    totalPrice = countOfPpl * priceForStay;

                    if(countOfPpl >= 30)
                    {
                        discount = totalPrice * 0.15;
                        totalPrice -= discount;
                    }
                }
                else if (groupType == "Business")
                {
                    priceForStay = 10.90;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 100)
                    {
                        discount = 10 * priceForStay;
                        totalPrice -= discount;
                    }
                }
                else if (groupType == "Regular")
                {
                    priceForStay = 15;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 10 && countOfPpl <= 20)
                    {
                        discount = totalPrice * 0.05;
                        totalPrice -= discount;
                    }
                }
            }
            else if(dayOfWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    priceForStay = 9.80;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 30)
                    {
                        discount = totalPrice * 0.15;
                        totalPrice -= discount;
                    }
                }
                else if (groupType == "Business")
                {
                    priceForStay = 15.60;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 100)
                    {
                        discount = 10 * priceForStay;
                        totalPrice -= discount;
                    }
                }
                else if (groupType == "Regular") 
                {
                    priceForStay = 20;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 10 && countOfPpl <= 20)
                    {
                        discount = totalPrice * 0.05;
                        totalPrice -= discount;
                    }
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    priceForStay = 10.46;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 30)
                    {
                        discount = totalPrice * 0.15;
                        totalPrice -= discount;
                    }
                }
                else if (groupType == "Business")
                {
                    priceForStay = 16;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 100)
                    {
                        discount = 10 * priceForStay;
                        totalPrice -= discount;
                    }
                }
                else if (groupType == "Regular")
                {
                    priceForStay = 22.50;
                    totalPrice = countOfPpl * priceForStay;

                    if (countOfPpl >= 10 && countOfPpl <= 20)
                    {
                        discount = totalPrice * 0.05;
                        totalPrice -= discount;
                    }
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
