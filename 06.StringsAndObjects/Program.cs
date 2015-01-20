/*Problem 6. Strings and Objects
 *
 *Declare two string variables and assign them with Hello and World.
 *Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
 *Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
 */
using System;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string variableOne = "Hello";
            string variableTwo = "World";
            object objectVar = variableOne + " " + variableTwo;
            string variableThree = (string)objectVar;
            //Perform a console check
            Console.WriteLine("The concationation of the two strings is {0}", variableThree);
            Console.WriteLine("The object is {0}", objectVar);
        }
    }
}
