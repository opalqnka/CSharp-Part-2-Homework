﻿/*Problem 3. Variable in Hexadecimal Format
 *
 *Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
 *Use Windows Calculator to find its hexadecimal representation.
 *Print the variable and ensure that the result is 254.
 */

using System;

namespace _03.VariableInHex
{
    class Program
    {
        static void Main()
        {
            int variable = 0xFE;
            Console.WriteLine("The decimal representation of the hexadecimal 0xFE is {0}", variable);
        }
    }
}
