/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

using System;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int? intTrial = null;
            double? doubleTrial = null;
            Console.WriteLine("Trying to print: {0} {1}" + "... Nothing happens", intTrial, doubleTrial);

            //add some random numbers
            Console.WriteLine("Trying to print: {0} {1}" + "... Nothing happens", (intTrial + 4), (doubleTrial + 34.55));

            //Add null litteral
            Console.WriteLine("Trying to print: {0} {1}" + "... Nothing happens", (intTrial + null), (doubleTrial + null));
            //as it is noted above with green underline - The result of the expression is always 'null' of type 'int?'
            //for reference see http://msdn.microsoft.com/en-us/library/2cf62fcy.aspx where it is written the following:
            /*The predefined unary and binary operators and any user-defined operators that exist for value types may also be used by nullable types. 
             *These operators produce a null value if the operands are null; otherwise, the operator uses the contained value to calculate the result.
             */
  
        }
    }
}
