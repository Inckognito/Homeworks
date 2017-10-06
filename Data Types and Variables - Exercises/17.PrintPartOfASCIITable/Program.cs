using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= stopNumber; i++)
            {
                Console.Write((char)i + " ");

            }
            Console.WriteLine();
        }
    }
}

