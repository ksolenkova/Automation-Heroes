using System;

namespace VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            var coins = Console.ReadLine();
            decimal totalMoney = 0;

            while (coins != "Start")
            {
                switch (coins)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        totalMoney += decimal.Parse(coins);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }

                coins = Console.ReadLine();
            }

            var product = Console.ReadLine();
            decimal productPrice = 0;

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0m;
                        break;
                    case "Water":
                        productPrice = 0.7m;
                        break;
                    case "Crisps":
                        productPrice = 1.5m;
                        break;
                    case "Soda":
                        productPrice = 0.8m;
                        break;
                    case "Coke":
                        productPrice = 1.0m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (totalMoney >= productPrice && totalMoney > 0 && productPrice > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    totalMoney = totalMoney - productPrice;
                }
                else if (totalMoney > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();

            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
