using System;

namespace EasterBakery
{
    class EasterBakery
    {
        static void Main(string[] args)
        {
            double pricePerKgFlour = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggBark = int.Parse(Console.ReadLine());
            int yeast = int.Parse(Console.ReadLine());

            double sugarPerKg = pricePerKgFlour * 0.75;
            double eggBarkPrice = pricePerKgFlour * 1.1;
            double yeastPrice = sugarPerKg * 0.2;
            double flourAmount = pricePerKgFlour * flourKg;
            double sugarAmount = sugarPerKg * sugarKg;
            double eggBarkAmount = eggBark * eggBarkPrice;
            double yeastAmount = yeastPrice * yeast;

            double totalAmount = flourAmount + sugarAmount + eggBarkAmount + yeastAmount;

            Console.WriteLine($"{totalAmount:f2}");
        }
    }
}
