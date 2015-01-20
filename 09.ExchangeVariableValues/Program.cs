/*Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/

using System;

namespace _09.ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Initial values:\na  = {0} and b = {1}", a, b);
            //Use third variable to exchange the values of a and b
            int transfer = b;
            b = a;
            a = transfer;
            Console.WriteLine("Final values:\na = {0} and b = {1}", a, b);
        }
    }
}
