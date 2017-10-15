using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();
                List<string> lineOfCommands = Console.ReadLine().ToLower().Split().ToList();

                while (lineOfCommands[0] != "odd" && lineOfCommands[0] != "even")
                {
                    if (lineOfCommands[0] == "delete")
                    {
                        int deleteElement = int.Parse(lineOfCommands[1]);
                        for (int i = 0; i < lineOfDigits.Count; i++)
                        {
                            if (lineOfDigits[i] == deleteElement)
                            {
                                lineOfDigits.Remove(deleteElement);
                                i--;
                            }
                        }
                    }
                    else
                    {
                        int insertElement = int.Parse(lineOfCommands[1]);
                        int insertPosition = int.Parse(lineOfCommands[2]);
                        lineOfDigits.Insert(insertPosition, insertElement);
                    }
                    lineOfCommands = Console.ReadLine().ToLower().Split().ToList();
                }
                if (lineOfCommands[0] == "odd")
                {
                    for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
                    {
                        if (lineOfDigits[cycle] % 2 == 1)
                        {
                            Console.Write(lineOfDigits[cycle] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
                    {
                        if (lineOfDigits[cycle] % 2 != 1)
                        {
                            Console.Write(lineOfDigits[cycle] + " ");
                        }
                    }
                    Console.WriteLine();

                }
                }
            }
        }
    }
