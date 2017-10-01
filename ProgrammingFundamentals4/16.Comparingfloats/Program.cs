using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparingfloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double biggerNumber = Math.Max(a, b);
            double smallerNumber = Math.Min(a, b);
            double difference = biggerNumber - smallerNumber;

            bool check = difference < 0.000001;

            Console.WriteLine(check);
        }
    }
}
