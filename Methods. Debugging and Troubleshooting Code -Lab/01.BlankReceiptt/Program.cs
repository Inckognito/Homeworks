using System;

namespace _01.BlankReceiptt
{
    class Program
    {
        static void Main()
        {
            PrintReceipt();
        }

        static void PrintReceiptHeather()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        static void PrintReceipt()
        {
            PrintReceiptHeather();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
    }
}
