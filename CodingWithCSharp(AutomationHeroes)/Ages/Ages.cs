using System;

namespace Ages
{
    class Ages
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int age = 0;
            bool isParsed = int.TryParse(input, out age);

            if (isParsed)
            {
                if (age >= 0 && age <= 2)
                {
                    Console.WriteLine("baby");
                }
                else if (age >= 3 && age <= 13)
                {
                    Console.WriteLine("child");
                }
                else if (age >= 14 && age <= 19)
                {
                    Console.WriteLine("teenager");
                }
                else if (age >= 20 && age <= 65)
                {
                    Console.WriteLine("adult");
                }
                else
                {
                    Console.WriteLine("elder");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }
    }
}
