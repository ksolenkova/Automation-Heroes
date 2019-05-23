using System;

namespace PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {

            double amountMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double saberAdditional = Math.Ceiling(countStudents * 0.10);
            double saberAmount = (saberAdditional + countStudents) * lightsaberPrice;
            double robesAmount = countStudents * robePrice;
            double freeBelt = Math.Floor(countStudents / 6.00);
            double beltsAmount = (countStudents - freeBelt) * beltPrice;

            double totalAmount = saberAmount + robesAmount + beltsAmount;
            if (amountMoney >= totalAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {totalAmount:F2}lv.");
            }
            else
            {
                double neededMoney = totalAmount - amountMoney;
                Console.WriteLine($"Ivan Cho will need {neededMoney:F2}lv more.");
            }
        }
    }
}
