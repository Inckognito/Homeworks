using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }
                string name = lines[i];
                string email = lines[i + 1];

                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }
                string result = $"{name} -> {email}";
                File.AppendAllText("output.txt", result + Environment.NewLine);
            }

        }
    }
}
