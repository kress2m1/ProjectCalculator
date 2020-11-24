using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ResharpANew
{
    public class AdditionModule
    {
        /*
         * This module is used for simple addition
         * calculations for the Calculator program
         */

        public static void AddMore()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the first number");
            var numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Please enter the second number");
            var numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            var total = numberOne + numberTwo;

            Console.WriteLine($"The addition of {numberOne} & {numberTwo} is: {total}");
            Thread.Sleep(10000);
        }
    }
}
