using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').Select(a => a.Trim()).ToArray();
            var result = new List<int> {};

            int takeNumbers = int.Parse(commands[0]);
            int deleteNumbers = int.Parse(commands[1]);
            int neededNumber = int.Parse(commands[2]);

            for (int i = 0; i < takeNumbers; i++)
            {
                result.Add(lineOfDigits[i]);
            }
            for (int i = 0; i < deleteNumbers; i++)
            {
                result.RemoveAt(0);
            }
            if (result.Contains(neededNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            

        }
    }
}
