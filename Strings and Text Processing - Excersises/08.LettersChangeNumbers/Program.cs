﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal totalSum = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {
                var leftLetter = char.Parse(inputLine[i].Substring(0, 1));
                var rightLetter = char.Parse(inputLine[i].Substring(inputLine[i].Length - 1));
                var number = decimal.Parse(inputLine[i].Substring(1, inputLine[i].Length - 2));

                if (char.IsUpper(leftLetter))
                {
                    number = number / (leftLetter - 64);
                }
                else if (char.IsLower(leftLetter))
                {
                    number = number * (leftLetter - 96);
                }

                if (char.IsUpper(rightLetter))
                {
                    number = number - (rightLetter - 64);
                }
                else if (char.IsLower(rightLetter))
                {
                    number = number + (rightLetter - 96);
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2} ");
        }
    }
}
