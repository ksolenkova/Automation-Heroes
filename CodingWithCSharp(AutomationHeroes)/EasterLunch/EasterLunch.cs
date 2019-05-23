using System;

namespace EasterLunch
{
    class EasterLunch
    {
        static void Main(string[] args)
        {
            int easterBreadCount = int.Parse(Console.ReadLine());
            int eggsBark = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());
            
            double priceForEasterBread = 3.20 * easterBreadCount;        
            double priceForEggsBark = 4.35 * eggsBark;
            double priceForCookies = 5.40 * cookies;
            double priceForEggsPaint = 0.15 * 12 * eggsBark;
            double totalLunchCost = priceForEasterBread + priceForEggsBark + priceForCookies + priceForEggsPaint;

            Console.WriteLine($"{totalLunchCost:f2}");
        }
    }
}
