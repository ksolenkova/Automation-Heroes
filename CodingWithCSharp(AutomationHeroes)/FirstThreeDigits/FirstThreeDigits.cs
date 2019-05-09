using System;

namespace FirstThreeDigits
{
    class FirstThreeDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 real numbers:");
            double sum = 0.0;

            for (int i = 0; i < 3; i++)
            {
                double input = double.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine($"The sum of the entered digits is {sum}.");
        }
    }
}
