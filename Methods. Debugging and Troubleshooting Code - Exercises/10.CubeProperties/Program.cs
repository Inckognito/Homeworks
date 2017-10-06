using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double faceDiagonals = Math.Sqrt(Math.Pow(side, 2) *2);
            double spaceDiagonals = Math.Sqrt(Math.Pow(side, 2) * 3);
            double volume = Math.Pow(side, 3);
            double area = Math.Pow(side, 2) * 6;

           switch (type)
           {
               case "face": Console.WriteLine("{0:F2}", faceDiagonals);
                   break;
               case "space": Console.WriteLine("{0:f2}", spaceDiagonals);
                   break;
               case "volume": Console.WriteLine("{0:f2}", volume);
                   break;
               case "area": Console.WriteLine("{0:f2}", area);
                   break;
           }
        }
    }
}
