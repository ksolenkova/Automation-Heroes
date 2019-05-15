using System;

namespace TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int column = 1; column <= n; column++)
            {
                for (int i = 1; i <= column; i++)
                {
                    Console.Write(column + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
