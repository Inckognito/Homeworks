using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseaDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            var priceWater = 0.70;
            var priceCoffee = 1.00;
            var priceBeer = 1.70;
            var priceTea = 1.20;

            switch (profession)
            {
                case "Athlete": Console.WriteLine("The Athlete has to pay {0:f2}.", quantity * priceWater); break;
                case "Businessman": Console.WriteLine("The Businessman has to pay {0:f2}.", quantity * priceCoffee); break;
                case "Businesswoman": Console.WriteLine("The Businesswoman has to pay {0:f2}.", quantity * priceCoffee); break;
                case "SoftUni Student": Console.WriteLine("The SoftUni Student has to pay {0:f2}.", quantity * priceBeer); break;
                default: Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * priceTea); break;
            }
        }
    }
}
