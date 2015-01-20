/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.
*/

using System;

namespace _10.EmploeeData
{
    class Program
    {
        static void Main()
        {
            string firstName = "Ivan";
            string lastName = "Ivanov";
            byte age = 25;
            char gender = 'm';
            ulong personalIDNumber = 8306112507;
            ulong uniqueEmployeeNumber = 27560000927569999L;

            Console.WriteLine("Employee: {0} {1}, age {2}, gender: {3}\nPersonal ID Number: {4},\nUnique Employee Number: {5}", 
                firstName, lastName, age, gender, personalIDNumber, uniqueEmployeeNumber);

        }
    }
}
