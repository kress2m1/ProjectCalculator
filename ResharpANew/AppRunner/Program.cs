using System;
using System.Threading;

namespace ResharpANew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserLogin.Validation();

            Console.WriteLine("Welcome to the Calculator Program.\n" +
                              "This is ver 0.01 of the app ");

            Console.WriteLine();
            Thread.Sleep(5000);

            Console.WriteLine("Select the Mathematical Module by inputting a number from 1 - 4\n" +
                              "then confirm your selection by pressing the 'Enter' key on your keypad");

            Console.WriteLine();
            Thread.Sleep(5000);

            Console.WriteLine("Enter '1' for the Division Module\n" +
                              "Enter '2' for the Multiplication Module\n" +
                              "Enter '3' for the Addition Module\n" +
                              "Enter '4' for the Subtraction Module");

            Console.WriteLine();
            SwitchModule.SelectMathsModule();


        }
    }
}
