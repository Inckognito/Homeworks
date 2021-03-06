﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SequenceOfCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine()); 

            long[] array = Console.ReadLine()                
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();            

            while (command != "stop")
            {
                string[] commandAndArguments = command.Split(' ');
                array = PerformAction(array, commandAndArguments);

                Console.WriteLine(string.Join(" ", array));
              

                command = Console.ReadLine();                 
            }
        }

        static long[] PerformAction(long[] array, string[] action)
        {
            int index = 0;
            int value = 0;
            if (action.Length == 3)
            {
                index = int.Parse(action[1]);
                index--;
                value = int.Parse(action[2]);
            }
            switch (action[0])
            {
                case "multiply":
                    array[index] *= value;
                    break;
                case "add":
                    array[index] += value;
                    break;
                case "subtract":
                    array[index] -= value;
                    break;
                case "lshift":
                    array = ArrayShiftLeft(array);
                    break;
                case "rshift":
                    array = ArrayShiftRight(array);
                    break;
            }
            return array;
        }

        static long[] ArrayShiftRight(long[] array)
        {
            long mem = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = mem;
            return array;
        }

        static long[] ArrayShiftLeft(long[] array)
        {
            long mem = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = mem;
            return array;
        }

        static void PrintArray(long[] array)
        {
            Console.Write(string.Join(" ", array));

        }
    }
}

