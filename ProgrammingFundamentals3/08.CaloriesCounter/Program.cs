using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ingr;
            int calls = 0;
            for (int i = 0; i < n; i++)
            {
                ingr = Console.ReadLine().ToLower();
                if (ingr == "tomato sauce")
                { calls = calls + 150; }
                if (ingr == "cheese")
                { calls = calls + 500; }
                if (ingr == "salami")
                { calls = calls + 600; }
                if (ingr == "pepper")
                { calls = calls + 50; }
            }
            Console.WriteLine("Total calories: " + calls);
        }
    }
}