using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = File.ReadAllText("imput.txt").Split(' ').Select(int.Parse).ToArray();
            var number = 0;
            var occurence = new int[65535];
            var minJ = 0;
            var arrNum = new List<int>();
            var occurencies = 0;

            for (int i = 0; i < input.Length; i++)
            {
                occurence[input[i]]++;
            }

            var max = occurence.Max();
            for (int i = 0; i < occurence.Length; i++)
            {
                if (max == occurence[i])
                {
                    number = i;
                    occurencies++;

                }
            }

            if (occurencies > 1)
            {
                for (int j = 0; j < input.Length; j++)
                {

                    if (input[j] == number)
                    {
                        if (j < minJ)
                        {
                            minJ = j;
                        }


                    }
                }
                File.WriteAllLines("output.txt",new string[minJ]);
            }

            else File.WriteAllText("output.txt", number.ToString());


        }
    }
}
