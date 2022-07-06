using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnCsharpProjects
{
    public class Coffee_Time
    {
        Dictionary<string, int> coffee;
        public Coffee_Time()
        {
            coffee = new Dictionary<string, int>
            {
                { "Americano", 50 },
                { "Latte", 70 },
                { "Flat White", 60 },
                { "Espresso", 60 },
                { "Cappuccino", 80 },
                { "Mocha", 90 }
            };
        }
        public void discount_all_prices(int discount)
        {
            foreach (var item in coffee.Keys.ToArray())
            {
                var oldprice = coffee[item];
                var discountAmount = oldprice * discount / 100;
                Console.WriteLine($"{item}: {oldprice - discountAmount}");
            }
        }

    }
}
