/*Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */

/*
 For easy checks:
 Number a	 Number b	Equal(with precision eps=0.000001)	Explanation
 5.3	     6.01	    false	                            The difference of 0.71 is too big (> eps)
 5,00000001	 5,00000003	true	                            The difference 0.00000002 < eps
 5,00000005	 5,00000001	true	                            The difference 0.00000004 < eps
-0,0000007	 0,00000007	true	                            The difference 0.00000077 < eps
-4,999999	-4,999998	false                           	Border case. The difference 0.000001 == eps. We consider the numbers are different.
 4,999999	 4,999998	false	                            Border case. The difference 0.000001 == eps. We consider the numbers are different.             
*/

using System;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double eps = 0.000001;
            Console.WriteLine("Please, enter the first number: ");

            //Remember to enter the numbers with a COMMA instead of a DOT: 5,111 and not 5.111
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            //Get the absolute value of the difference of the two numbers
            double difference = Math.Abs(numberTwo - numberOne);
            bool equalNumbers = true;


            if (difference <= eps)
            {
                Console.WriteLine("The numbers are equal up to {0}", eps);
                Console.WriteLine("Equal: {0}", equalNumbers);
            }
            else
            {
                Console.WriteLine("the numbers are not equal up to {0}", eps);
                Console.WriteLine("Equal: {0}", !equalNumbers);
            }

/*
//Remove the /* signs above and below the following code for easy check of the code with the given examples
//Put the same signs in the above code (only one of the codes shoule be running!)
 
            double[] aValues = {5.3, 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999};
            double[] bValues = {6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998};
            double difference;
            bool equalNumbers = true;

            for(int i = 0; i < aValues.Length; i++)
            {
                difference = Math.Abs(aValues[i] - bValues[i]);
                if (difference <= eps)
                {
                    Console.WriteLine("The numbers are equal up to {0}", eps);
                    Console.WriteLine("Equal: {0}", equalNumbers);
                }
                else
                {
                    Console.WriteLine("The numbers are not equal up to {0}", eps);
                    Console.WriteLine("Equal: {0}", !equalNumbers);
                }                       
            }
 //The other sign is below:
 */

        }
    }
}
