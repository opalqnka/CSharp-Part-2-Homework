/*Problem 2. Float or Double?
 *
 *Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
 *34.567839023, 12.345, 8923.1234857, 3456.091?
 *Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

using System;

namespace _02.FloatOrDouble
{
    class Program
    {
        static void Main()
        {
            //remember to convert the real numbers to floats whenever we declare a float variable!
            double FirstNumber = 34.567839023;
            float SecondNumber = 12.345f;
            double ThirdNumber = 8923.1234857;
            float ForthNumber = 3456.091f;

            Console.WriteLine("First number = {0}\nSecond number = {1}\nThird number = {2}\nForth number = {3}", 
                FirstNumber, SecondNumber, ThirdNumber, ForthNumber);

        }
    }
}
