using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseClient = new Client(Constants.baseClientName, Constants.baseClientAge);

            var bronze = new BronzeCard(baseClient, 0);
            PrintInfo(bronze, 150);

            var silver = new SilverCard(baseClient, 600);
            PrintInfo(silver, 850);

            var gold = new GoldCard(baseClient, 1500);
            PrintInfo(gold, 1300);
        }

        private static void PrintInfo(Card card, decimal purchaseValue)
        {
            Console.WriteLine($"Purchase value: ${purchaseValue:f2}");
            Console.WriteLine($"Discount rate: {card.DiscountRate:f1}%");
            Console.WriteLine($"Discount: ${card.CalculateDiscount(purchaseValue):f2}");
            Console.WriteLine($"Total: ${card.CalculateTotal(purchaseValue):f2}");
        }
    }
}
