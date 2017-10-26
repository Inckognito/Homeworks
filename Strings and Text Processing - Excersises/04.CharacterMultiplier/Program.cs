using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var firstString = input[0];
            var secondString = input[1];
            var sum = 0;
            int minL = Math.Min(firstString.Length, secondString.Length);

            for (int i = minL - 1; i >= 0; i--)
            {
                sum += secondString[i] * firstString[i];
            }
            string rest = "";
            if (firstString.Length > secondString.Length)
            {
                rest = firstString.Substring(minL);
            }
            else
            {
                rest = secondString.Substring(minL);
            }

            foreach (char ch in rest)
            {
                sum += ch;
            }
            Console.WriteLine(sum);

        }
    }
}

