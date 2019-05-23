using System;

namespace StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int sum = 0;

            while (input > 0)
            {
                int factorial = 1;
                int digit = input % 10;
                input /= 10;

                for (int i = 2; i <= digit; i++)
                {
                    factorial *= i;
                }

                sum += factorial;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
