using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(FibonachiNum(number));
        }

        static UInt64 FibonachiNum (uint number)
        {
            uint a = 0;
            uint b = 1;
            uint c = 1;

            for (uint i = 0; i < number; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
