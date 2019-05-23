using System;

namespace EasterParty
{
    class EasterParty
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            double pricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.10;
            double partyAmount = 0.0;

            if (guestCount >= 10 && guestCount <= 15)
            {
                pricePerPerson = pricePerPerson * 0.85;
            }
            else if (guestCount > 15 && guestCount <= 20)
            {
                pricePerPerson = pricePerPerson * 0.8;
            }
            else if (guestCount > 20)
            {
                pricePerPerson = pricePerPerson * 0.75;
            }

            partyAmount = guestCount * pricePerPerson + cakePrice;

            if (budget < partyAmount)
            {
                double neededMoney = partyAmount - budget;
                Console.WriteLine($"No party! {neededMoney:F2} leva needed.");
            }       
            else
            {
                double moneyLeft = budget - partyAmount;
                Console.WriteLine($"It is party time! {moneyLeft:F2} leva left.");
            }
        }
    }
}
