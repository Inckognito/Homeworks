using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+359( ?-?)2\1\d{3}\1\d{4}\b";
            var phones = Console.ReadLine();
            List<string> result = new List<string>();
            foreach (Match m in Regex.Matches(phones, regex))
            {
                result.Add(m.ToString());
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
