using System;

namespace MoonWeight
{
    class MoonWeight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight:");
            var input = Console.ReadLine();
            double weight;
            bool isParsed = double.TryParse(input, out weight);

            if (isParsed)
            {
                double moonWeight = weight * 0.17;
                Console.WriteLine($"Your weight on the moon will be: {moonWeight} kg.");
            }
            else
            {
                Console.WriteLine("Please enter your weight!");
            }
        }
    }
}
