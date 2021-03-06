﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";
            string input = Console.ReadLine();           

            foreach (Match m in  Regex.Matches(input, pattern))
            {
                Console.WriteLine(m);
            }
        }
    }
}
