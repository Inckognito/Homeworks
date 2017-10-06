using System;

namespace _06.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(widht, height);
            Console.WriteLine(area);
        }

        private static double GetTriangleArea(double widht, double height)
        {
           return widht * height /2;
        }
    }
}
