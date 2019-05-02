using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomerRegisterApp.Customer
{
    public static class CustomerBuilder
    {
        public static string GetCustomerDetails()
        {
            Console.WriteLine("Enter customers first name:");
            string firstName = GetValidCustomerName();
            Console.WriteLine("Enter customers second name:");
            string secondName = GetValidCustomerName();
            Console.WriteLine("Enter customers telephone number:");
            string number = GetValidCustomerTelNum();
            Console.WriteLine("Enter customers date of birth in format: DD/MM/YYYY");
            string dob = GetValidDOB().ToString();

            return $"First name: {firstName}, Last name: {secondName}, Tel: {number}, DOB: {dob}";
        }

        private static string GetValidCustomerName()
        {
            string input;
            Regex regexItem = new Regex("[0-9!@+\\#$%^&*(),.?\":{}|<>]");

            while (true)
            {
                input = Console.ReadLine();

                if (!regexItem.IsMatch(input) && input.Length < 30 && Char.IsUpper(input[0]))
                    return input;

                Console.WriteLine("Names cannot contain numbers 0-9, contain special characters,");
                Console.WriteLine("be greater than 30 characters or have lower case first letters.");
                Console.WriteLine("Please try again");
            }
        }

        private static string GetValidCustomerTelNum()
        {
            string input;
            Regex regexItem = new Regex("[a-zA-Z!@#$%^&*(),.?\":{}|<>]");

            while (true)
            {
                input = Console.ReadLine();

                if (!regexItem.IsMatch(input) && input.Length == 11)
                    return input;

                Console.WriteLine("Phone num can only contain 11 digits.");
                Console.WriteLine("Please try again");
            }
        }

        private static string GetValidDOB()
        {
            string input = Console.ReadLine();
            while (true)
            {
                try
                {
                    DateTime.Parse(input);
                    return input;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not in the format of DD/MM/YYYY");
                    Console.WriteLine("Please try again");
                    input = Console.ReadLine();
                }
            }
        }

    }
}
