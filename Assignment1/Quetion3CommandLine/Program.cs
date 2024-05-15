using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quetion3CommandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No command-line arguments provided.");

            }
            else
            {
                Console.WriteLine("Command-line arguments:");
                // Loop through each argument and print it
                
               int num1 = Convert.ToInt32(args[0]);
                int num2 = Convert.ToInt32(args[1]);
                Console.WriteLine("Addition is  = "+(num1+num2));
            }
            Console.ReadLine();
        }
    }
}
