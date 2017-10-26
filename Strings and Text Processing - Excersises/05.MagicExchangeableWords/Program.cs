using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            string firstWord = input[0];
            string secondWord = input[1];

            var firstArray = firstWord.ToCharArray().Distinct().ToArray();
            var secondArray = secondWord.ToCharArray().Distinct().ToArray();
            if (firstArray.Length == secondArray.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
