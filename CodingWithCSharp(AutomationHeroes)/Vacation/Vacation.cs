using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0;
            double discount = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 8.45 * groupCount;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 9.80 * groupCount;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 10.46 * groupCount;
                }

                if (groupCount >= 30)
                {
                    discount = totalPrice * 0.15;
                    totalPrice = totalPrice - discount;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 10.90 * groupCount;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 15.60 * groupCount;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 16 * groupCount;
                }

                if (groupCount >= 100)
                {
                    totalPrice = (groupCount - 10) * 10.90;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 15 * groupCount;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 20 * groupCount;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 22.50 * groupCount;
                }

                if (groupCount >= 10 && groupCount <= 20)
                {
                    discount = totalPrice * 0.05;
                    totalPrice = totalPrice - discount;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
