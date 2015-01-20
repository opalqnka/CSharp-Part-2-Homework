/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and
assign a Unicode-friendly font in the console.
*/
using System;
using System.Text;

namespace _08.IsoselesTriangle
{
    class Program
    {
        static void Main()
        {
            // Change the console character encoding to UTF-8
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';
            Console.WriteLine("      {0}\n    {0}   {0}\n  {0}       {0}\n{0}   {0}   {0}   {0}\n", symbol);
            //Set the Console font from Properties to "Lucida Console"
        }
    }
}
