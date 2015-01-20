/*Problem 1
 * 
 *Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
 *the following values: 52130, -115, 4825932, 97, -10000.
 *Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */

using System;

namespace _01.DeclareVariables
{
    class Program
    {
        static void Main()
        {
            ushort FirstNumber = 52130;
            sbyte SecondNumber = -115;
            uint ThirdNumber = 4825932;
            byte ForthNumber = 97;
            short FifthNumber = -10000;
            Console.WriteLine("The numbers are:\n {0}\n{1}\n{2}\n{3}\n{4}\n", FirstNumber, SecondNumber, ThirdNumber, ForthNumber, FifthNumber);

        }
    }
}
