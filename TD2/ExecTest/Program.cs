using System;

namespace ExeTest
{
    class Program
    {
        static void OriginalMain(string[] args)
        {
            if (args.Length == 1)
                Console.WriteLine(args[0]);
            else
                Console.WriteLine("ExeTest <string parameter>");
        }

        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine($"<html><body> Hello from external {args[0]} et {args[1]} </body></html>");
            else
                Console.WriteLine("<html><body> 2 arguments plssssssss </body></html>");
        }
    }
}
