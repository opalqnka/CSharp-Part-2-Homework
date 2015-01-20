/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card 
numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */


using System;

namespace _11.BankAccountData
{
    class Program
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Ivanov";
            string lastName = "Petrov";
            double balance = 7899.34;
            string bankName = "Ultra Cool Bank, LTD";
            string IBAN = "BG80 BNBG 9661 1020 3456 78";
            //Credit cards have 16 digit codes
            ulong creditCard_1 = 1234567890123456L;
            ulong creditCard_2 = 2345678901234567L;
            ulong creditCard_3 = 3456789012345678L;

            Console.WriteLine("Printing information for\n{0} {1} {2}:\n\nCurrent Balance: {3}\nBank name: {4}\nIBAN: {5}\n\nCredit cards:\nCredit card 1: {6}\nCredit card 2: {7}\nCredit Card 3: {8}",
                firstName, middleName, lastName, balance, bankName, IBAN, creditCard_1, creditCard_2, creditCard_3);
        }
    }
}
