using System;
using System.Linq;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string reverseUsername = new string(username.Reverse().ToArray());

            for (int i = 0; i < 4; i++)
            {
                string password = Console.ReadLine();

                if (reverseUsername == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
