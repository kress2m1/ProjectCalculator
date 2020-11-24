using System;
using System.Collections.Generic;
using System.Text;

namespace ResharpANew
{
    public class SwitchModule
    {
        /*
         * This is a switch class that will enable the
         * end-user to switch between whichever mathematical
         * function that they intend to use
         */

        public static void SelectMathsModule()
        {
            var moduleSelector = Convert.ToInt32(Console.ReadLine());

            switch (moduleSelector)
            {
                case 1:
                    Console.WriteLine($"You have selected {moduleSelector} for the Addition Module");
                    AdditionModule.AddMore();
                    break;
                case 2:
                    Console.WriteLine($"You have selected {moduleSelector} for the Subtraction Module");
                    SubtractionModule.SubtractMore();
                    break;
                case 3:
                    Console.WriteLine($"You have selected {moduleSelector} for the Multiplication Module");
                    MultiplicationModule.MultiplyMore();
                    break;
                case 4:
                    Console.WriteLine($"You have selected {moduleSelector} for the Division Module");
                    DivisionModule.DivideMore();
                    break;
                default:
                    Console.WriteLine($"You have selected an incorrect value {moduleSelector}");
                    Console.WriteLine($"Please select a Mathematical Module by inputting a number from 1 - 4");
                    break;
            }
        }
    }
}
