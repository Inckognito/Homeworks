using System;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            foreach (Match number in Regex.Matches(input, pattern))
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
