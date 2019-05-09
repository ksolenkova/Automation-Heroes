using System;

namespace CodingWithCSharp_AutomationHeroes_
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's odd or even:");
            var input = Console.ReadLine();
            int digit = 0;
            bool isParsed = int.TryParse(input, out digit);

            if (isParsed)
            {
                if (digit % 2 == 0)
                {
                    Console.WriteLine($"Number {digit} is even.");
                }
                else
                {
                    Console.WriteLine($"Number {digit} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }
    }
}
