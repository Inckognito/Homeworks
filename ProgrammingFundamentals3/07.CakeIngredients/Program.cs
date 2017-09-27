using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ingredientsNumber = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
                ingredientsNumber++;
            }

            Console.WriteLine($"Preparing cake with {ingredientsNumber} ingredients.");
        }
    }
}